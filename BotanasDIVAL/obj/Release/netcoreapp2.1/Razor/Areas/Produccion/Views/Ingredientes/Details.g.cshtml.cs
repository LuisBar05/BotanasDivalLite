#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5196716b5e1692bc181320ed04db3561e5939798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Produccion_Views_Ingredientes_Details), @"mvc.1.0.view", @"/Areas/Produccion/Views/Ingredientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Produccion/Views/Ingredientes/Details.cshtml", typeof(AspNetCore.Areas_Produccion_Views_Ingredientes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5196716b5e1692bc181320ed04db3561e5939798", @"/Areas/Produccion/Views/Ingredientes/Details.cshtml")]
    public class Areas_Produccion_Views_Ingredientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.Ingredientes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Ingredientes</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 53, false);
#line 14 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreIngrediente));

#line default
#line hidden
            EndContext();
            BeginContext(266, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(310, 49, false);
#line 17 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreIngrediente));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(403, 44, false);
#line 20 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 40, false);
#line 23 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(531, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(575, 48, false);
#line 26 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrecioCompra));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(667, 44, false);
#line 29 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrecioCompra));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 49, false);
#line 32 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(848, 45, false);
#line 35 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(893, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(937, 54, false);
#line 38 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdUniMedNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1035, 68, false);
#line 41 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdUniMedNavigation.DescripcionUniMed));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1147, 52, false);
#line 44 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1243, 66, false);
#line 47 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1376, "\"", 1411, 1);
#line 52 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Areas\Produccion\Views\Ingredientes\Details.cshtml"
WriteAttributeValue("", 1391, Model.IdIngrediente, 1391, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1412, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.Ingredientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
