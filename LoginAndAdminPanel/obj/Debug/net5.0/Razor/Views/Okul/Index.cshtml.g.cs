#pragma checksum "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d49a52a526ff298366ab39621afa2b23d4f5a04f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Okul_Index), @"mvc.1.0.view", @"/Views/Okul/Index.cshtml")]
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
#line 1 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49a52a526ff298366ab39621afa2b23d4f5a04f", @"/Views/Okul/Index.cshtml")]
    public class Views_Okul_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<LoginAndAdminPanel.Models.Okul>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
  
    ViewBag.Title = "Okul";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Created Date</th>
            <th scope=""col"">IsActive</th>
            <th scope=""col"">İsim</th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
          int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
         foreach (var okul in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
           Write(okul.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
           Write(okul.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
           Write(okul.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><button type=\"button\" class=\"btn btn-primary\">Details</button></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 895, 2);
            WriteAttributeValue("", 874, "/Okul/Update/", 874, 13, true);
#nullable restore
#line 34 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
WriteAttributeValue("", 887, okul.Id, 887, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 970, "\"", 998, 2);
            WriteAttributeValue("", 977, "/Okul/Delete/", 977, 13, true);
#nullable restore
#line 35 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
WriteAttributeValue("", 990, okul.Id, 990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Okul\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Okul Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<LoginAndAdminPanel.Models.Okul>> Html { get; private set; }
    }
}
#pragma warning restore 1591