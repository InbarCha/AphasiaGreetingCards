#pragma checksum "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da668691e934a578e7d66dc68b3cce7d985ceaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SentimentSentences_Details), @"mvc.1.0.view", @"/Views/SentimentSentences/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SentimentSentences/Details.cshtml", typeof(AspNetCore.Views_SentimentSentences_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da668691e934a578e7d66dc68b3cce7d985ceaa", @"/Views/SentimentSentences/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_SentimentSentences_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AphasiaGreetingCards.Models.SentimentSentence>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(99, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SentimentSentence</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 41, false);
#line 14 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(272, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(316, 37, false);
#line 17 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(397, 42, false);
#line 20 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(483, 38, false);
#line 23 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(565, 51, false);
#line 26 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.recipientUserID));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(660, 47, false);
#line 29 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayFor(model => model.recipientUserID));

#line default
#line hidden
            EndContext();
            BeginContext(707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(751, 42, false);
#line 32 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(793, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(837, 38, false);
#line 35 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(875, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(919, 46, false);
#line 38 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1009, 42, false);
#line 41 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
       Write(Html.DisplayFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1098, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b646c930737b41719d404c21a1cb3acb", async() => {
                BeginContext(1144, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\SentimentSentences\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(1152, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1160, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04eef0ad860b473abd858de0b816cdaa", async() => {
                BeginContext(1182, 12, true);
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
            BeginContext(1198, 10, true);
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
