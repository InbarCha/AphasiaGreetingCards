#pragma checksum "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee9342144d218cc4ac9f0820c1a01282cb27e10"
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
#line 1 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards;

#line default
#line hidden
#line 2 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee9342144d218cc4ac9f0820c1a01282cb27e10", @"/Views/SentimentSentences/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_SentimentSentences_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AphasiaGreetingCards.Models.SentimentSentence>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(99, 229, true);
            WriteLiteral("\r\n<div class=\"Page\">\r\n    <div>\r\n        <div class=\"display-4 text-center\">Sentiment Sentence Details</div>\r\n        <hr />\r\n        <dl class=\"col-md-4 offset-md-4 text-center dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(329, 41, false);
#line 13 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(370, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(426, 37, false);
#line 16 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(463, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(519, 42, false);
#line 19 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(561, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(617, 38, false);
#line 22 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayFor(model => model.prefix));

#line default
#line hidden
            EndContext();
            BeginContext(655, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(711, 58, false);
#line 25 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.recipientUserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(769, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(825, 54, false);
#line 28 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayFor(model => model.recipientUserFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(879, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(935, 42, false);
#line 31 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(977, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1033, 38, false);
#line 34 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayFor(model => model.suffix));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1127, 46, false);
#line 37 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1229, 42, false);
#line 40 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
           Write(Html.DisplayFor(model => model.complexity));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 122, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"col-md-4 offset-md-4 dl-horizontal text-center\">\r\n        ");
            EndContext();
            BeginContext(1393, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee9342144d218cc4ac9f0820c1a01282cb27e109421", async() => {
                BeginContext(1463, 4, true);
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
#line 45 "C:\Users\Yuvalsp\Source\Repos\NewRepo2\AphasiaGreetingCards_current\Views\SentimentSentences\Details.cshtml"
                               WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1471, 11, true);
            WriteLiteral(" \r\n        ");
            EndContext();
            BeginContext(1482, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dee9342144d218cc4ac9f0820c1a01282cb27e1011861", async() => {
                BeginContext(1528, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1544, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
