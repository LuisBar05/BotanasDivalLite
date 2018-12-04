#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159cc6f095b1810462c8ab5f3a358fa64a3b2140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Organizacion_Views_ListasIngredientes_Create), @"mvc.1.0.view", @"/Areas/Organizacion/Views/ListasIngredientes/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Organizacion/Views/ListasIngredientes/Create.cshtml", typeof(AspNetCore.Areas_Organizacion_Views_ListasIngredientes_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159cc6f095b1810462c8ab5f3a358fa64a3b2140", @"/Areas/Organizacion/Views/ListasIngredientes/Create.cshtml")]
    public class Areas_Organizacion_Views_ListasIngredientes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.ListasIngredientes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(91, 1754, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>ListasIngredientes</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""IdReceta"" class=""control-label""></label>
                <select asp-for=""IdReceta"" class =""form-control"" asp-items=""ViewBag.IdReceta""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdIngrediente"" class=""control-label""></label>
                <select asp-for=""IdIngrediente"" class =""form-control"" asp-items=""ViewBag.IdIngrediente""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cantidad"" class=""control-label""></label>
                <input asp-for=""Cantidad"" class=""form-control"" />
                <span asp-validation-for=""Cantidad"" class=""text-danger""></span>
            </div>
            <div class=""form-group");
            WriteLiteral(@""">
                <label asp-for=""Status"" class=""control-label""></label>
                <select asp-for=""Status"" class =""form-control"" asp-items=""ViewBag.Status""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Observaciones"" class=""control-label""></label>
                <input asp-for=""Observaciones"" class=""form-control"" />
                <span asp-validation-for=""Observaciones"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
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
                BeginContext(1863, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 49 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Organizacion\Views\ListasIngredientes\Create.cshtml"
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