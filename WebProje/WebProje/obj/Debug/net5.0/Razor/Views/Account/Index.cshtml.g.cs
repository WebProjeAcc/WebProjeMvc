#pragma checksum "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040836f24690e5ff8fff08bb522e38511a83e004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040836f24690e5ff8fff08bb522e38511a83e004", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a349376d374f6e20f19eaf96ec78fb6dfb94a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProje.Models.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tm-signup-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg02"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
  

    Users user;
    user = ViewBag.user;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040836f24690e5ff8fff08bb522e38511a83e0045184", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row tm-content-row tm-mt-big\">\r\n");
#nullable restore
#line 15 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
             if (User.IsInRole("Admin"))
            {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""tm-col tm-col-big"">

                    <div class=""bg-white tm-block p-3"" style=""border-radius:0"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <h2 class=""tm-block-title d-inline-block"">");
#nullable restore
#line 26 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                                                     Write(lang["Accounts"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                            </div>\r\n                        </div>\r\n                        <ol class=\"tm-list-group tm-list-group-alternate-color tm-list-group-pad-big\">\r\n");
#nullable restore
#line 30 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"tm-list-group-item\">\r\n                                    ");
#nullable restore
#line 33 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 35 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                        </ol>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 42 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"tm-col tm-col-big\">\r\n            <div class=\"bg-white tm-block p-3 \" style=\"border-radius:0\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <h2 class=\"tm-block-title\">");
#nullable restore
#line 50 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                              Write(lang["Edit Account"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040836f24690e5ff8fff08bb522e38511a83e0049164", async() => {
                    WriteLiteral("\r\n                            <div class=\"form-group\">  <input type=\"hidden\" id=\"FormStatus\"");
                    BeginWriteAttribute("value", " value=\"", 1890, "\"", 1906, 1);
#nullable restore
#line 56 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 1898, user.Id, 1898, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\"> </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label for=\"Name\">");
#nullable restore
#line 59 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                             Write(lang["Name"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                <input");
                    BeginWriteAttribute("placeholder", " placeholder=", 2105, "", 2128, 1);
#nullable restore
#line 60 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2118, user.Name, 2118, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"Name\" name=\"Name\"");
                    BeginWriteAttribute("value", " value=", 2150, "", 2167, 1);
#nullable restore
#line 60 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2157, user.Name, 2157, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"text\" class=\"form-control validate\">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"LastName\">");
#nullable restore
#line 63 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                                 Write(lang["LastName"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                <input");
                    BeginWriteAttribute("placeholder", " placeholder=", 2421, "", 2448, 1);
#nullable restore
#line 64 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2434, user.LastName, 2434, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"LastName\" name=\"LastName\"");
                    BeginWriteAttribute("value", " value=", 2478, "", 2499, 1);
#nullable restore
#line 64 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2485, user.LastName, 2485, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"text\" class=\"form-control validate\">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n\r\n\r\n                                <input");
                    BeginWriteAttribute("placeholder", " placeholder=", 2676, "", 2703, 1);
#nullable restore
#line 69 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2689, user.UserName, 2689, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"name\" name=\"name\"");
                    BeginWriteAttribute("value", " value=", 2725, "", 2746, 1);
#nullable restore
#line 69 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2732, user.UserName, 2732, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"hidden\" class=\"form-control validate\">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n\r\n\r\n                                <input");
                    BeginWriteAttribute("placeholder", " placeholder=", 2925, "", 2956, 1);
#nullable restore
#line 74 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2938, user.PasswordHash, 2938, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"name\" name=\"name\"");
                    BeginWriteAttribute("value", " value=", 2978, "", 3003, 1);
#nullable restore
#line 74 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 2985, user.PasswordHash, 2985, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"hidden\" class=\"form-control validate\">\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label for=\"phone\">");
#nullable restore
#line 78 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                              Write(lang["Phone Number"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                                <input");
                    BeginWriteAttribute("placeholder", " placeholder=", 3262, "", 3286, 1);
#nullable restore
#line 79 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 3275, user.Phone, 3275, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"phone\" name=\"phone\"");
                    BeginWriteAttribute("value", " value=", 3310, "", 3328, 1);
#nullable restore
#line 79 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 3317, user.Phone, 3317, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" type=\"tel\" class=\"form-control validate\">\r\n                            </div>\r\n                            <div class=\"row mb-3\">\r\n                                <div class=\"col-12 col-sm-4\">\r\n                                    <a");
                    BeginWriteAttribute("href", " href=\"", 3561, "\"", 3592, 2);
                    WriteAttributeValue("", 3568, "/Account/Delete/", 3568, 16, true);
#nullable restore
#line 83 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
WriteAttributeValue("", 3584, user.Id, 3584, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"btn btn-danger mb-3\">\r\n                                        ");
#nullable restore
#line 84 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                   Write(lang["Delete Account"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </a>\r\n                                    <button type=\"submit\" value=\"Save\" class=\"btn btn-primary\">\r\n                                        ");
#nullable restore
#line 87 "B:\bil müh b grubu döküman\3. Sınıf\1. Dönem\Web\WebProjeMvc\WebProje\WebProje\Views\Account\Index.cshtml"
                                   Write(lang["Update"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </button>\r\n                                </div>\r\n");
                    WriteLiteral("                            </div>\r\n\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Users> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Users> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<lang> lang { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProje.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
