#pragma checksum "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8625e52d86a49380c09de5d6e847c62b9c2c87d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ciudad_C), @"mvc.1.0.view", @"/Views/Ciudad/C.cshtml")]
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
#line 1 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/_ViewImports.cshtml"
using Proyecto_net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/_ViewImports.cshtml"
using Proyecto_net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8625e52d86a49380c09de5d6e847c62b9c2c87d5", @"/Views/Ciudad/C.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d41fe32ce26a1ca3fd0f896f471645bdfa049388", @"/Views/_ViewImports.cshtml")]
    public class Views_Ciudad_C : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
  
    ViewData["Title"] = "Ciudad";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
 if (ViewBag.distrito != null)
{
    foreach (var a in @ViewBag.distrito)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 131, "\"", 158, 2);
            WriteAttributeValue("", 138, "/Local/Id/", 138, 10, true);
#nullable restore
#line 10 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
WriteAttributeValue("", 148, a.Idlocal, 148, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"card\" style=\"width: 18rem;\">\n                <img src=\"...\" class=\"card-img-top\" alt=\"...\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 14 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
                                      Write(a.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 15 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
                                                         Write(a.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <p class=\"card-title\">");
#nullable restore
#line 16 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
                                     Write(a.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n        </a>\n");
#nullable restore
#line 20 "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Ciudad/C.cshtml"
    }


}
else
{

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
