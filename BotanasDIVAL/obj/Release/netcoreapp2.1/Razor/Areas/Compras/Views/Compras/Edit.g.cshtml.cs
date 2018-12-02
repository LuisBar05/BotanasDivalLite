#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055a425fb230379d0e8f9735b0ed147a1cac0d8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Compras_Views_Compras_Edit), @"mvc.1.0.view", @"/Areas/Compras/Views/Compras/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Compras/Views/Compras/Edit.cshtml", typeof(AspNetCore.Areas_Compras_Views_Compras_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055a425fb230379d0e8f9735b0ed147a1cac0d8b", @"/Areas/Compras/Views/Compras/Edit.cshtml")]
    public class Areas_Compras_Views_Compras_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Compras>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(78, 1969, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Compras</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""IdCompra"" />
            <div class=""form-group"">
                <label asp-for=""TotalCompra"" class=""control-label""></label>
                <input asp-for=""TotalCompra"" class=""form-control"" />
                <span asp-validation-for=""TotalCompra"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FechaCompra"" class=""control-label""></label>
                <input asp-for=""FechaCompra"" class=""form-control"" />
                <span asp-validation-for=""FechaCompra"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LugarCompra"" class=""control-label""></label>
                <input asp-for=""LugarCompra"" class=""form-control"" />");
            WriteLiteral(@"
                <span asp-validation-for=""LugarCompra"" class=""text-danger""></span>
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
                BeginContext(2065, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Compras> Html { get; private set; }
    }
}
#pragma warning restore 1591
