#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminMesssage\ComposeMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dfa5cea0dbc74316c8ba27cd1c7e0ac6d7c89866ed4392ac725efdcc6a4e227f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMesssage_ComposeMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMesssage/ComposeMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dfa5cea0dbc74316c8ba27cd1c7e0ac6d7c89866ed4392ac725efdcc6a4e227f", @"/Areas/Admin/Views/AdminMesssage/ComposeMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"03cf7df703d3181109d1569d1c9df8a6f7f8e7eb569a88cd5b819b8826383314", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminMesssage_ComposeMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\AdminMesssage\ComposeMessage.cshtml"
  
    ViewData["Title"] = "ComposeMessage";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa5cea0dbc74316c8ba27cd1c7e0ac6d7c89866ed4392ac725efdcc6a4e227f4428", async() => {
                WriteLiteral(@"
        

    <div class=""wrapper wrapper-content"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""ibox "">
                    <div class=""ibox-content mailbox-content"">
                        <div class=""file-manager"">
                            <a class=""btn btn-block btn-primary compose-mail"" href=""mail_compose.html"">Mesaj qutusu</a>
                            <div class=""space-25""></div>
                            <h5>Diqqət!</h5>
                            <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                <li><a href=""/Admin/AdminMesssage/Inbox/""> <i class=""fa fa-inbox ""></i> Gelenler <span class=""label label-warning float-right"">16</span> </a></li>
                                <li><a href=""/Admin/AdminMesssage/SendBox/""> <i class=""fa fa-envelope-o""></i> Göndərilənlər</a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i> Vacib</a></li>
                      ");
                WriteLiteral(@"          <li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i> Lazımsız <span class=""label label-danger float-right"">2</span></a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Silinənlər</a></li>
                            </ul>
                            <h5>Kateqoriyalar</h5>
                            <ul>                                
                                <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> İş </a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Sənədlər</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Sosial</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Tanıtımlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-warning""></i>Tələblər</a></li>
                            </ul>
                            <div class=""cle");
                WriteLiteral(@"arfix""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 animated fadeInRight"">
                <div class=""mail-box-header"">
                    <div class=""float-right tooltip-demo"">
                        <a href=""mailbox.html"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to draft folder""><i class=""fa fa-pencil""></i> Draft</a>
                        <a href=""mailbox.html"" class=""btn btn-danger btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Discard email""><i class=""fa fa-times""></i> Discard</a>
                    </div>
                    <h2>
                        Compse mail
                    </h2>
                </div>
                <div class=""mail-box"">


                    <div class=""mail-body"">

                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfa5cea0dbc74316c8ba27cd1c7e0ac6d7c89866ed4392ac725efdcc6a4e227f7840", async() => {
                    WriteLiteral(@"
                            <div class=""form-group row"">
                                <label class=""col-sm-2 col-form-label"">Alıcı:</label>

                                <div class=""col-sm-10""><input type=""text"" class=""form-control"" ></div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-sm-2 col-form-label"">Məzmun:</label>

                                <div class=""col-sm-10""><input type=""text"" class=""form-control"" name=""Subject""></div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""col-sm-2 col-form-label"">Mesajınız:</label>

                                <textarea class=""form-control"" name=""MessageDetails"" rows=""4"" cols=""10""></textarea>
                            </div>
                            <button>Göndər</button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    </div>
                                        
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""mail-body text-right tooltip-demo"">
                    <a href=""/Admin/AdminMesssage/ComposeMessage/""  class=""btn btn-sm btn-primary"" 
                    data-toggle=""tooltip"" data-placement=""top"" title=""Send""><i class=""fa fa-reply""></i> Göndər</a>
                    <a href=""/Admin/AdminMesssage/ComposeMessage/"" class=""btn btn-white btn-sm"" 
                    data-toggle=""tooltip"" data-placement=""top"" title=""Discard email""><i class=""fa fa-times""></i> İptal et</a>
                    <a href=""/Admin/AdminMesssage/ComposeMessage/"" class=""btn btn-white btn-sm"" 
                    data-toggle=""tooltip"" data-placement=""top"" title=""Move to draft folder""><i class=""fa fa-pencil""></i> Lazımsız</a>
                    </div>
                    <div class=""clearfix""></div>



                </div>
            </di");
                WriteLiteral("v>\r\n        </div>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
