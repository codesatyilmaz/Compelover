#pragma checksum "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7574f091fae25f64a22df4a868c2b84ebbe53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Member_UserProfile), @"mvc.1.0.view", @"/Areas/Member/Views/Member/UserProfile.cshtml")]
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
#line 1 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
using Compelover.Entities.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7574f091fae25f64a22df4a868c2b84ebbe53d", @"/Areas/Member/Views/Member/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44ae01019361e377f0244715cd5b6d7561d01a3", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Member_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-edit-input text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "tel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PasswordChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-block update-user-button mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
  
    Layout = "_MemberLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""myprofile-area"" class=""py-5"" style=""background-color: #fefefe;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""top-value"">
                    <h4 class=""text-dark font-weight-bold"" style=""font-family: 'Oswald', sans-serif;"">
                        ");
#nullable restore
#line 12 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                               Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </h4>\n                    <i class=\"fas fa-at text-dark mr-2\"></i>\n                    <small class=\"text-dark mr-2\">");
#nullable restore
#line 15 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                                             Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                    <br>\n");
#nullable restore
#line 17 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                     if (Model.City == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-times mr-3 text-danger\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\',serif;font-size: small;\">Şehir Belirtilmemiş.</span>\n");
#nullable restore
#line 21 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-map-marked-alt mr-2 text-danger\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\', serif;\">");
#nullable restore
#line 25 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                                                                            Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 26 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\n");
#nullable restore
#line 28 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                     if (Model.Gender == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-times mr-3 text-danger\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\',serif;font-size: small;\">Cinsiyet Belirtilmemiş.</span>\n");
#nullable restore
#line 32 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }

                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-venus-mars mr-2 text-warning\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\', serif;\">");
#nullable restore
#line 37 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                                                                            Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 38 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\n");
#nullable restore
#line 40 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                     if (Model.BirthDay == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-times mr-3 text-danger\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\',serif;font-size:small;\">Doğum Tarihi Belirtilmemiş.</span>\n");
#nullable restore
#line 44 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fas fa-birthday-cake mr-2 text-dark\"></i>\n                        <span style=\"font-family: \'IM Fell Double Pica\',serif;\">");
#nullable restore
#line 48 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                                                                           Write(Model.BirthDay?.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 49 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\n\n                    <i class=\"fas fa-hourglass-start mr-3 mt-1 text-info\"></i>\n                    <span style=\"font-family: \'IM Fell Double Pica\', serif;\">");
#nullable restore
#line 53 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                                                                        Write(Model.SystemRegistrationDate.Value.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                </div>\n            </div>\n            <div class=\"col-md-4\">\n");
#nullable restore
#line 58 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                 if (Model.Picture == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"UserPicture/notPhoto.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2753, "\"", 2759, 0);
            EndWriteAttribute();
            WriteLiteral(" title=\"Fotoğraf Yükleyiniz.\" class=\"mb-1\" style=\"border-radius: 50%;\" width=\"128\" height=\"128\">\n");
#nullable restore
#line 61 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 2938, "\"", 2958, 1);
#nullable restore
#line 64 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
WriteAttributeValue("", 2944, Model.Picture, 2944, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2959, "\"", 2965, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2966, "\"", 3024, 4);
#nullable restore
#line 64 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
WriteAttributeValue("", 2974, Model.UserName, 2974, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2989, "Kullanıcısı\'nın", 2990, 16, true);
            WriteAttributeValue(" ", 3005, "Fotoğrafını", 3006, 12, true);
            WriteAttributeValue(" ", 3017, "Büyüt.", 3018, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-1\" data-toggle=\"modal\" data-target=\".img-area-large\" style=\"border-radius: 50%;\" width=\"128\" height=\"128\">\n");
#nullable restore
#line 65 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\n");
#nullable restore
#line 67 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                 if (User.Identity.Name == Model.UserName)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"profile-edit btn-sm\" data-toggle=\"modal\" data-target=\".bd-example-modal-lg\">Profili Düzenle</a>\n");
#nullable restore
#line 70 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"profile-edit btn-sm\">Takip Et</a>\n");
#nullable restore
#line 74 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n        </div>\n        <hr class=\"border-white\">\n    </div>\n</section>\n<section id=\"listOfMyBlog\" class=\"py-5\">\n");
            WriteLiteral("</section>\n\n");
            WriteLiteral(@"
<div class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            <section id=""userId"" class=""py-5"">
                <div class=""user-edit-top text-center"">
                    <h4 class=""text-dark"">Profil Düzenle</h4>
                    <hr class=""border-danger"">
                </div>
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""jumbotron"" style=""border-radius: 30px;"">
                                <div class=""jumbotron-body shadow"">
                                    <div class=""user-edit-form text-center"">

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7574f091fae25f64a22df4a868c2b84ebbe53d19164", async() => {
                WriteLiteral("\n                                            <div class=\"form-group\">\n                                                <i class=\"far fa-user mr-2 text-danger fa-2x\"></i> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d19594", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 110 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            </div>\n                                            <br>\n                                            <div class=\"form-group\">\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d21648", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 114 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<i class=""far fa-envelope-open ml-2 fa-2x text-danger""></i>
                                            </div>
                                            <br>
                                            <div class=""form-group"">
                                                <i class=""fas fa-user-circle mr-2 text-danger fa-2x""></i>
                                                <input type=""file"" class=""user-edit-input text-center"" name=""userPicture"">
                                            </div>
                                            <br>
                                            <div class=""form-group"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d24165", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 123 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<i class=""fas fa-mobile text-danger ml-2 fa-2x""></i>
                                            </div>
                                            <br>
                                            <div class=""form-group"">
                                                <i class=""fas fa-map-pin mr-2 fa-2x text-danger""></i> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d26329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 127 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.City);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            </div>\n                                            <br>\n                                            <div class=\"form-group\">\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d28379", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 131 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.BirthDay);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"<i class=""fas fa-birthday-cake ml-2 fa-2x text-danger""></i>
                                            </div>
                                            <br>
                                            <div class=""form-group"">
                                                <i class=""fas fa-venus-mars mr-2 fa-2x text-danger""></i> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a7574f091fae25f64a22df4a868c2b84ebbe53d30550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 135 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Gender);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                            <br>
                                            <div class=""change-user-button"">
                                                <input type=""submit"" class=""btn btn-outline-secondary btn-block update-user-button"" value=""Bilgilerini Kaydet"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a7574f091fae25f64a22df4a868c2b84ebbe53d32773", async() => {
                    WriteLiteral("Şifreni Değiştir");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            </div>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div class=""modal fade img-area-large"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">

        <div class=""modal-content"">
            <div class=""content text-center"">
                <img");
            BeginWriteAttribute("src", " src=\"", 8538, "\"", 8558, 1);
#nullable restore
#line 163 "D:\Asp.netCoreMVC\Compelover-main\Compelover-main\Compelover\Compelover.WEBUI\Areas\Member\Views\Member\UserProfile.cshtml"
WriteAttributeValue("", 8544, Model.Picture, 8544, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid text-center\" width=\"450\" height=\"450\"");
            BeginWriteAttribute("alt", " alt=\"", 8614, "\"", 8620, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n            </div>\n        </div>\n\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591