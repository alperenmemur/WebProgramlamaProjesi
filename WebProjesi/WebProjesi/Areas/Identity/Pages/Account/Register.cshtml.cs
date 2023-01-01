using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using WebProjesi.Areas.Identity.Data;

namespace WebProjesi.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<WebProjesiKullanici> _signInManager;
        private readonly UserManager<WebProjesiKullanici> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        public RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<WebProjesiKullanici> userManager,
            SignInManager<WebProjesiKullanici> signInManager,
            ILogger<RegisterModel> logger,
            RoleManager<IdentityRole> roleManager,
            IEmailSender emailSender
            )
            
            
           
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [MaxLength(30)]
            [MinLength(5)]
            [Display(Name = "Kullanıcı Adı")]
            public string kullaniciAdi { get; set; }
           
            

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new WebProjesiKullanici { UserName = Input.Email, Email = Input.Email,kullaniciAdi=Input.kullaniciAdi,sifre=Input.Password };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    
                    if(Input.Email == "b201210390@sakarya.edu.tr")
                    {
                        if (!await _roleManager.RoleExistsAsync("Admin"))
                        {
                            var admin = new IdentityRole("Admin");
                            var res = await _roleManager.CreateAsync(admin);
                            if (res.Succeeded)
                            {
                                if (Input.Email == "b201210390@sakarya.edu.tr")
                                {
                                    await _userManager.AddToRoleAsync(user, "Admin");
                                }
                            }

                        }
                        else if (await _roleManager.RoleExistsAsync("Admin"))
                        {
                            if (Input.Email == "b201210390@sakarya.edu.tr")
                            {
                                await _userManager.AddToRoleAsync(user, "Admin");
                            }
                        }
                    }
                    

                    else if (!await _roleManager.RoleExistsAsync("Kullanici"))
                    {
                        var kullanici = new IdentityRole("Kullanici");
                        var res = await _roleManager.CreateAsync(kullanici);
                        if (res.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(user, "Kullanici");
                        }
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(user, "Kullanici");
                    }
                    
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("kullanicifilmler", "film");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
