#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetallePedido\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7390e3d970f23328f4f2391079f970872d178fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Ventas_Views_DetallePedido_Edit), @"mvc.1.0.view", @"/Areas/Ventas/Views/DetallePedido/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Ventas/Views/DetallePedido/Edit.cshtml", typeof(AspNetCore.Areas_Ventas_Views_DetallePedido_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7390e3d970f23328f4f2391079f970872d178fb", @"/Areas/Ventas/Views/DetallePedido/Edit.cshtml")]
    public class Areas_Ventas_Views_DetallePedido_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.DetallePedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetallePedido\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(84, 2037, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>DetallePedido</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""IdDetPedido"" />
            <div class=""form-group"">
                <label asp-for=""IdPedido"" class=""control-label""></label>
                <select asp-for=""IdPedido"" class=""form-control"" asp-items=""ViewBag.IdPedido""></select>
                <span asp-validation-for=""IdPedido"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CodProducto"" class=""control-label""></label>
                <select asp-for=""CodProducto"" class=""form-control"" asp-items=""ViewBag.CodProducto""></select>
                <span asp-validation-for=""CodProducto"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cantidad"" class=""control-label""></lab");
            WriteLiteral(@"el>
                <input asp-for=""Cantidad"" class=""form-control"" />
                <span asp-validation-for=""Cantidad"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <select asp-for=""Status"" class=""form-control"" asp-items=""ViewBag.Status""></select>
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Observaciones"" class=""control-label""></label>
                <input asp-for=""Observaciones"" class=""form-control"" />
                <span asp-validation-for=""Observaciones"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2139, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Ventas\Views\DetallePedido\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.DetallePedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
