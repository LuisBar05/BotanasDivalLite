#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "226714c839ba4560a3bec548d979343bc9f6d838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Compras_Views_Compras_Index), @"mvc.1.0.view", @"/Areas/Compras/Views/Compras/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Compras/Views/Compras/Index.cshtml", typeof(AspNetCore.Areas_Compras_Views_Compras_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226714c839ba4560a3bec548d979343bc9f6d838", @"/Areas/Compras/Views/Compras/Index.cshtml")]
    public class Areas_Compras_Views_Compras_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BotanasDIVAL.Models.Compras>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 47, false);
#line 16 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalCompra));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 47, false);
#line 19 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaCompra));

#line default
#line hidden
            EndContext();
            BeginContext(401, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(457, 47, false);
#line 22 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LugarCompra));

#line default
#line hidden
            EndContext();
            BeginContext(504, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(560, 49, false);
#line 25 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(665, 52, false);
#line 28 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(717, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(835, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(884, 46, false);
#line 37 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalCompra));

#line default
#line hidden
            EndContext();
            BeginContext(930, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(986, 46, false);
#line 40 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaCompra));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1088, 46, false);
#line 43 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LugarCompra));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1190, 48, false);
#line 46 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1294, 69, false);
#line 49 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1438, "\"", 1467, 1);
#line 52 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
WriteAttributeValue("", 1453, item.IdCompra, 1453, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1468, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1520, "\"", 1549, 1);
#line 53 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
WriteAttributeValue("", 1535, item.IdCompra, 1535, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1550, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1604, "\"", 1633, 1);
#line 54 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
WriteAttributeValue("", 1619, item.IdCompra, 1619, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1634, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Compras\Views\Compras\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1684, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BotanasDIVAL.Models.Compras>> Html { get; private set; }
    }
}
#pragma warning restore 1591