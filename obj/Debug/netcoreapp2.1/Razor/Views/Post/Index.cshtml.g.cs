#pragma checksum "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0070c6848e7c4b945556d03c90f4dbd5fe3d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\_ViewImports.cshtml"
using DoAN_k4;

#line default
#line hidden
#line 2 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\_ViewImports.cshtml"
using DoAN_k4.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0070c6848e7c4b945556d03c90f4dbd5fe3d01", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219ed72ee84b459bfc4315a193f4d9a9f099dced", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Posts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Quản Lý Bài Viết";

#line default
#line hidden
            BeginContext(120, 245, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\" style=\"padding: 20px;\">\r\n        <span style=\"font-size:18px;font-weight:800\">Danh Sách Bài Viết</span>\r\n    </div>\r\n    \r\n    <div class=\"col-md-12\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(365, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0070c6848e7c4b945556d03c90f4dbd5fe3d014281", async() => {
                BeginContext(384, 298, true);
                WriteLiteral(@"
                <div class=""form-group"" style=""display:flex"">
                    <input type=""text"" name=""searchString"" class=""form-control"" placeholder=""Search users..."">
                    <button type=""submit"" class=""btn btn-primary"">Search</button>
                </div>

            ");
                EndContext();
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
            EndContext();
            BeginContext(689, 491, true);
            WriteLiteral(@"
        </div>
        <table class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>STT</th>
                    <th>Post</th>
                    <th>Total Like</th>
                    <th>Totla Comment</th>
                    <th>Status</th>
                    <th>CreateAt</th>
                    <th>UpdateAt</th>
                    <th>Option</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 37 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                 for (var i = 0; i < Model.Count; i++)
                {
                    var post = Model[i];

#line default
#line hidden
            BeginContext(1297, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1353, 5, false);
#line 41 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1395, 9, false);
#line 42 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                       Write(post.Post);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1440, 17, false);
#line 43 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                       Write(post.Likes.Length);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 104, true);
            WriteLiteral(" <i class=\"fa-regular fa-thumbs-up\"></i></td> <!-- Display total likes -->\r\n                        <td>");
            EndContext();
            BeginContext(1562, 20, false);
#line 44 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                       Write(post.Comments.Length);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 46, true);
            WriteLiteral(" <i class=\"fa-regular fa-comments\"></i></td>\r\n");
            EndContext();
#line 45 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                         if (post.Status)
                        {

#line default
#line hidden
            BeginContext(1698, 91, true);
            WriteLiteral("                            <td><label class=\"badge badge-success\">Hoạt Động</label></td>\r\n");
            EndContext();
#line 48 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1873, 95, true);
            WriteLiteral("                            <td><label class=\"badge badge-danger\">Dừng Hoạt Động</label></td>\r\n");
            EndContext();
#line 52 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1995, 30, true);
            WriteLiteral("\r\n                        <td>");
            EndContext();
            BeginContext(2026, 14, false);
#line 54 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                       Write(post.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2076, 14, false);
#line 55 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                       Write(post.UpdatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2090, 87, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a style=\"color:black\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2177, "\"", 2239, 1);
#line 57 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
WriteAttributeValue("", 2184, Url.Action("Detail", "Post", new { idPost = post.Id }), 2184, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2240, 49, true);
            WriteLiteral("> <i class=\"fa-solid fa-circle-info\"></i></a> |\r\n");
            EndContext();
#line 58 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                             if (post.Status)
                            {

#line default
#line hidden
            BeginContext(2367, 84, true);
            WriteLiteral("                                <a class=\"BanPost\" style=\"color:black\" data-IdPost=\"");
            EndContext();
            BeginContext(2452, 7, false);
#line 60 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                                                                               Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 48, true);
            WriteLiteral("\" href=\"#\"><i class=\"fa-solid fa-ban\"></i></a>\r\n");
            EndContext();
#line 61 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                            }else{

#line default
#line hidden
            BeginContext(2543, 93, true);
            WriteLiteral("                                <a class=\"UnlockPost\" style=\"color:black\" data-IdPostUnlock=\"");
            EndContext();
            BeginContext(2637, 7, false);
#line 62 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                                                                                        Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2644, 51, true);
            WriteLiteral("\" href=\"#\"><i class=\"fa-solid fa-unlock\"></i></a>\r\n");
            EndContext();
#line 63 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2726, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2803, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"pagination-container\" style=\"margin-top:15px\">\r\n            ");
            EndContext();
            BeginContext(2924, 274, false);
#line 70 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Views\Post\Index.cshtml"
       Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page }),
            new PagedListRenderOptions
            {
            LiElementClasses = new string[] { "page-item" },
            PageClasses = new string[] { "page-link" }
            }

            ));

#line default
#line hidden
            EndContext();
            BeginContext(3198, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3257, 3467, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".BanPost"").click(function () {
                var postId = $(this).data('idpost');
                Swal.fire({
                    title: 'Bạn Có Chắc Chắn Muốn Ban Bài Viết Này ?',
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, delete it!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            type: 'POST',
                            url: '/Post/DeletePost',
                            data: { postId: postId },
                            success: function (result) {

                                setTimeout(function () {
                                    window.location.reload();
                                }, 1000);
                            ");
                WriteLiteral(@"    Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'Ban Bài Viết Thành Công',
                                    showConfirmButton: false,
                                    timer: 2000
                                })
                            },
                            error: function (xhr, status, error) {
                                alert('Error: ' + error);
                            }
                        });
                    }
                })
            })
        });



        $(document).ready(function () {
            $("".UnlockPost"").click(function () {
                var idPost = $(this).data('idpostunlock');
                Swal.fire({
                    title: 'Are you sure?',
                    text: ""Bạn Có Chắc Chắn Muốn Mở Khóa Bài Viết Này ?"",
                    icon: 'warning',
                    showCancelButton: tru");
                WriteLiteral(@"e,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, unlock it!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        // User clicked ""Yes,"" perform the AJAX request
                        $.ajax({
                            type: 'POST',
                            url: '/Post/UnlockPost',
                            data: { idPost: idPost },
                            success: function (result) {

                                setTimeout(function () {
                                    window.location.reload();
                                }, 1000);
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'Mở Khóa Bài Viết Thành Công',
                                    showConfirmButton: false,");
                WriteLiteral(@"
                                    timer: 2000
                                })
                            },
                            error: function (xhr, status, error) {
                                alert('Error: ' + error);
                            }
                        });
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Posts>> Html { get; private set; }
    }
}
#pragma warning restore 1591