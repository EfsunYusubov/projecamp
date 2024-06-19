#pragma checksum "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Writer\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d202db384ad3659f45419b2a8befb4eb8db20325714a637ab3943c7764dc99db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d202db384ad3659f45419b2a8befb4eb8db20325714a637ab3943c7764dc99db", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"03cf7df703d3181109d1569d1c9df8a6f7f8e7eb569a88cd5b819b8826383314", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\VsProject\AspDotNetCoreYoutube\ProjectCamp\ProjectCamp\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ajaxa xos geldiniz</h1>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar Listi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir</button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar əlavə et</button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar sil</button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar guncelle</button>
<br />
<br />
<div id=""writerlist"">
    Bura yazarlar gelecek
</div>
<br />
<div id=""writerget"">
    Burda xeta aldim
</div>
<br />
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID deyerini yaz"" class=""form-control"" />
</div>
<br />
<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID"" />

    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar adi"" />
</div>
<br />
<div>
    <input type=""text"" class=""form-cont");
            WriteLiteral("rol\" id=\"txtid\" placeholder=\"Silinecek yazar\" />\r\n</div>\r\n<br />\r\n<input type=\"text\" class=\"form-control\" id=\"txtid1\" placeholder=\"Güncəllə ID\" />\r\n<input type=\"text\" class=\"form-control\" id=\"txtwritername1\" placeholder=\"Güncəllənəcək ad\" />\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class='table table-bordered'><tr><th>Yazar ID</th><th>Yazar Adi</th></tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr> <td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);

                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
     ");
                WriteLiteral(@"           type: ""get"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func)
                    console.log(w);

                    // let getvalue = `<table class=table table-bordered> <tr><th> Yazar ID </th> <th> Yazar Adi </th> </tr>
                    // <tr><td>${w.Id}</td><td>${w.Name}</td></tr></table>`;
                    // ${ ""#writerget"" }.html(getvalue);
                }
            });

        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Ya");
                WriteLiteral(@"zar elave edildi"");
                }

            });
        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silindi"");
                }

            });
        });

        $(""#btnupdatewriter"").click(function ({
            let writer = {
                Id: $(#txtid1).val(),
                Name: $(#txtwritername1).val()
            };
             $.ajax({

            type: ""post"",
            url: ""Admin/Writer/UpdateWriter/"",
            data: writer,
            success: function (func) {
                alert(""Guncelleme hazirdir"");
             }
             });
        })       
              


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
