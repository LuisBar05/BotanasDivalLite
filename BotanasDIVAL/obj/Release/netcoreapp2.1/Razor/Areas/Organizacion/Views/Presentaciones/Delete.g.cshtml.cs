#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f68644f51570b1a2acafc9f5730c3d2dd1be261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Organizacion_Views_Presentaciones_Delete), @"mvc.1.0.view", @"/Areas/Organizacion/Views/Presentaciones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Organizacion/Views/Presentaciones/Delete.cshtml", typeof(AspNetCore.Areas_Organizacion_Views_Presentaciones_Delete))]
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
#line 1 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\_ViewImports.cshtml"
using BotanasDIVAL;

#line default
#line hidden
#line 2 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\_ViewImports.cshtml"
using BotanasDIVAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f68644f51570b1a2acafc9f5730c3d2dd1be261", @"/Areas/Organizacion/Views/Presentaciones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Organizacion_Views_Presentaciones_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Presentaciones>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
  
    ViewData["Title"] = "Presentaciones";
    ViewData["Message"] = "¿Estás seguro que quieres eliminar esto? Estos cambios no se pueden deshacer.";

#line default
#line hidden
            BeginContext(203, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">");
            EndContext();
            BeginContext(312, 17, false);
#line 11 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(329, 343, true);
            WriteLiteral(@"/Eliminar un registro</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-danger alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(673, 19, false);
#line 20 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(692, 224, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(916, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44abdcf4a6314ea1ad3917e43cc187b8", async() => {
                BeginContext(974, 59, true);
                WriteLiteral("<i class=\" fas fa-arrow-left\"></i>&nbsp;Regresar a la tabla");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1037, 256, true);
            WriteLiteral(@"
                <hr />
                <p>Datos de este registro:</p>
                <dl class=""dl-horizontal"">
                    <dt>
                        Cantidad:
                    </dt>
                    <dd>
                        ");
            EndContext();
            BeginContext(1294, 40, false);
#line 39 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 179, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Unidad de Medida:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1514, 68, false);
#line 45 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.IdUniMedNavigation.DescripcionUniMed));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 83, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1666, 49, false);
#line 48 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1795, 45, false);
#line 51 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 170, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Estatus:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2011, 66, false);
#line 57 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 72, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                </dl>\r\n                ");
            EndContext();
            BeginContext(2149, 261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3748106ae9849059bb0b2b600527aba", async() => {
                BeginContext(2191, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2213, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "844576ca324540eea975f022e120802b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 61 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPresentacion);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2261, 142, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Borrar\" class=\"btn btn-default btn-lg orange pull-right\" id=\"deleteBtn\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2410, 100, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2528, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 73 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
     if (ViewBag.ErrorMessage != null)
    {

#line default
#line hidden
                BeginContext(2579, 300, true);
                WriteLiteral(@"        <script>
            swal({
                type: 'error',
                title: 'Oops...',
                html: '¡Necesitas eliminar las dependencias antes!' +
                    '<br/> <hr/> <br/> <a href=""/Home/Help"">¿Por qué me pasa esto?</a>'
            })
        </script>
");
                EndContext();
#line 83 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\Presentaciones\Delete.cshtml"
    }

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Presentaciones> Html { get; private set; }
    }
}
#pragma warning restore 1591
