#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86503ca45c856c8322665b738bd69f1b5b7a3687046c8ee00649909fbe4a5b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\_ViewImports.cshtml"
using ProjectCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\_ViewImports.cshtml"
using ProjectCamp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"86503ca45c856c8322665b738bd69f1b5b7a3687046c8ee00649909fbe4a5b93", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"579e279b636d9a1adc7b2c1178252d69a3e6879f89a2aec9d7f4079c431d0632", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son Bloglar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Başlıq </th>
                                <th> Kateqoriya </th>
                                <th> Tarix </th>
                                <th>Ətraflı</th>
                             
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 983, "\"", 1004, 1);
#nullable restore
#line 25 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 989, item.BlogImage, 989, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> \r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 27 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 29 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 32 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                    Write(((DateTime)
                                            item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=", 1660, "", 1696, 2);
            WriteAttributeValue("", 1666, "/Blog/BlogReadAll/", 1666, 18, true);
#nullable restore
#line 36 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1684, item.BlogID, 1684, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-dark\">Ətraflı</a>\r\n                                    </td>\r\n                                    \r\n                                </tr>\r\n");
#nullable restore
#line 40 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591