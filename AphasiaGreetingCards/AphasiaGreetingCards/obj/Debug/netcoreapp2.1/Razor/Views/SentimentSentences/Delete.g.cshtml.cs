#pragma checksum "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a38bddae149a0df5c9aef5efc8bedfa1a2d979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SentimentSentences_Delete), @"mvc.1.0.view", @"/Views/SentimentSentences/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SentimentSentences/Delete.cshtml", typeof(AspNetCore.Views_SentimentSentences_Delete))]
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
#line 1 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\_ViewImports.cshtml"
using AphasiaGreetingCards;

#line default
#line hidden
#line 2 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\_ViewImports.cshtml"
using AphasiaGreetingCards.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a38bddae149a0df5c9aef5efc8bedfa1a2d979", @"/Views/SentimentSentences/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_SentimentSentences_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AphasiaGreetingCards.Models.SentimentSentence>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(98, 178, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SentimentSentence</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(277, 41, false);
#line 15 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(362, 37, false);
#line 18 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(399, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(443, 42, false);
#line 21 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(529, 38, false);
#line 24 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(567, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(611, 51, false);
#line 27 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.recipientUserID));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(706, 47, false);
#line 30 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayFor(model => model.recipientUserID));

#line default
#line hidden
            EndContext();
            BeginContext(753, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(797, 42, false);
#line 33 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(883, 38, false);
#line 36 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(965, 46, false);
#line 39 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1055, 42, false);
#line 42 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
       Write(Html.DisplayFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1135, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27921df854f410082698e4e05b2ce3a", async() => {
                BeginContext(1161, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1171, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c02e7908fd074ac3b8947338b9ee4d5f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1207, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1291, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "713a8402226c40219c0fcab8a3f97371", async() => {
                    BeginContext(1313, 12, true);
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
                BeginContext(1329, 6, true);
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
            BeginContext(1342, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AphasiaGreetingCards.Models.SentimentSentence> Html { get; private set; }
    }
}
#pragma warning restore 1591
