#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a4b1c78c887599f402bba2c914a19d5edacc1eda20088b50bbcce0d77168d353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
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
#line 1 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a4b1c78c887599f402bba2c914a19d5edacc1eda20088b50bbcce0d77168d353", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"03cf7df703d3181109d1569d1c9df8a6f7f8e7eb569a88cd5b819b8826383314", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppRole>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b1c78c887599f402bba2c914a19d5edacc1eda20088b50bbcce0d77168d3533898", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Rolleme sehifesi</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                                <i class=""fa fa-wrench""></i>
                            </a>
                            <ul class=""dropdown-menu dropdown-user"">
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config option 1</a>
                                </li>
                                <li>
                                    <a href=""#"" class=""dropdown-item"">Config option 2</a>
   ");
                WriteLiteral(@"                             </li>
                            </ul>
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">

                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th>Ad</th>
                                    <th>Başlıq</th>
                                    <th>Sil</th>
                                    <th>Guncelle</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 49 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 52 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td> <a");
                BeginWriteAttribute("href", " href=\"", 2274, "\"", 2317, 2);
                WriteAttributeValue("", 2281, "/Admin/AdminRole/DeleteRole/", 2281, 28, true);
#nullable restore
#line 54 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 2309, item.Id, 2309, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                        <td> <a");
                BeginWriteAttribute("href", " href=\"", 2411, "\"", 2454, 2);
                WriteAttributeValue("", 2418, "/Admin/AdminRole/UpdateRole/", 2418, 28, true);
#nullable restore
#line 55 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 2446, item.Id, 2446, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-primary\">Guncelle</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 57 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminRole\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                        <a href=""/Admin/AdminRole/AddRole/"" class=""btn btnbadge-outline-primary"">Yeni Role ekle</a>
                        <a href=""/Admin/AdminRole/UserRoleList/"" class=""btn btnbadge-outline-info"">Rol Listesi</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591