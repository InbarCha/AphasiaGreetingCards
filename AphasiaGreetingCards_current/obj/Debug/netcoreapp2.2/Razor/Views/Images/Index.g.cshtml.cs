#pragma checksum "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786ecb91c5635b2b90699170faff07025f5a7fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Images/Index.cshtml", typeof(AspNetCore.Views_Images_Index))]
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
#line 1 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards;

#line default
#line hidden
#line 2 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\_ViewImports.cshtml"
using AphasiaGreetingCards.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786ecb91c5635b2b90699170faff07025f5a7fe4", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb0b20ffb9dcda31f21808a720e7f13448f5db2", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AphasiaGreetingCards.Models.Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 276, true);
            WriteLiteral(@"<div class=""Page"">
    <div class=""display-4 text-center""> Images </div>
    <hr />
    <div class=""card shadow-lg"">
        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(375, 45, false);
#line 14 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.imageName));

#line default
#line hidden
            EndContext();
            BeginContext(420, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(500, 41, false);
#line 17 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.theme));

#line default
#line hidden
            EndContext();
            BeginContext(541, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(621, 46, false);
#line 20 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.resolution));

#line default
#line hidden
            EndContext();
            BeginContext(667, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(747, 47, false);
#line 23 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.digitalSize));

#line default
#line hidden
            EndContext();
            BeginContext(794, 179, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Image\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1038, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1123, 44, false);
#line 35 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.imageName));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1259, 40, false);
#line 38 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.theme));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1391, 45, false);
#line 41 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.resolution));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1528, 46, false);
#line 44 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.digitalSize));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 97, true);
            WriteLiteral("KB\r\n                        </td>\r\n                        <td>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1671, "\"", 1722, 1);
#line 47 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
WriteAttributeValue("", 1677, Html.DisplayFor(modelItem => item.imagePath), 1677, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1723, 73, true);
            WriteLiteral(" width=\"300\">\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Inbar\Desktop\WebAppCourse\AphasiaGreetingCards\AphasiaGreetingCards_current\Views\Images\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1815, 58, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AphasiaGreetingCards.Models.Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591
