#pragma checksum "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60205d893f816dea39d8c563646f0295d52aca47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GreetingCards_Delete), @"mvc.1.0.view", @"/Views/GreetingCards/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GreetingCards/Delete.cshtml", typeof(AspNetCore.Views_GreetingCards_Delete))]
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
#line 1 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards;

#line default
#line hidden
#line 2 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards.Models;

#line default
#line hidden
#line 1 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60205d893f816dea39d8c563646f0295d52aca47", @"/Views/GreetingCards/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_GreetingCards_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AphasiaGreetingCards.Models.GreetingCard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    if (User.Identity.Name == Model.sendertUserEmail)
    {
        ViewData["Title"] = "Delete";


#line default
#line hidden
            BeginContext(319, 303, true);
            WriteLiteral(@"        <div class=""Page"">
            <div class=""display-4 text-center"">Are you sure you want to delete this?</div>
            <hr />
            <div class=""col-md-4 offset-md-4"">
                <dl class=""dl-horizontal col-md-4 offset-md-4"">
                    <dt>
                        ");
            EndContext();
            BeginContext(623, 41, false);
#line 20 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(664, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(744, 37, false);
#line 23 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(781, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(861, 54, false);
#line 26 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.senderUserFullName));

#line default
#line hidden
            EndContext();
            BeginContext(915, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(995, 50, false);
#line 29 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.senderUserFullName));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 167, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        Recipient\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1213, 53, false);
#line 35 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.recipientUserFullName));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1346, 48, false);
#line 38 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.fullSentence));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1474, 44, false);
#line 41 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.fullSentence));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1598, 41, false);
#line 44 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.image));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1719, 37, false);
#line 47 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.image));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1836, 55, false);
#line 50 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.publishedToFacebook));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1971, 51, false);
#line 53 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.publishedToFacebook));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 70, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n                ");
            EndContext();
            BeginContext(2092, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60205d893f816dea39d8c563646f0295d52aca4711946", async() => {
                BeginContext(2138, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2160, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "60205d893f816dea39d8c563646f0295d52aca4712351", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
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
                BeginContext(2196, 106, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" />\r\n                    ");
                EndContext();
                BeginContext(2302, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60205d893f816dea39d8c563646f0295d52aca4714314", async() => {
                    BeginContext(2348, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2364, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2389, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 64 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2451, 251, true);
            WriteLiteral("        <div class=\"display-4 text-center\">\r\n            You do not have permission to delete this card - you are not its creator. <br />\r\n            <a href=\"/GreetingCards\" class=\"btn btn-primary\"> Back to Greeting Cards List </a>\r\n        </div>\r\n");
            EndContext();
#line 71 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(2721, 210, true);
            WriteLiteral("    <div class=\"display-4 text-center\">\r\n        You must be logged in to delete a greeting card. <br />\r\n        <a href=\"/GreetingCards\" class=\"btn btn-primary\"> Back to Greeting Cards List </a>\r\n    </div>\r\n");
            EndContext();
#line 79 "C:\Users\Inbar\Source\Repos\AphasiaGreetingCards2\AphasiaGreetingCards_current\Views\GreetingCards\Delete.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AphasiaGreetingCards.Models.GreetingCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
