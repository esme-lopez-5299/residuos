#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\FENACI\RESIDUOS\RESIDUOS\Views\Home\InicioSesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4591dd63bda4759c7f2067d2178c699010ca69dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InicioSesion), @"mvc.1.0.view", @"/Views/Home/InicioSesion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4591dd63bda4759c7f2067d2178c699010ca69dd", @"/Views/Home/InicioSesion.cshtml")]
    public class Views_Home_InicioSesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\FENACI\RESIDUOS\RESIDUOS\Views\Home\InicioSesion.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""inicio-sesion"">
    <div>
        <a href=""inicio.html"" class=""logo"">
            <img src=""img/logo.jpeg"" />
        </a>
    </div>
    <div class=""datos"">
        <h2>Iniciar sesión</h2>
        <form>
            <!--<label>Correo electrónico:</label><br />-->
            <input type=""text"" placeholder=""Correo electrónico"" /><br /><br />
            <!--<label>Contraseña:</label><br />-->
            <input type=""password"" placeholder=""Contraseña"" /><br />
            <input type=""submit"" class=""boton"" value=""Iniciar Sesión"" />
        </form>
    </div>
    <div class=""ir-registar"">
        <h4>¿No tienes una cuenta?</h4><br />
        <a href=""Registrarse.html"">¡Regístrate!</a>
    </div>
</div>

");
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
