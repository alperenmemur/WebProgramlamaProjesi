#pragma checksum "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c81ca19e30b9633f958c689c3c937af3e1dc131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_Details), @"mvc.1.0.view", @"/Views/Film/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\_ViewImports.cshtml"
using WebProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\_ViewImports.cshtml"
using WebProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c81ca19e30b9633f958c689c3c937af3e1dc131", @"/Views/Film/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6084064ec3ebf5c04f2d5656fd20f9251f789a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Film_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProjesi.Models.DetayveYorum>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YorumSil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight-bold  btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
  
    ViewData["Title"] =Model.film.filmIsmi;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c81ca19e30b9633f958c689c3c937af3e1dc1314577", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 15 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.film.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




<div>
    <div class=""align-self-center  "">

        <h4 class=""bg-dark w-25 text-center pb-2 rounded pl-2 pr-2 pt-2 text-white"">Film Detayları</h4>

    </div>
    <div class=""row"">


        <div class=""col card text-white"">
            <div class=""card-body overflow-auto"">
                <div class=""row no-gutters"">
                    <div class=""col-sm-4"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 659, "\"", 689, 1);
#nullable restore
#line 33 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
WriteAttributeValue("", 665, Model.film.filmResimURL, 665, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img kartresim\" alt=\"...\">\n                    </div>\n                    <div class=\"col\">\n                        <div class=\"card-body\">\n                            <h2 class=\"card-title text-capitalize text-center\">");
#nullable restore
#line 37 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                                          Write(Model.film.filmIsmi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                            <h3 class=\"card-title text-capitalize text-center\"> ");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                                           Write(Model.film.filmTuru);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                            <br />\n\n                            <h4 class=\"card-text text-capitalize pl-4 pr-4\">");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                                       Write(Model.film.filmAciklamasi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

                        </div>
                    </div>
                </div>
            </div>



        </div>

    </div>
</div>
<br />

<div class="" text-white"">
    <div class=""align-self-center"">
        <h4 class=""bg-dark w-25 text-center pb-2 rounded pl-2 pr-2 pt-2 text-white"">Filme Yapılan Yorumlar</h4>
    </div>
    

");
#nullable restore
#line 62 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
     if (Model.FilmYorumlar.Count() != 0)
    {





        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
         foreach (var i in Model.FilmYorumlar)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card card-yorum text-white p-2"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""user d-flex flex-row align-items-center"">
                        <img src=""https://i.pinimg.com/736x/75/34/53/753453e3247505c8880956ef39691960.jpg"" width=""30"" class=""user-img rounded-circle mr-2"">
                        <span>
                            <small class=""font-weight-bold  text-primary"">");
#nullable restore
#line 78 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                                     Write(i.Kullanici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                            <br />\n                            <a class=\"font-weight-bold\">");
#nullable restore
#line 80 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                   Write(i.yorumBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            <br />\n                            <small>");
#nullable restore
#line 82 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                              Write(i.Yorum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                            <br />\n\n\n                        </span>\n                    </div>\n");
#nullable restore
#line 88 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                     if (User.Identity.Name == i.Kullanici || User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"align-self-end p-2\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c81ca19e30b9633f958c689c3c937af3e1dc13111428", async() => {
                WriteLiteral("x");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                                                                             WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 93 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n\n            </div>\n");
#nullable restore
#line 97 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"





        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
         





    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n\n\n\n<\n");
#nullable restore
#line 117 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
 if (User.IsInRole("Kullanici") || User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<form method=""post"" asp-controller=""film"" asp-action=""Details"">
    <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
    <div class=""align-self-center  "">

        <h4 class=""bg-dark w-25 text-center pb-2 rounded pl-2 pr-2 pt-2 text-white"">Sende Yorum Yap!</h4>

    </div>


    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th class=""text-center bg-light"">
                    Yorum Yapın
                </th>


            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <textarea asp-for=""yorum.yorumBaslik"" placeholder=""Başlık"" name=""yorumBaslik"" class=""form-control"" required></textarea>
                    <textarea maxlength=""150"" asp-for=""yorum.Yorum"" placeholder=""Yorum"" name=""yorum"" class=""form-control"" required></textarea>
                    <span asp-validation-for=""yorum.Yorum"" class=""text-danger""></span>
                </td>
            </tr>
        </tbody>

");
            WriteLiteral("\n\n    </table>\n\n    <div class=\"align-self-center\">\n\n        <input type=\"submit\" class=\"btn btn-success  w-25\" value=\"Yolla\" />\n        \n\n    </div>\n\n</form>\n");
#nullable restore
#line 160 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Views\Film\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProjesi.Models.DetayveYorum> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
