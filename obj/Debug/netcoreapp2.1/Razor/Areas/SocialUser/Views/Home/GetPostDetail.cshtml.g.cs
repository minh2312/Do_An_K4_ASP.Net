#pragma checksum "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f34cb092cf6f817876c68920eb19f0992fb3ed"
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
#line 6 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
using DoAN_k4.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f34cb092cf6f817876c68920eb19f0992fb3ed", @"/Areas/SocialUser/Views/Home/GetPostDetail.cshtml")]
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
#line 1 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
  
    ViewData["Title"] = "Detail Page";
    Layout = "~/Areas/SocialUser/Views/Shared/_LayoutUser.cshtml";


#line default
#line hidden
            BeginContext(141, 204, true);
            WriteLiteral("\r\n\r\n<div class=\"col-xl-7 col-xxl-8 col-lg-7\">\r\n    <div class=\"card w-100 shadow-xss rounded-xxl border-0 p-4 mb-3\">\r\n        <div class=\"card-body p-0 d-flex\">\r\n            <figure class=\"avatar me-3\">\r\n");
            EndContext();
#line 13 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (!string.IsNullOrEmpty(Model.UserImg))
                {
                    var userIG = Model.UserImg.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(530, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 554, "\"", 567, 1);
#line 16 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 560, userIG, 560, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(568, 52, true);
            WriteLiteral(" alt=\"image\" class=\"shadow-sm rounded-circle w45\">\r\n");
            EndContext();
#line 17 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(680, 156, true);
            WriteLiteral("                    <img src=\"https://cdn.pixabay.com/photo/2018/11/13/21/43/avatar-3814049_960_720.png\" alt=\"image\" class=\"shadow-sm rounded-circle w45\">\r\n");
            EndContext();
#line 21 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
            BeginContext(855, 104, true);
            WriteLiteral("\r\n            </figure>\r\n            <h4 class=\"fw-700 text-grey-900 font-xssss mt-1\">\r\n                ");
            EndContext();
            BeginContext(960, 14, false);
#line 25 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(974, 104, true);
            WriteLiteral("\r\n                <span class=\"d-block font-xssss fw-500 mt-1 lh-3 text-grey-500\">\r\n                    ");
            EndContext();
            BeginContext(1079, 47, false);
#line 27 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
               Write(DateHelper.FormatTimeDifference(Model.PostTime));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 1178, true);
            WriteLiteral(@"
                </span>
            </h4>
            <a href=""#"" class=""ms-auto"" id=""dropdownMenu2"" data-bs-toggle=""dropdown"" aria-expanded=""false""><i class=""ti-more-alt text-grey-900 btn-round-md bg-greylight font-xss""></i></a>
            <div class=""dropdown-menu dropdown-menu-end p-4 rounded-xxl border-0 shadow-lg"" aria-labelledby=""dropdownMenu2"">
                <div class=""card-body p-0 d-flex"">
                    <i class=""feather-bookmark text-grey-500 me-3 font-lg""></i>
                    <h4 class=""fw-600 text-grey-900 font-xssss mt-0 me-4"">Save Link <span class=""d-block font-xsssss fw-500 mt-1 lh-3 text-grey-500"">Add this to your saved items</span></h4>
                </div>
                <div class=""card-body p-0 d-flex mt-2"">
                    <i class=""feather-alert-circle text-grey-500 me-3 font-lg""></i>
                    <h4 class=""fw-600 text-grey-900 font-xssss mt-0 me-4"">Hide Post <span class=""d-block font-xsssss fw-500 mt-1 lh-3 text-grey-500"">Save to your saved items");
            WriteLiteral("</span></h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <div class=\"card-body p-0 me-lg-5\">\r\n                ");
            EndContext();
            BeginContext(2304, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f34cb092cf6f817876c68920eb19f0992fb3ed9941", async() => {
                BeginContext(2407, 103, true);
                WriteLiteral("\r\n                    <p class=\"fw-500 text-grey-500 lh-26 font-xssss w-100\">\r\n                        ");
                EndContext();
                BeginContext(2511, 10, false);
#line 46 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                   Write(Model.Post);

#line default
#line hidden
                EndContext();
                BeginContext(2521, 44, true);
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
#line 44 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
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
            BeginContext(2569, 71, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body d-block p-0\">\r\n");
            EndContext();
#line 51 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (Model.PostImg != null)
                {
                    

#line default
#line hidden
#line 53 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     foreach (var imageUrl in Model.PostImg)
                    {
                        

#line default
#line hidden
#line 55 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                         if (!string.IsNullOrEmpty(imageUrl))
                        {
                            var replacedImageUrl = imageUrl.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(2998, 166, true);
            WriteLiteral("                            <div class=\"row ps-2 pe-2\">\r\n                                <div class=\"col-xs-12 col-sm-12 p-1\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3164, "\"", 3188, 1);
#line 60 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 3171, replacedImageUrl, 3171, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3189, 72, true);
            WriteLiteral(" data-lightbox=\"roadtrip\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3261, "\"", 3284, 1);
#line 61 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 3267, replacedImageUrl, 3267, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3285, 157, true);
            WriteLiteral(" class=\"rounded-3 w-100\" alt=\"image\">\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 65 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                        }

#line default
#line hidden
#line 65 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                         
                    }

#line default
#line hidden
#line 66 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(3511, 113, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body d-flex p-0 mt-3 justify-content-between\">\r\n");
            EndContext();
#line 73 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Likes != null)
            {
                int likeCount = Model.Likes.Length;

                

#line default
#line hidden
#line 77 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 if (Model.Liked)
                {

#line default
#line hidden
            BeginContext(3787, 249, true);
            WriteLiteral("                    <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                        <i class=\"feather-heart text-white bg-red-gradiant me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4037, 8, false);
#line 80 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                                                Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4045, 70, true);
            WriteLiteral("\"></i>\r\n                        <span class=\"likeCount\" data-item-id=\"");
            EndContext();
            BeginContext(4116, 8, false);
#line 81 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4124, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4127, 9, false);
#line 81 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                    Write(likeCount);

#line default
#line hidden
            EndContext();
            BeginContext(4136, 40, true);
            WriteLiteral(" Like</span>\r\n                    </a>\r\n");
            EndContext();
#line 83 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4236, 222, true);
            WriteLiteral("                    <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                        <i class=\"feather-heart me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4459, 8, false);
#line 87 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4467, 70, true);
            WriteLiteral("\"></i>\r\n                        <span class=\"likeCount\" data-item-id=\"");
            EndContext();
            BeginContext(4538, 8, false);
#line 88 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4546, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(4549, 9, false);
#line 88 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                    Write(likeCount);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 40, true);
            WriteLiteral(" Like</span>\r\n                    </a>\r\n");
            EndContext();
#line 90 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
#line 90 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 

            }
            else
            {

#line default
#line hidden
            BeginContext(4667, 214, true);
            WriteLiteral("                <a href=\"#\" class=\"emoji-bttn d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss me-2\">\r\n                    <i class=\"feather-heart me-2 btn-round-xs font-xss\" data-item-id=\"");
            EndContext();
            BeginContext(4882, 8, false);
#line 96 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                                                 Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4890, 71, true);
            WriteLiteral("\"></i>\r\n                    <span>0 Like</span>\r\n                </a>\r\n");
            EndContext();
#line 99 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }

#line default
#line hidden
#line 100 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Comments != null)
            {
                int cmtCount = Model.Comments.Length;

#line default
#line hidden
            BeginContext(5088, 243, true);
            WriteLiteral("                <a href=\"#\" class=\"d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss\">\r\n                    <i class=\"feather-message-circle text-dark text-grey-900 btn-round-sm font-lg\"></i>\r\n                    <span>");
            EndContext();
            BeginContext(5332, 8, false);
#line 105 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                     Write(cmtCount);

#line default
#line hidden
            EndContext();
            BeginContext(5340, 40, true);
            WriteLiteral(" Comments</span>\r\n                </a>\r\n");
            EndContext();
#line 107 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(5428, 283, true);
            WriteLiteral(@"                <a href=""#"" class=""d-flex align-items-center fw-600 text-grey-900 text-dark lh-26 font-xssss"">
                    <i class=""feather-message-circle text-dark text-grey-900 btn-round-sm font-lg""></i>
                    <span>0 Comment</span>
                </a>
");
            EndContext();
#line 114 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(5726, 262, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<div class=""col-xl-5 col-xxl-4 col-lg-5 pe-0 ps-0"">
    <div class=""card w-100 d-block chat-body p-0 border-0 shadow-xss rounded-3 mb-3 position-relative"">
        <div class=""messages-content chat-wrapper scroll-bar p-3"">
");
            EndContext();
#line 121 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
             if (Model.Comments != null)
            {
                

#line default
#line hidden
#line 123 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 foreach (var item in Model.Comments)
                {


#line default
#line hidden
            BeginContext(6121, 153, true);
            WriteLiteral("                    <div class=\"message-item\">\r\n                        <div class=\"message-user\">\r\n                            <figure class=\"avatar\">\r\n");
            EndContext();
#line 129 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                 if (!string.IsNullOrEmpty(item.UserAvatar))
                                {
                                    var replacedImageUrl = item.UserAvatar.Replace("http://10.0.2.2:3000", "http://localhost:3000");

#line default
#line hidden
            BeginContext(6521, 40, true);
            WriteLiteral("                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6561, "\"", 6584, 1);
#line 132 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
WriteAttributeValue("", 6567, replacedImageUrl, 6567, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6585, 15, true);
            WriteLiteral(" alt=\"image\">\r\n");
            EndContext();
#line 133 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"

                                }

#line default
#line hidden
            BeginContext(6637, 134, true);
            WriteLiteral("                            </figure>\r\n                            <div>\r\n                                <h5 class=\"font-xssss mt-2\">");
            EndContext();
            BeginContext(6772, 13, false);
#line 137 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                       Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6785, 95, true);
            WriteLiteral("</h5>\r\n                                <div class=\"time\">\r\n                                    ");
            EndContext();
            BeginContext(6881, 56, false);
#line 139 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                               Write(DateHelper.FormatTimeDifference(item.CmtDate.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(6937, 172, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"message-wrap shadow-none\">");
            EndContext();
            BeginContext(7110, 12, false);
#line 143 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                                                         Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(7122, 36, true);
            WriteLiteral("</div>\r\n                    </div>\r\n");
            EndContext();
#line 145 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                }

#line default
#line hidden
#line 145 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(7192, 24, true);
            WriteLiteral("        </div>\r\n        ");
            EndContext();
            BeginContext(7216, 495, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f34cb092cf6f817876c68920eb19f0992fb3ed27955", async() => {
                BeginContext(7370, 334, true);
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
#line 148 "C:\Users\Admin\New folder (2)\DoAn\DoAN_k4\DoAN_k4\Areas\SocialUser\Views\Home\GetPostDetail.cshtml"
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
            BeginContext(7711, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7751, 5924, true);
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
        ");
                WriteLiteral(@"        const hoursDifference = Math.floor(minutesDifference / 60);
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
                        conten");
                WriteLiteral(@"t: comment,
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
                WriteLiteral(@"               '<div>' +
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
