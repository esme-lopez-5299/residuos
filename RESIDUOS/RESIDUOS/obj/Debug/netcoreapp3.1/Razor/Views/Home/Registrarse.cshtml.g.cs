#pragma checksum "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\FENACI\RESIDUOS\RESIDUOS\Views\Home\Registrarse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "141576b1360351919242dc3acdb61ce599a0738f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registrarse), @"mvc.1.0.view", @"/Views/Home/Registrarse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"141576b1360351919242dc3acdb61ce599a0738f", @"/Views/Home/Registrarse.cshtml")]
    public class Views_Home_Registrarse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\esme_\OneDrive\Documentos\SEPTIMO SEMESTRE\FENACI\RESIDUOS\RESIDUOS\Views\Home\Registrarse.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""registrar"">
    <div class=""datos"">
        <h2>Registrar</h2>
        <form>
            <label>Nombre:</label>
            <input type=""text"" placeholder=""Nombre"" /><br />
            <label>Apellido paterno</label>
            <input type=""text"" placeholder=""Apellido"" /><br />
            <!--<label>Apellido materno</label>-->
            <!--<input type=""text"" placeholder=""Apellido materno"" /><br />-->
            <div>
                <label>Fecha de nacimiento</label><br />
                <input type=""date"" placeholder=""Fecha de nacimiento"" /><br />
            </div>
            <!--<label>Apellido paterno</label>-->
            <!--<input type=""text"" placeholder=""Apellido paterno""/><br />-->
            <!--<label>Escuela de procedencia</label>-->
            <input type=""text"" placeholder=""Escuela de procedencia"" /><br />
            <!--<label>Clave de la escuela</label>-->
            <input type=""text"" placeholder=""Clave de la escuela"" /><br />
            <!--");
            WriteLiteral(@"<label>Teléfono</label>-->
            <input type=""tel"" placeholder=""Teléfono"" /><br />
            <!--<label>Correo electrónico</label>-->
            <input type=""email"" placeholder=""Correo electrónico"" /><br />
            <!--<label>Elije una contraseña</label>-->
            <input type=""password"" placeholder=""Elije una contraseña"" /><br />
            <!--<label>Confirmar contraseña</label>-->
            <input type=""password"" placeholder=""Confirmar contraseña"" /><br />
            <input type=""submit"" value=""Registrar"" class=""boton"" />
        </form>
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
