#pragma checksum "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8bcb8ee665eeecbbe351d2c4c88e9f4597fd8df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SocialUser_Views_Home_GetPostDetail), @"mvc.1.0.view", @"/Areas/SocialUser/Views/Home/GetPostDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SocialUser/Views/Home/GetPostDetail.cshtml", typeof(AspNetCore.Areas_SocialUser_Views_Home_GetPostDetail))]
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
#line 1 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\_ViewImports.cshtml"
using DoAN_k4;

#line default
#line hidden
#line 2 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\_ViewImports.cshtml"
using DoAN_k4.Models;

#line default
#line hidden
#line 1 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
using DoAN_k4.Helpers;

#line default
#line hidden
#line 2 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8bcb8ee665eeecbbe351d2c4c88e9f4597fd8df", @"/Areas/SocialUser/Views/Home/GetPostDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219ed72ee84b459bfc4315a193f4d9a9f099dced", @"/Areas/SocialUser/Views/_ViewImports.cshtml")]
    public class Areas_SocialUser_Views_Home_GetPostDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "SocialUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPostDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-form position-absolute bottom-0 w-100 left-0 bg-white z-index-1 p-3 shadow-xs theme-dark-bg "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
  
    ViewData["Title"] = "Detail Page";
    Layout = "~/Areas/SocialUser/Views/Shared/_LayoutUser.cshtml";
    var userId = @HttpContextAccessor.HttpContext.Session.GetString("UserLogin");

#line default
#line hidden
            BeginContext(332, 113, true);
            WriteLiteral("\r\n<div class=\"col-xl-7 col-xxl-8 col-lg-7\">\r\n    <div class=\"card w-100 shadow-xss rounded-xxl border-0 p-4 mb-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 445, "\"", 459, 1);
#line 11 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 450, Model.Id, 450, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 89, true);
            WriteLiteral(">\r\n        <div class=\"card-body p-0 d-flex\">\r\n            <figure class=\"avatar me-3\">\r\n");
            EndContext();
#line 14 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.UserImg))
                {
                    var userIG = Model.UserImg.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(734, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 758, "\"", 771, 1);
#line 17 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 764, userIG, 764, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(772, 52, true);
            WriteLiteral(" alt=\"image\" class=\"shadow-sm rounded-circle w45\">\r\n");
            EndContext();
#line 18 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(884, 156, true);
            WriteLiteral("                    <img src=\"https://cdn.pixabay.com/photo/2018/11/13/21/43/avatar-3814049_960_720.png\" alt=\"image\" class=\"shadow-sm rounded-circle w45\">\r\n");
            EndContext();
#line 22 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
            BeginContext(1059, 104, true);
            WriteLiteral("\r\n            </figure>\r\n            <h4 class=\"fw-700 text-grey-900 font-xssss mt-1\">\r\n                ");
            EndContext();
            BeginContext(1164, 14, false);
#line 26 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 104, true);
            WriteLiteral("\r\n                <span class=\"d-block font-xssss fw-500 mt-1 lh-3 text-grey-500\">\r\n                    ");
            EndContext();
            BeginContext(1283, 47, false);
#line 28 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
               Write(DateHelper.FormatTimeDifference(Model.PostTime));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 46, true);
            WriteLiteral("\r\n                </span>\r\n            </h4>\r\n");
            EndContext();
#line 31 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.UserId == userId)
            {

#line default
#line hidden
            BeginContext(1433, 550, true);
            WriteLiteral(@"                <a href=""#"" class=""ms-auto"" id=""dropdownMenu2"" data-bs-toggle=""dropdown"" aria-expanded=""false""><i class=""ti-more-alt text-grey-900 btn-round-md bg-greylight font-xss""></i></a>
                <div class=""dropdown-menu dropdown-menu-end p-4 rounded-xxl border-0 shadow-lg"" aria-labelledby=""dropdownMenu2"">
                    <div class=""card-body p-0 d-flex mt-2"">
                        <i class=""feather-alert-circle text-grey-500 me-3 font-lg""></i>
                        <h4 class=""fw-600 text-grey-900 font-xssss mt-0 me-4""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1983, "\"", 2016, 3);
            WriteAttributeValue("", 1993, "deletePost(\'", 1993, 12, true);
#line 37 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 2005, Model.Id, 2005, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2014, "\')", 2014, 2, true);
            EndWriteAttribute();
            BeginContext(2017, 168, true);
            WriteLiteral(">Delete Post <span class=\"d-block font-xsssss fw-500 mt-1 lh-3 text-grey-500\">Save to your saved items</span></h4>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 40 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(2200, 98, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <div class=\"card-body p-0 me-lg-5\">\r\n                ");
            EndContext();
            BeginContext(2298, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8bcb8ee665eeecbbe351d2c4c88e9f4597fd8df11372", async() => {
                BeginContext(2401, 103, true);
                WriteLiteral("\r\n                    <p class=\"fw-500 text-grey-500 lh-26 font-xssss w-100\">\r\n                        ");
                EndContext();
                BeginContext(2505, 10, false);
#line 47 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                   Write(Model.Post);

#line default
#line hidden
                EndContext();
                BeginContext(2515, 44, true);
                WriteLiteral("\r\n                    </p>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2563, 71, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body d-block p-0\">\r\n");
            EndContext();
#line 52 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (Model.PostImg != null)
                {
                    

#line default
#line hidden
#line 54 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     foreach (var imageUrl in Model.PostImg)
                    {
                        

#line default
#line hidden
#line 56 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                         if (!string.IsNullOrEmpty(imageUrl))
                        {
                            var replacedImageUrl = imageUrl.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(2992, 166, true);
            WriteLiteral("                            <div class=\"row ps-2 pe-2\">\r\n                                <div class=\"col-xs-12 col-sm-12 p-1\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3158, "\"", 3182, 1);
#line 61 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 3165, replacedImageUrl, 3165, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3183, 64, true);
            WriteLiteral(" data-lightbox=\"\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3247, "\"", 3270, 1);
#line 62 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 3253, replacedImageUrl, 3253, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3271, 157, true);
            WriteLiteral(" class=\"rounded-3 w-100\" alt=\"image\">\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 66 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                        }

#line default
#line hidden
#line 66 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                         
                    }

#line default
#line hidden
#line 67 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(3497, 113, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body d-flex p-0 mt-3 justify-content-between\">\r\n");
            EndContext();
#line 74 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Likes != null)
            {
                int likeCount = Model.Likes.Length;

                

#line default
#line hidden
#line 78 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (Model.Liked)
                {

#line default
#line hidden
            BeginContext(3773, 249, true);
            WriteLiteral("                    <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                        <i class=\"feather-heart text-white bg-red-gradiant me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4023, 8, false);
#line 81 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                                                Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4031, 70, true);
            WriteLiteral("\"></i>\r\n                        <span class=\"likeCount\" data-item-id=\"");
            EndContext();
            BeginContext(4102, 8, false);
#line 82 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4110, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4113, 9, false);
#line 82 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                    Write(likeCount);

#line default
#line hidden
            EndContext();
            BeginContext(4122, 40, true);
            WriteLiteral(" Like</span>\r\n                    </a>\r\n");
            EndContext();
#line 84 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4222, 222, true);
            WriteLiteral("                    <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                        <i class=\"feather-heart me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4445, 8, false);
#line 88 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4453, 70, true);
            WriteLiteral("\"></i>\r\n                        <span class=\"likeCount\" data-item-id=\"");
            EndContext();
            BeginContext(4524, 8, false);
#line 89 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4532, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4535, 9, false);
#line 89 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                    Write(likeCount);

#line default
#line hidden
            EndContext();
            BeginContext(4544, 40, true);
            WriteLiteral(" Like</span>\r\n                    </a>\r\n");
            EndContext();
#line 91 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
#line 91 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 

            }
            else
            {

#line default
#line hidden
            BeginContext(4653, 214, true);
            WriteLiteral("                <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                    <i class=\"feather-heart me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4868, 8, false);
#line 97 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                 Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4876, 71, true);
            WriteLiteral("\"></i>\r\n                    <span>0 Like</span>\r\n                </a>\r\n");
            EndContext();
#line 100 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }

#line default
#line hidden
#line 101 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Comments != null)
            {
                int cmtCount = Model.Comments.Length;

#line default
#line hidden
            BeginContext(5074, 243, true);
            WriteLiteral("                <a href=\"#\" class=\"d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss\">\r\n                    <i class=\"feather-message-circle text-dark text-grey-900 btn-round-sm font-lg\"></i>\r\n                    <span>");
            EndContext();
            BeginContext(5318, 8, false);
#line 106 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     Write(cmtCount);

#line default
#line hidden
            EndContext();
            BeginContext(5326, 40, true);
            WriteLiteral(" Comments</span>\r\n                </a>\r\n");
            EndContext();
#line 108 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(5414, 283, true);
            WriteLiteral(@"                <a href=""#"" class=""d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss"">
                    <i class=""feather-message-circle text-dark text-grey-900 btn-round-sm font-lg""></i>
                    <span>0 Comment</span>
                </a>
");
            EndContext();
#line 115 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(5712, 262, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""col-xl-5 col-xxl-4 col-lg-5 pe-0 ps-0"">
    <div class=""card w-100 d-block chat-body p-0 border-0 shadow-xss rounded-3 mb-3 position-relative"">
        <div class=""messages-content chat-wrapper scroll-bar p-3"">
");
            EndContext();
#line 122 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Comments != null)
            {
                

#line default
#line hidden
#line 124 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 foreach (var item in Model.Comments)
                {


#line default
#line hidden
            BeginContext(6107, 153, true);
            WriteLiteral("                    <div class=\"message-item\">\r\n                        <div class=\"message-user\">\r\n                            <figure class=\"avatar\">\r\n");
            EndContext();
#line 130 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                 if (!string.IsNullOrEmpty(item.UserAvatar))
                                {
                                    var replacedImageUrl = item.UserAvatar.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(6507, 40, true);
            WriteLiteral("                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6547, "\"", 6570, 1);
#line 133 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 6553, replacedImageUrl, 6553, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6571, 15, true);
            WriteLiteral(" alt=\"image\">\r\n");
            EndContext();
#line 134 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"

                                }

#line default
#line hidden
            BeginContext(6623, 134, true);
            WriteLiteral("                            </figure>\r\n                            <div>\r\n                                <h5 class=\"font-xssss mt-2\">");
            EndContext();
            BeginContext(6758, 13, false);
#line 138 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                       Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6771, 95, true);
            WriteLiteral("</h5>\r\n                                <div class=\"time\">\r\n                                    ");
            EndContext();
            BeginContext(6867, 56, false);
#line 140 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                               Write(DateHelper.FormatTimeDifference(item.CmtDate.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(6923, 172, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"message-wrap shadow-none\">");
            EndContext();
            BeginContext(7096, 12, false);
#line 144 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(7108, 36, true);
            WriteLiteral("</div>\r\n                    </div>\r\n");
            EndContext();
#line 146 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
#line 146 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(7178, 24, true);
            WriteLiteral("        </div>\r\n        ");
            EndContext();
            BeginContext(7202, 495, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8bcb8ee665eeecbbe351d2c4c88e9f4597fd8df29380", async() => {
                BeginContext(7356, 334, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <input id=""commentInput"" type=""text"" placeholder=""Start typing.."" name=""content"" style=""opacity: 1; color: black; border: 1px solid #ccc; background: #ddd;"">
            </div>
            <button class=""bg-current""><i class=""ti-arrow-right text-white""></i></button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                                                                                  Write(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-item-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7697, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7737, 6622, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".feather-heart"").click(function (e) {
                e.preventDefault();
                var btn = $(this);
                var itemId = btn.data(""item-id"");
                var likeCountElem = $("".likeCount[data-item-id='"" + itemId + ""']"");

                // Gửi yêu cầu Ajax
                $.ajax({
                    type: ""post"", // Hoặc POST tùy thuộc vào cách bạn cấu hình server
                    url: ""/SocialUser/home/UpdatePostLikes"", // Thay đổi ControllerName thành tên controller của bạn
                    data: { postId: itemId },
                    dataType: ""json"",
                    success: function (response) {
                        console.log(response.liked);
                        if (response.liked == true) {
                            console.log(""tcvf"");
                            $("".feather-heart[data-item-id='"" + itemId + ""']"").addClass(""bg-red-gradiant"");
                            ");
                WriteLiteral(@"$("".feather-heart[data-item-id='"" + itemId + ""']"").addClass(""text-white"");

                        } else if (response.liked == false) {
                            // Nếu liked là false, cập nhật trạng thái liked
                            console.log(""shjs"");
                            $("".feather-heart[data-item-id='"" + itemId + ""']"").removeClass(""bg-red-gradiant"");
                            $("".feather-heart[data-item-id='"" + itemId + ""']"").removeClass(""text-white"");
                        } else {
                            alert(""Có lỗi xảy ra. Vui lòng thử lại sau."");
                        }

                        // Cập nhật số lượng like (nếu có) - Lưu ý: Nếu API không trả về số lượng like, bạn phải cập nhật số lượng like một cách riêng biệt (nếu cần thiết)
                        var currentLikeCount = parseInt(likeCountElem.text());
                        var newLikeCount = response.liked ? currentLikeCount + 1 : currentLikeCount - 1;
                        likeCountElem.");
                WriteLiteral(@"text(newLikeCount + "" Like"");
                    },
                    error: function () {
                        alert(""Có lỗi xảy ra. Vui lòng thử lại sau."");
                    }
                });
            });

        });
        function replaceImageUrl(imageUrl) {
            return imageUrl.replace(""http://10.0.2.2:3000"", ""http://localhost:3000"");
        }
        function formatTimeDifference(dateTimeString) {
            const postTime = new Date(dateTimeString);
            const now = new Date();
            const timeDifference = now - postTime;

            const minutesDifference = Math.floor(timeDifference / (1000 * 60));
            if (minutesDifference < 1) {
                return ""Just now"";
            } else if (minutesDifference === 1) {
                return ""1 minute ago"";
            } else if (minutesDifference < 60) {
                return `${minutesDifference} minutes ago`;
            } else if (minutesDifference < 1440) {
                con");
                WriteLiteral(@"st hoursDifference = Math.floor(minutesDifference / 60);
                return `${hoursDifference} ${hoursDifference === 1 ? ""hour"" : ""hours""} ago`;
            } else {
                const daysDifference = Math.floor(minutesDifference / 1440);
                return `${daysDifference} ${daysDifference === 1 ? ""day"" : ""days""} ago`;
            }
        }
        $(document).ready(function () {
            $(""#commentForm"").submit(function (e) {
                e.preventDefault(); // Prevent the form from submitting normally

                // Get the comment text from the input field
                var comment = $(""#commentInput"").val();
                var postId = $(""#commentForm"").data(""item-id"");

                // Send the AJAX request to post the comment
                $.ajax({
                    type: ""POST"",
                    url: ""/SocialUser/home/PostComment"",
                    data: {
                        postId: postId,
                        content: comment,");
                WriteLiteral(@"
                    },
                    success: function (response) {
                        console.log(response);
                        var responseData = JSON.parse(response);
                        console.log(responseData.comment);
                        console.log(responseData.comment.userAvatar);
                        var commentHtml =
                            '<div class=""message-item"">' +
                            '<div class=""message-user"">' +
                            '<figure class=""avatar"">';
                        if (responseData.comment.userAvatar) {
                            // Replace the image URL before appending it to the HTML
                            var replacedImageUrl = replaceImageUrl(responseData.comment.userAvatar);
                            commentHtml += '<img src=""' + replacedImageUrl + '"" alt=""image"">';
                        }
                        commentHtml +=
                            '</figure>' +
                        ");
                WriteLiteral(@"    '<div>' +
                            '<h5 class=""font-xssss mt-2"">' + responseData.comment.userName + '</h5>' +
                            '<div class=""time"">' + formatTimeDifference(responseData.comment.cmtDate) + '</div>' +
                            '</div>' +
                            '</div>' +
                            '<div class=""message-wrap shadow-none"">' + responseData.comment.content + '</div>' +
                            '</div>';

                        $("".messages-content"").append(commentHtml);

                        $(""#commentInput"").val("""");
                    },
                    error: function () {
                        // Handle error here if needed
                    }
                });
            });
        });

        function deletePost(postId) {
            if (!confirm(""Are you sure you want to delete this post?"")) {
                return;
            }
            console.log(postId);
            $.ajax({
                type: ");
                WriteLiteral(@"""POST"",
                url: `/SocialUser/Home/DeletePost`,
                data: { postId },
                success: function (response) {
                    console.log(response);
                    // Xoá bài viết khỏi giao diện
                    $(`#${postId}`).remove();
                },
                error: function () {
                    // Xử lý khi có lỗi trong quá trình xoá bài viết
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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