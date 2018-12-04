#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "899e5eb690dcbbd8f3f1f8ff6405f9f4a0bcd958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Organizacion_Views_ListasIngredientes_Edit), @"mvc.1.0.view", @"/Areas/Organizacion/Views/ListasIngredientes/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Organizacion/Views/ListasIngredientes/Edit.cshtml", typeof(AspNetCore.Areas_Organizacion_Views_ListasIngredientes_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899e5eb690dcbbd8f3f1f8ff6405f9f4a0bcd958", @"/Areas/Organizacion/Views/ListasIngredientes/Edit.cshtml")]
    public class Areas_Organizacion_Views_ListasIngredientes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.ListasIngredientes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(89, 2053, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>ListasIngredientes</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""IdListasIngred"" />
            <div class=""form-group"">
                <label asp-for=""IdReceta"" class=""control-label""></label>
                <select asp-for=""IdReceta"" class=""form-control"" asp-items=""ViewBag.IdReceta""></select>
                <span asp-validation-for=""IdReceta"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdIngrediente"" class=""control-label""></label>
                <select asp-for=""IdIngrediente"" class=""form-control"" asp-items=""ViewBag.IdIngrediente""></select>
                <span asp-validation-for=""IdIngrediente"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cantidad"" class=""cont");
            WriteLiteral(@"rol-label""></label>
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
</div");
            WriteLiteral(">\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2160, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.ListasIngredientes> Html { get; private set; }
    }
}
#pragma warning restore 1591