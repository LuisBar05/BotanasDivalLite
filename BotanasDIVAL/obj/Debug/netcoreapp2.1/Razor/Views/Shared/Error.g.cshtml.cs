#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416ea7469ac7219a549afcce854b6e7d11e27e01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\_ViewImports.cshtml"
using BotanasDIVAL;

#line default
#line hidden
#line 2 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\_ViewImports.cshtml"
using BotanasDIVAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416ea7469ac7219a549afcce854b6e7d11e27e01", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(173, 17, false);
#line 9 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(190, 303, true);
            WriteLiteral(@"</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-body"">

                <h3 class=""text-danger"">Ha ocurrido un error mientras se intentaba procesar su solicitud.</h3>

");
            EndContext();
#line 21 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml"
                 if (Model.ShowRequestId)
                {

#line default
#line hidden
            BeginContext(555, 89, true);
            WriteLiteral("                    <p>\r\n                        <strong>ID de solicitud:</strong> <code>");
            EndContext();
            BeginContext(645, 15, false);
#line 24 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml"
                                                           Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(660, 35, true);
            WriteLiteral("</code>\r\n                    </p>\r\n");
            EndContext();
#line 26 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Shared\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(714, 789, true);
            WriteLiteral(@"
                <h3>Modo Desarrollador</h3>
                <p>
                    Cambiando al entorno de <strong>desarrollo</strong> se mostrará información adicional acerca del error que acaba de ocurrir.
                </p>
                <p>
                    <strong>El entorno de desarrollo no debería ser activado en aplicaciones desplegadas</strong>, ya que podria resultar en que las excepciones muestren información sensible a los usuarios no autorizados. Para la depuración local, el entorno de desarrollo puede ser activado asignando a la variable de entorno <strong>ASPNETCORE_ENVIRONMENT</strong> el valor de <strong>Development</strong>, y posteriormente reiniciar la aplicación.
                </p>
            </div>
        </div>
    </div>

</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
