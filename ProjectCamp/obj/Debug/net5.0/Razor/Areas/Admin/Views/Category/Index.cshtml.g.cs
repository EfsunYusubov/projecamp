#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "906c5cb2edbb2c5957fd88adea75faa1e95bdf33617b19f35146a9ce743cd95c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\_ViewImports.cshtml"
using ProjectCamp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\_ViewImports.cshtml"
using ProjectCamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"906c5cb2edbb2c5957fd88adea75faa1e95bdf33617b19f35146a9ce743cd95c", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"03cf7df703d3181109d1569d1c9df8a6f7f8e7eb569a88cd5b819b8826383314", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kateqoriya listi</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n<tr>\r\n    <th>#</th>\r\n    <th>Kateqoriya adı</th>\r\n    <th>Deaktiv et</th>\r\n    <th>Aktiv et</th>\r\n    <th>Düzəlt</th>\r\n</tr>\r\n");
#nullable restore
#line 21 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 24 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
       Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 525, "\"", 580, 3);
            WriteAttributeValue("", 532, "/Admin/Category/CategoryDelete/", 532, 31, true);
#nullable restore
#line 26 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 563, item.CategoryID, 563, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 579, "/", 579, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""DeleteBtn"" 
            onclick= ""return confirm('Silmek istediyinize eminsiniz ?');""  class=""btn btn-info"">Deaktiv et</a></td>
        <td><a href=""#"" class=""btn btn-warning"">Aktiv et</a></td>
        <td><a href=""#"" class=""btn btn-success"">Düzəlt</a></td>
    </tr>
");
#nullable restore
#line 31 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> \r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-primary\">Yeni kateqoriya</a>\r\n<br /><br />\r\n\r\n");
#nullable restore
#line 36 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591