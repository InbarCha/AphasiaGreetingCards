#pragma checksum "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fca3bff4a6043d27ee7398bedd4f1f69567e09c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca3bff4a6043d27ee7398bedd4f1f69567e09c3", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AphasiaGreetingCards.Models.User>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(85, 165, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 45, false);
#line 15 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(340, 41, false);
#line 18 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(425, 44, false);
#line 21 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 40, false);
#line 24 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(553, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(597, 44, false);
#line 27 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(685, 40, false);
#line 30 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(725, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(769, 44, false);
#line 33 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(857, 40, false);
#line 36 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(941, 39, false);
#line 39 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1024, 35, false);
#line 42 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.age));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1103, 48, false);
#line 45 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.birthdayDate));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1195, 44, false);
#line 48 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.birthdayDate));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1283, 40, false);
#line 51 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.city));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1367, 36, false);
#line 54 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.city));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1447, 45, false);
#line 57 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.isManager));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1536, 41, false);
#line 60 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.isManager));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1615, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1593905b763146128ffb55f42022f0ff", async() => {
                BeginContext(1641, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1651, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ae92ff18be94fccb9ab9fa2b0ec4ed8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards\AphasiaGreetingCards\Views\Users\Delete.cshtml"
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
                BeginContext(1687, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1771, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9b590fed9349cd9678046c4f8b7d5c", async() => {
                    BeginContext(1793, 12, true);
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
                BeginContext(1809, 6, true);
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
            BeginContext(1822, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AphasiaGreetingCards.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
