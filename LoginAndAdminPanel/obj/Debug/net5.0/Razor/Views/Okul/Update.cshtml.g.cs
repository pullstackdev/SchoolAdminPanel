#pragma checksum "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ec71dc256207d6af1a2f416ca6c425e519a3af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Okul_Update), @"mvc.1.0.view", @"/Views/Okul/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ec71dc256207d6af1a2f416ca6c425e519a3af", @"/Views/Okul/Update.cshtml")]
    public class Views_Okul_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginAndAdminPanel.Models.Okul>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Okul Güncelle</h1>\r\n\r\n<form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 175, "\"", 206, 2);
            WriteAttributeValue("", 184, "/Okul/Update/", 184, 13, true);
#nullable restore
#line 9 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Update.cshtml"
WriteAttributeValue("", 197, Model.Id, 197, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputEmail1\">İsim</label>\r\n        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 341, "\"", 360, 1);
#nullable restore
#line 12 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Update.cshtml"
WriteAttributeValue("", 349, Model.Isim, 349, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Isim\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"Okul İsmi\">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"exampleInputPassword1\">Kurucu</label>\r\n        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 601, "\"", 627, 1);
#nullable restore
#line 16 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Update.cshtml"
WriteAttributeValue("", 609, Model.Kurucu.Isim, 609, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"exampleInputPassword1\" disabled placeholder=\"Kurucu\">\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginAndAdminPanel.Models.Okul> Html { get; private set; }
    }
}
#pragma warning restore 1591