#pragma checksum "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_YetkilendirmeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8c676b80935abf1a70319fa29acb5508ef10b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__YetkilendirmeLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_YetkilendirmeLayout.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_ViewImports.cshtml"
using WebProjesi.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_ViewImports.cshtml"
using WebProjesi.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_ViewImports.cshtml"
using WebProjesi.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c676b80935abf1a70319fa29acb5508ef10b90", @"/Areas/Identity/Pages/_YetkilendirmeLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e95fbe0eccb26863a246ec101d2411e1868d9dd", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages__YetkilendirmeLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_YetkilendirmeLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/identity/account/login"">Giriş Yap</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/identity/account/register"">Kaydol</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_YetkilendirmeLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Web-Programlama-Projesi-master\WebProjesi\WebProjesi\Areas\Identity\Pages\_YetkilendirmeLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
