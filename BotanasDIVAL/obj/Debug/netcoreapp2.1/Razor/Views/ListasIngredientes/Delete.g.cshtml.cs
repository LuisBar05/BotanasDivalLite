#pragma checksum "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e046c20b1000dcebbca40c4236ce7ae55e6ed925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListasIngredientes_Delete), @"mvc.1.0.view", @"/Views/ListasIngredientes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListasIngredientes/Delete.cshtml", typeof(AspNetCore.Views_ListasIngredientes_Delete))]
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
#line 1 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\_ViewImports.cshtml"
using BotanasDIVAL;

#line default
#line hidden
#line 2 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\_ViewImports.cshtml"
using BotanasDIVAL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e046c20b1000dcebbca40c4236ce7ae55e6ed925", @"/Views/ListasIngredientes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a979c416624c653779cb1b57fe2b4d48e53c0113", @"/Views/_ViewImports.cshtml")]
    public class Views_ListasIngredientes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BotanasDIVAL.Models.ListasIngredientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 179, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ListasIngredientes</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(271, 44, false);
#line 15 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(315, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(359, 40, false);
#line 18 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(399, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(443, 49, false);
#line 21 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(536, 45, false);
#line 24 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(625, 59, false);
#line 27 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdIngredienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(728, 73, false);
#line 30 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdIngredienteNavigation.NombreIngrediente));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(845, 54, false);
#line 33 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdRecetaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(943, 62, false);
#line 36 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdRecetaNavigation.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1049, 52, false);
#line 39 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1145, 66, false);
#line 42 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StatusNavigation.DescripcionStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1249, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66065be8ef6046109ff22cb6e13ebec2", async() => {
                BeginContext(1275, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1285, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a7f09157729415db58f8b8e1a67cef1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "C:\Users\becho\Documents\BotanasDivalLite\BotanasDIVAL\Views\ListasIngredientes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdListasIngred);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1333, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1417, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a47c78bcdcd4410ae69d8b0ac6bf457", async() => {
                    BeginContext(1439, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(1455, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1468, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BotanasDIVAL.Models.ListasIngredientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
