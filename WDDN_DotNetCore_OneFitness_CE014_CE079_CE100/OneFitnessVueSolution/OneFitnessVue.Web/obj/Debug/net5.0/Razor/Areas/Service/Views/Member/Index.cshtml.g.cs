#pragma checksum "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e8706348c4149bff0e1a5c02b718136061479a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Service_Views_Member_Index), @"mvc.1.0.view", @"/Areas/Service/Views/Member/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\_ViewImports.cshtml"
using OneFitnessVue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\_ViewImports.cshtml"
using OneFitnessVue.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml"
using OneFitnessVue.Web.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e8706348c4149bff0e1a5c02b718136061479a", @"/Areas/Service/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c263d2f5ad1a8faa63d30006d275acccbf371b49", @"/Areas/Service/Views/_ViewImports.cshtml")]
    public class Areas_Service_Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/moment/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml"
   ViewBag.PageName = "Member"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_DatatablesCss.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""col-md-12"">
    <div class=""card card-default"">
        <div class=""card-header"">
            <h3 class=""card-title"">All</h3>
        </div>
        <div class=""card-body"">
            <table id=""DataTableGrid"" class=""table table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>MemberId</th>
                        <th>MemberNo</th>
                        <th>Full Name</th>
                        <th>Joining Date</th>
                        <th>Status</th>
                        <th>View</th>
                       
                       
                        <th>Edit</th>
                        <th>Delete</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>





");
#nullable restore
#line 38 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_DatatablesScripts.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 39 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Areas\Service\Views\Member\Index.cshtml"
Write(Html.Hidden("item-to-delete", "", new { @id = "item-to-delete" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    \n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e8706348c4149bff0e1a5c02b718136061479a5894", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
            $('#DataTableGrid').DataTable({
                order: [[0, 'desc']],
                ""processing"": true,
                ""serverSide"": true,
                ""filter"": true,
                ""ajax"": {
                    ""url"": ""/Service/Member/ShowAllMemberRegistration"",
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [0],
                        ""visible"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [1],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [2],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                      ");
                WriteLiteral(@"  ""targets"": [3],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [4],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [5],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [6],
                        ""orderable"": false,
                        ""searchable"": false
                    },
                    {
                        ""targets"": [7],
                        ""orderable"": false,
                        ""searchable"": false
                    }
                ],
                ""columns"": [
                    { ""data"": ""MemberId"", ""name"": ""MemberId"", ""autoWidth"": true },
                    { ""data"": ""MemberNo"", ""name"": ""MemberNo"", ""autoWidth""");
                WriteLiteral(@": true },
                    { ""data"": ""FullName"", ""name"": ""FullName"", ""autoWidth"": true },
                    
                    {
                        ""render"": function (data, type, full, meta) {
                            return moment(full.JoiningDate).format(""DD/MM/YYYY"");
                        }
                    },
                    { ""data"": ""Status"", ""name"": ""Status"", ""autoWidth"": true },
                    {
                        ""render"": function(data, type, full, meta) { return '<a class=""btn btn-info"" href=""/Service/Member/MemberProfile?MemberId=' + full.MemberId + '""> <i class=""fas fa-user-alt""></i> Profile</a>'; }
                    },
                 
                    {
                        ""render"": function(data, type, full, meta) {
                            return '<a class=""btn btn-primary"" href=""/Service/Member/EditApplication?MemberId=' + full.MemberId + '""> <i class=""fas fa-edit""></i> Edit</a>';
                        }
                    },
              ");
                WriteLiteral(@"      {
                        ""render"": function(data, type, full, meta) {
                            if (full.Status == ""Active"") {
                                return ' <button type=""button"" class=""btn btn-success"" onclick=""InActiveMember(' + full.MemberId + ');"">  Active </button>';
                            } else
                            {
                                return ' <button type=""button"" class=""btn btn-danger"" onclick=""ActiveMember(' + full.MemberId + ');"">  InActive </button>';
                            }

                        }
                    }
                ]
            });


        });

        function InActiveMember(memberId) {
            $.confirm({
                title: 'Message!',
                content: 'Do you want to Deactivate Member ?',
                buttons: {
                    confirm: function() {
                        $.ajax({
                            url: ""/Service/Member/InActiveMember"",
                            type: ""POST"",
     ");
                WriteLiteral(@"                       data: { MemberId: memberId },
                            success: function(data, textStatus, xhr) {
                                if (data.Result == ""success"") {
                                    location.reload();
                                }
                                if (data.Result == ""failed"") {
                                    $.alert('Something Went Wrong');
                                }
                            },
                            error: function(xhr, status, err) {
                                if (xhr.status == 401) {
                                    alert('Error');
                                    window.location.href = ""/Portal/Logout"";
                                }
                                if (xhr.status == 500) {
                                    alert('Error');
                                    window.location.href = ""/Portal/Logout"";
                                }
                            }
                ");
                WriteLiteral(@"        });
                    },
                    cancel: function() {
                        $.alert('Canceled!');
                    }
                }
            });
        }

        function ActiveMember(memberId) {
            $.confirm({
                title: 'Message!',
                content: 'Do you want to Deactivate Member ?',
                buttons: {
                    confirm: function() {
                        $.ajax({
                            url: ""/Service/Member/ActiveMember"",
                            type: ""POST"",
                            data: { MemberId: memberId },
                            success: function(data, textStatus, xhr) {
                                if (data.Result == ""success"") {
                                    location.reload();
                                }
                                if (data.Result == ""failed"") {
                                    $.alert('Something Went Wrong');
                                }
              ");
                WriteLiteral(@"              },
                            error: function(xhr, status, err) {
                                if (xhr.status == 401) {
                                    alert('Error');
                                    window.location.href = ""/Portal/Logout"";
                                }
                                if (xhr.status == 500) {
                                    alert('Error');
                                    window.location.href = ""/Portal/Logout"";
                                }
                            }
                        });
                    },
                    cancel: function() {
                        $.alert('Canceled!');
                    }
                }
            });
        }
    </script>


");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
