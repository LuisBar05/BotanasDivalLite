#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65390f69f8a6285554c1580039f9d37936275731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65390f69f8a6285554c1580039f9d37936275731", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/UVLogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo UV"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Acerca De";

#line default
#line hidden
            BeginContext(45, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">");
            EndContext();
            BeginContext(154, 17, false);
#line 8 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Home\About.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(171, 341, true);
            WriteLiteral(@" BotanasDIVAL Lite</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-warning alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(513, 19, false);
#line 17 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\Home\About.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(532, 1524, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""well well-lg yellow"">
            <h2>Un poco más sobre este proyecto</h2>
            <p>El desarrollo de este sistema ha sido el resultado del seguimiento de tres experiencias educativas sumamente importantes para el desarrollo de competencias que busca formar el programa de estudios del que son participantes los autores.</p>
            <br>
            <h3 class=""text-right text-primary""><b>Ingeniería de Software Avanzada</b></h3><br>
            <h3 class=""text-right text-success""><b>Programación de Sistemas Basados en Web</b></h3><br>
            <h3 class=""text-right text-info""><b>Tecnologías y Aplicaciones Móviles</b></h3><br><br>
            <br>
            <p>Con este se pretende facilitar el diario operar del negocio de</p> 
            <h4 class=""text-center text-warning"">Garapiñados, Botanas y Frituras ""<b>DIVAL</b>""</h4>
            <p>e incrementar su productividad al automatiza");
            WriteLiteral(@"r las tareas repetitivas de intercambio de información mediante la actualización constante de los datos almacenados, además de ponerlos a su disposición para sus posteriores consultas.</p>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""well well-lg green"">
            <h2 class=""text-right""><b class=""text-success"">Facultad de Ingeniería<br>Eléctrica y Electrónica</b></h2><br>
            <div id=""UVLogo"" class=""text-center"">
                <br>
                ");
            EndContext();
            BeginContext(2056, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "939cc47e36444cf0b5c51fe51a151e41", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2101, 2771, true);
            WriteLiteral(@"
            </div><br>
            <h4>Programa Educativo de <b>Ingeniería Informática</b><br></h4>
            <h4>Región <b>Veracruz</b> / <b>Boca del Río</b> - FIEE</h4>
            <br><h5 class=""text-right text-primary"">Última Actualización: <b>1/Diciembre/2018</b></h5>
            <br><br><br>
            <p class=""text-center"">Agradecemos ampliamente a los propietarios de este establecimiento por darnos la oportunidad de realizar el presente proyecto, para beneficio de nuestro programa de estudios, como para su administración y desempeño laboral.</p>
        </div>
    </div>

</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-info"">
            <p class=""text-center"">Como responsables de este proyecto, quedamos a su entera disposición:</p>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""panel panel-default ice"">
            <div class=""panel-body"">
                <h3><i class=""fa fa-user""></i>&nbsp;&nbsp;<b>Balbina Rena");
            WriteLiteral(@"ta Rodríguez Leyton</b></h3>
                <hr>
                <a class=""btn btn-block btn-outline btn-info"" href=""https://www.facebook.com/balbyrenyrl"" target=""_blank"">Balbina Renata R. Leyton en Facebook</a><br>
                <a class=""btn btn-block btn-outline btn-info"" href=""mailto:Renata21-1997@live.com.mx"" target=""_blank"">Renata21-1997@live.com.mx</a><br>
                <a class=""btn btn-block btn-outline btn-info"" href=""mailto:zS15001353@estudiantes.uv.mx"" target=""_blank"">zS15001353@estudiantes.uv.mx</a>
            </div>
            <div class=""panel-footer text-right"">
                <span class=""panel-eyecandy-title""><i class=""fa fa-fw fa-code""></i>&nbsp;&nbsp;Diseñadora/Programadora</span>
            </div>
        </div>
    </div>
    <div class=""col-lg-6"">
        <div class=""panel panel-default blue"">
            <div class=""panel-body"">
                <h3><i class=""fa fa-user""></i>&nbsp;&nbsp;<b>Luis Adolfo Bárcenas Barradas</b></h3>
                <hr>
             ");
            WriteLiteral(@"   <a class=""btn btn-block btn-outline btn-primary"" href=""https://www.facebook.com/luis.guerrerobarradas"" target=""_blank"">Luis Guerrero Barradas en Facebook</a><br>
                <a class=""btn btn-block btn-outline btn-primary"" href=""mailto:becho_0528@hotmail.com"" target=""_blank"">becho_0528@hotmail.com</a><br>
                <a class=""btn btn-block btn-outline btn-primary"" href=""mailto:zS15001373@estudiantes.uv.mx"" target=""_blank"">zS15001373@estudiantes.uv.mx</a>
            </div>
            <div class=""panel-footer text-right"">
                <span class=""panel-eyecandy-title""><i class=""fa fa-fw fa-code""></i>&nbsp;&nbsp;Programador/Tester</span>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
