#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\CommentList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5a4adcd72f503fdbbb825d8aaf9024e667b41f20b71292a03257cc1a58b3552a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5a4adcd72f503fdbbb825d8aaf9024e667b41f20b71292a03257cc1a58b3552a", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"579e279b636d9a1adc7b2c1178252d69a3e6879f89a2aec9d7f4079c431d0632", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCamp.Models.UserComment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\CommentList\Default.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\CommentList\Default.cshtml"
  Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Views\Shared\Components\CommentList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCamp.Models.UserComment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591