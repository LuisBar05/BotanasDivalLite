#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef14333f589b53e306aef16567a6eb612e10e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Produccion_Views_Productos_Details), @"mvc.1.0.view", @"/Areas/Produccion/Views/Productos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Produccion/Views/Productos/Details.cshtml", typeof(AspNetCore.Areas_Produccion_Views_Productos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef14333f589b53e306aef16567a6eb612e10e7e", @"/Areas/Produccion/Views/Productos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Produccion_Views_Productos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Productos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-lg pull-right purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
    
    ViewData["Title"] = "Productos";
    ViewData["Message"] = "Una vista un poco más aislada, para observar con detalle únicamente la información de este registro.";

#line default
#line hidden
            BeginContext(218, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">");
            EndContext();
            BeginContext(327, 17, false);
#line 11 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(344, 340, true);
            WriteLiteral(@"/Vista individual</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-warning alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(685, 19, false);
#line 20 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(704, 222, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(926, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f962987ad05460992c5c0704f114cba", async() => {
                BeginContext(984, 59, true);
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
            BeginContext(1047, 266, true);
            WriteLiteral(@"
                <hr />
                <p>Datos de este registro:</p>
                <dl class=""dl-horizontal"">
                    <dt>
                        Código de Producto:
                    </dt>
                    <dd>
                        ");
            EndContext();
            BeginContext(1314, 43, false);
#line 38 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CodProducto));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 174, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Descripción:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1532, 43, false);
#line 44 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 172, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Categoría:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1748, 88, false);
#line 50 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdRecetaNavigation.IdCategoriaNavigation.NombreCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 169, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Receta:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2006, 62, false);
#line 56 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdRecetaNavigation.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 182, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Presentación: (.grs)\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2251, 65, false);
#line 62 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdPresentacionNavigation.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(2323, 93, false);
#line 62 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                                                                                           Write(Html.DisplayFor(model => model.IdPresentacionNavigation.IdUniMedNavigation.DescripcionUniMed));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 178, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Precio de Venta:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2595, 38, false);
#line 68 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(2633, 177, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Costo Unitario:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2811, 41, false);
#line 74 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CostoUnit));

#line default
#line hidden
            EndContext();
            BeginContext(2852, 83, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2936, 49, false);
#line 77 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(2985, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3065, 45, false);
#line 80 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(3110, 170, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Estatus:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3281, 66, false);
#line 86 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                   Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 94, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                </dl>\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(3441, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331669887b004df89e0adcbc3d3044da", async() => {
                BeginContext(3586, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                                                                                        WriteLiteral(Model.IdProducto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Details.cshtml"
                                                                                                                                 WriteLiteral(Model.CodProducto);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codProduct"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codProduct", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codProduct"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3596, 98, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Productos> Html { get; private set; }
    }
}
#pragma warning restore 1591
