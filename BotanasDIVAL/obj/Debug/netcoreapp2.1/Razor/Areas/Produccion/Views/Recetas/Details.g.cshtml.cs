#pragma checksum "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd03c059dbef13c5198d073b50cabced9f43ec17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Produccion_Views_Recetas_Details), @"mvc.1.0.view", @"/Areas/Produccion/Views/Recetas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Produccion/Views/Recetas/Details.cshtml", typeof(AspNetCore.Areas_Produccion_Views_Recetas_Details))]
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
#line 1 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\_ViewImports.cshtml"
using BotanasDIVAL;

#line default
#line hidden
#line 2 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\_ViewImports.cshtml"
using BotanasDIVAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd03c059dbef13c5198d073b50cabced9f43ec17", @"/Areas/Produccion/Views/Recetas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Produccion_Views_Recetas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Recetas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-outline pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "organizacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ListasIngredientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-isQuery", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
    
    ViewData["Title"] = "Recetas";
    ViewData["Message"] = "Una vista un poco más aislada, para observar con detalle únicamente la información de este registro.";

#line default
#line hidden
            BeginContext(214, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">");
            EndContext();
            BeginContext(323, 17, false);
#line 11 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(340, 337, true);
            WriteLiteral(@"/Vista individual</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-info alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(678, 19, false);
#line 20 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(697, 230, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body success\">\r\n                ");
            EndContext();
            BeginContext(927, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a84079fc7494e33ab8b21cc0054a77b", async() => {
                BeginContext(985, 59, true);
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
            BeginContext(1048, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1066, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0fb1ddd52e64d689a512d2ee2193ba1", async() => {
                BeginContext(1251, 85, true);
                WriteLiteral("Ir a la Lista de Ingredientes de esta Receta&nbsp;<i class=\" fas fa-arrow-right\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-isQuery", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["isQuery"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                                                                                                                                                                            WriteLiteral(Model.IdReceta);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1340, 280, true);
            WriteLiteral(@"
                <hr />
                <p>Datos de este registro:</p>
                <dl class=""dl-horizontal"">
                    <dt class=""text-success"">
                        Descripción:
                    </dt>
                    <dd>
                        ");
            EndContext();
            BeginContext(1621, 43, false);
#line 39 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 193, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        Categoría:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1858, 69, false);
#line 45 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdCategoriaNavigation.NombreCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 189, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        Merma:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2117, 37, false);
#line 51 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Merma));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 200, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        Unidad de Medida:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2355, 68, false);
#line 57 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdUniMedNavigation.DescripcionUniMed));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 198, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        Costo por Kilo:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2622, 41, false);
#line 63 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.CostoKilo));

#line default
#line hidden
            EndContext();
            BeginContext(2663, 191, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        Estatus:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2855, 66, false);
#line 69 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 104, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt class=\"text-success\">\r\n                        ");
            EndContext();
            BeginContext(3026, 49, false);
#line 72 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(3075, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(3155, 45, false);
#line 75 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 94, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                </dl>\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(3294, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2381ecfbc2fe451496205555faf671e5", async() => {
                BeginContext(3388, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Recetas\Details.cshtml"
                                                                                 WriteLiteral(Model.IdReceta);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3398, 98, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Recetas> Html { get; private set; }
    }
}
#pragma warning restore 1591
