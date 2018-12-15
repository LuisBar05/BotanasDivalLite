#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7e934b75b9f4875fc9be9c13177a513c0819a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Produccion_Views_Productos_Index), @"mvc.1.0.view", @"/Areas/Produccion/Views/Productos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Produccion/Views/Productos/Index.cshtml", typeof(AspNetCore.Areas_Produccion_Views_Productos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7e934b75b9f4875fc9be9c13177a513c0819a7", @"/Areas/Produccion/Views/Productos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Produccion_Views_Productos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BotanasDIVAL.Models.Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-outline purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-default purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
  
    ViewData["Title"] = "Productos";
    ViewData["Message"] = "En esta tabla se encuentra la información acerca de cada uno de los productos dentro del catálogo de productos ofrecido por el negocio. Puedes ordenar por columna, buscar, crear un registro nuevo, y también ver los detalles, editar o eliminar un registro existente.";

#line default
#line hidden
            BeginContext(394, 130, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Page Header -->\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">Registros en la tabla ");
            EndContext();
            BeginContext(525, 17, false);
#line 11 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                                 Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(542, 323, true);
            WriteLiteral(@"</h1>
    </div>
    <!--End Page Header -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""alert alert-warning alert-dismissable"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
            <i class=""fa fa-info""></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(866, 19, false);
#line 20 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                             Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(885, 222, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <!-- Advanced Tables -->\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                ");
            EndContext();
            BeginContext(1107, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40ddc71b7e284391a505ed50fc93dbd6", async() => {
                BeginContext(1173, 79, true);
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>&nbsp;Agregar un nuevo registro de inventario");
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
            BeginContext(1256, 828, true);
            WriteLiteral(@"
            </div>
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <table class=""table table-striped table-bordered table-hover text-center"" id=""productosTable"">
                        <thead>
                            <tr class=""purple"">
                                <th>Código de<br>Producto</th>
                                <th>Descripción</th>
                                <th>Precio de<br>Venta</th>
                                <th>Costo<br>Unitario</th>
                                <th>Observaciones</th>
                                <th><i class=""fas fa-bookmark""></i></th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 47 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2173, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2294, 46, false);
#line 51 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CodProducto));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2468, 46, false);
#line 54 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2642, 41, false);
#line 57 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(2683, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2811, 44, false);
#line 60 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CostoUnit));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2983, 48, false);
#line 63 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(3031, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3159, 69, false);
#line 66 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(3228, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3355, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89f2a07f1690450aa0f74e69f731cdc6", async() => {
                BeginContext(3449, 37, true);
                WriteLiteral("<i class=\"fas fa-list-alt fa-fw\"></i>");
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
#line 69 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                                                                                        WriteLiteral(item.IdProducto);

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
            BeginContext(3490, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(3534, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd96584948314ccd825c93eb88128575", async() => {
                BeginContext(3625, 33, true);
                WriteLiteral("<i class=\"fas fa-edit fa-fw\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                                                                                     WriteLiteral(item.IdProducto);

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
            BeginContext(3662, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(3706, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "120bdebbb61445fa86f0c54f48de9c00", async() => {
                BeginContext(3799, 34, true);
                WriteLiteral("<i class=\"fas fa-trash fa-fw\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                                                                                                       WriteLiteral(item.IdProducto);

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
            BeginContext(3837, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Productos\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3952, 181, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <!--End Advanced Tables -->\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BotanasDIVAL.Models.Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
