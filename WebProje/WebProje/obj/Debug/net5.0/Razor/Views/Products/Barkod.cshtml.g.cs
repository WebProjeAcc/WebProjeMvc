#pragma checksum "C:\Users\Furkan\Documents\GitHub\WebProjeMvc\WebProje\WebProje\Views\Products\Barkod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30d73bee19d3a8b0e6f07b46f4bd843f289a2da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Barkod), @"mvc.1.0.view", @"/Views/Products/Barkod.cshtml")]
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
#line 1 "C:\Users\Furkan\Documents\GitHub\WebProjeMvc\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Furkan\Documents\GitHub\WebProjeMvc\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30d73bee19d3a8b0e6f07b46f4bd843f289a2da", @"/Views/Products/Barkod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Barkod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container-fluid "">
    <div class=""row justify-content-between"">
        <div class=""col-lg-6     col-sm-12 border-2 border border-primary"">

            <div class=""Barkod  row  border border-secondary mb-1"">

                <label>Barkod Kodu <input type=""text"" maxlength=""50""></label>
                <label>Ürün    <input type=""text"" maxlength=""50""></label>

            </div>
            <div class=""Deneme  row border-secondary"">
                <div class=""dropdown "">
                    <ul class=""dropdown-menu"" role=""menu"" aria-labelledby=""dropdownMenu1"">
                        <li role=""presentation""><a role=""menuitem"" tabindex=""-1"" href=""#"">test1</a></li>
                        <li role=""presentation""><a role=""menuitem"" tabindex=""-1"" href=""#"">test2</a></li>
                    </ul>
                    ");
#nullable restore
#line 20 "C:\Users\Furkan\Documents\GitHub\WebProjeMvc\WebProje\WebProje\Views\Products\Barkod.cshtml"
               Write(Html.DropDownListFor(x => x.ProductID, (List<SelectListItem>)ViewBag.v2, new { @class = "p-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n            <div class=\"row border-secondary\">\r\n                <div class=\"  mt-5\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1152, "\"", 1160, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <button type=\"button\" class=\"btn btn-primary btn-lg\">Ekle</button>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1308, "\"", 1316, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <button type=""button"" class=""btn btn-secondary btn-lg"">Sil</button>
                    </div>
                </div>

            </div>
        </div>
        <div class="" col-lg-6  col-sm-12 border border-secondary "">

            <div class=""container""> Deneme2</div>
        </div>


    </div>


</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
