#pragma checksum "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f08373011efadd53e6916e62bd71647ccfa993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Produccion_Views_Almacen_Details), @"mvc.1.0.view", @"/Areas/Produccion/Views/Almacen/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Produccion/Views/Almacen/Details.cshtml", typeof(AspNetCore.Areas_Produccion_Views_Almacen_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f08373011efadd53e6916e62bd71647ccfa993", @"/Areas/Produccion/Views/Almacen/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Produccion_Views_Almacen_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Almacen>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-outline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-lg pull-right red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
    
    ViewData["Title"] = "Almacén";
    ViewData["Message"] = "Una vista un poco más aislada, para observar con detalle únicamente la información de este registro.";

#line default
#line hidden
            BeginContext(214, 108, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">");
            EndContext();
            BeginContext(323, 17, false);
#line 11 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(340, 340, true);
            WriteLiteral(@"/Vista individual</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-success alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(681, 19, false);
#line 20 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(700, 222, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n    <div class=\"col-lg-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(922, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3010cd49e417432697cf5bc595990033", async() => {
                BeginContext(980, 59, true);
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
            BeginContext(1043, 258, true);
            WriteLiteral(@"
                <hr />
                <p>Datos de este registro:</p>
               <dl class=""dl-horizontal"">
                    <dt>
                        Ingrediente:
                    </dt>
                    <dd>
                        ");
            EndContext();
            BeginContext(1302, 73, false);
#line 38 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayFor(model => model.IdIngredienteNavigation.NombreIngrediente));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 171, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Cantidad:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1547, 40, false);
#line 44 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 181, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Fecha de Caducidad:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1769, 46, false);
#line 50 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayFor(model => model.FechaCaducidad));

#line default
#line hidden
            EndContext();
            BeginContext(1815, 83, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1899, 49, false);
#line 53 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2028, 45, false);
#line 56 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 170, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                    <dt>\r\n                        Estatus:\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2244, 66, false);
#line 62 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                   Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 94, true);
            WriteLiteral("<br>\r\n                    </dd>\r\n                </dl>\r\n                <hr>\r\n                ");
            EndContext();
            BeginContext(2404, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109df72eedcd444680bdaf00be961a03", async() => {
                BeginContext(2503, 6, true);
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
#line 66 "C:\Users\BalbyReny\Documents\GitHub Local\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Almacen\Details.cshtml"
                                                                                     WriteLiteral(Model.IdAlmacen);

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
            BeginContext(2513, 100, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-3\">\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Almacen> Html { get; private set; }
    }
}
#pragma warning restore 1591
