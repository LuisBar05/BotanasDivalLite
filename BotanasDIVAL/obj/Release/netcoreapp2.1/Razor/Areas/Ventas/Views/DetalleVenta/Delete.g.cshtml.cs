#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5df22f70e5da32b09ac2194b1d68e7f7970fae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Ventas_Views_DetalleVenta_Delete), @"mvc.1.0.view", @"/Areas/Ventas/Views/DetalleVenta/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Ventas/Views/DetalleVenta/Delete.cshtml", typeof(AspNetCore.Areas_Ventas_Views_DetalleVenta_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5df22f70e5da32b09ac2194b1d68e7f7970fae7", @"/Areas/Ventas/Views/DetalleVenta/Delete.cshtml")]
    public class Areas_Ventas_Views_DetalleVenta_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.DetalleVenta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(85, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DetalleVenta</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(259, 44, false);
#line 15 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(347, 40, false);
#line 18 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(431, 49, false);
#line 21 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(524, 45, false);
#line 24 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(569, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(613, 57, false);
#line 27 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CodProductoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(670, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(714, 65, false);
#line 30 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CodProductoNavigation.CodProducto));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(823, 53, false);
#line 33 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdVentaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(876, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(920, 56, false);
#line 36 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdVentaNavigation.Status));

#line default
#line hidden
            EndContext();
            BeginContext(976, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1020, 52, false);
#line 39 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1116, 66, false);
#line 42 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetalleVenta\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 263, true);
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""IdDetVenta"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-default"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.DetalleVenta> Html { get; private set; }
    }
}
#pragma warning restore 1591