#pragma checksum "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63212a42277e23ef7a61e169cc81f12a54264cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards;

#line default
#line hidden
#line 2 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63212a42277e23ef7a61e169cc81f12a54264cfc", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AphasiaGreetingCards.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 329, true);
            WriteLiteral(@"
<div class=""Page"">
    <div class=""card shadow-lg"">
        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th class=""width-md"">
                        Email
                    </th>
                    <th class=""width-md"">
                        ");
            EndContext();
            BeginContext(427, 45, false);
#line 16 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(472, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"width-md\">\r\n                        ");
            EndContext();
            BeginContext(569, 44, false);
#line 19 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(613, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"width-md\">\r\n                        ");
            EndContext();
            BeginContext(710, 39, false);
#line 22 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(749, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"width-md\">\r\n                        ");
            EndContext();
            BeginContext(846, 44, false);
#line 25 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(890, 96, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"width-md\">\r\n                        ");
            EndContext();
            BeginContext(987, 40, false);
#line 28 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 135, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th> Actions </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1227, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1312, 40, false);
#line 38 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1444, 44, false);
#line 41 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1580, 43, false);
#line 44 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1715, 38, false);
#line 47 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1845, 43, false);
#line 50 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 116, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"ui-helper-center\">\r\n                            ");
            EndContext();
            BeginContext(2005, 39, false);
#line 53 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(2044, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2135, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63212a42277e23ef7a61e169cc81f12a54264cfc10273", async() => {
                BeginContext(2183, 7, true);
                WriteLiteral("Details");
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
#line 56 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                                                      WriteLiteral(item.Id);

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
            BeginContext(2194, 61, true);
            WriteLiteral(" \r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "C:\Users\psivi\Source\Repos\InbarCha\AphasiaGreetingCards_1\AphasiaGreetingCards_current\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2274, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AphasiaGreetingCards.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
