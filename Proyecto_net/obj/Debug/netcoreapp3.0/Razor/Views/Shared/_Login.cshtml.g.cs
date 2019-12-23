#pragma checksum "/Users/jersson/Projects/bookeat/Proyecto_net/Proyecto_net/Views/Shared/_Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9c433d84d81a5a9699cce006d45e8ba9ff0f13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Login), @"mvc.1.0.view", @"/Views/Shared/_Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9c433d84d81a5a9699cce006d45e8ba9ff0f13", @"/Views/Shared/_Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d41fe32ce26a1ca3fd0f896f471645bdfa049388", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<button id=""btnLogin"" class=""btn btn-navbar-login"">Iniciar Sesión</button>

<!--LOGIN-->
<div class=""modal fade"" id=""modalLoginMain"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <!--Content-->
        <div class=""modal-content form-elegant"">
            <!--Header-->
            <div class=""modal-header"">                        
                <a class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fas fa-times""></i></span>
                </a>
            </div>
            <!--Body-->
            <div class=""modal-body mx-4 text-center"">
                <span class=""titulo-modal"">Introduce un email</span>
                <!--Body-->
                <div class=""md-form mb-4 mt-5 text-left"">
                    <input type=""email"" id=""inLoginEmail"" class=""input-modal form-control"" placeholder=""Introduce tu Email"">
                    <span class=""d-none errorL");
            WriteLiteral(@"ogin"" id=""txtErrorEmail"">Email incorrecto</span>
                </div>
                <div class=""text-center mb-3"">
                    <button type=""button"" class=""btn btn-modal"" id=""btnLoginNext"">Siguiente</button>
                </div>
            </div>
        </div>
        <!--/.Content-->
    </div>
</div>
<!--LOGIN USUARIO EXISTENTE-->
<div class=""modal fade"" id=""loginUser"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <!--Content-->
        <div class=""modal-content form-elegant"">
            <!--Header-->
            <div class=""modal-header text-center"">
                <a class=""atras"" aria-label=""back"" id=""atrasLoginUser""><i class=""fas fa-arrow-left""></i></a>
                <a  class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fas fa-times""></i></span>
                </a>
            </div>
            <!--Body-->
            <div class=""m");
            WriteLiteral(@"odal-body mx-4 text-center"">
                <span class=""titulo-modal"" id=""tituloUser""></span>
               
                <!--Body-->
                <div class=""md-form mb-4 mt-5 text-left"">
                    <input type=""password"" id=""inInicioSesionPassword"" class=""input-modal form-control"" placeholder=""Introduce tu contraseña"">
                    <span class=""d-none errorLogin"" id=""txtErrorPassword"">Email incorrecto</span>
                </div>
                <div class=""text-center mb-3"">
                    <button type=""button"" class=""btn btn-modal"" id=""btnLoginUser"">Iniciar sesión</button>
                </div>
            </div>
        </div>
        <!--/.Content-->
    </div>
</div>
<!--FIN LOGIN-->
<!--Registro-->
<div class=""modal fade"" id=""registroCuentaUsuario"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <!--Content-->
        <div class=""modal-content form-elegant"">
            <!--Header");
            WriteLiteral(@"-->
            <div class=""modal-header"">
                <a class=""atras"" aria-label=""back"" id=""atrasLoginCreate""><i class=""fas fa-arrow-left""></i></a>           
                <a class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fas fa-times""></i></span>
                </a>
            </div>
            <!--Body-->
            <div class=""modal-body mx-4 text-center"">
                <span class=""titulo-modal"" id=""txtRegistroUsuarioEmail""></span>
                <!--Body-->
                <div class=""md-form mb-4 mt-5 text-left"">
                    <input type=""text"" id=""inRegistroUsuarioNombre"" class=""input-modal form-control"" placeholder=""Introduce tu nombre"">
                    <span class=""d-none errorLogin"" id=""txtErrorRegistroUsuarioNombre"">Nombre erroneo</span>
                </div>
                <div class=""md-form mb-4 text-left"">
                    <input type=""text"" id=""inRegistroUsuarioApellidos"" class=""input-modal form-cont");
            WriteLiteral(@"rol"" placeholder=""Introduce tus apellidos"">
                    <span class=""d-none errorLogin"" id=""txtErrorRegistroUsuarioApellidos"">Apellidos erroneo</span>
                </div>
                <div class=""md-form mb-4 text-left"">
                    <input type=""text"" id=""inRegistroUsuarioTelefono"" class=""input-modal form-control"" placeholder=""Introduce tu telefono"">
                    <span class=""d-none errorLogin"" id=""txtErrorRegistroUsuarioTelefono"">Telefono erroneo</span>
                </div>
                <div class=""md-form mb-4 text-left"">
                    <input type=""password"" id=""inRegistroUsuarioPassword"" class=""input-modal form-control"" placeholder=""Introduce tu contraseña"">
                    <span class=""d-none errorLogin"" id=""txtErrorRegistroUsuarioPassword"">Contraseña erronea</span>
                </div>
                <div class=""text-center mb-3 text-left"">
                    <button type=""button"" class=""btn btn-modal"" id=""btnRegistrarUsuario"">Crear cuenta</button>
        ");
            WriteLiteral("        </div>\n            </div>\n        </div>\n        <!--/.Content-->\n    </div>\n</div>\n<!--FIN Registro-->");
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