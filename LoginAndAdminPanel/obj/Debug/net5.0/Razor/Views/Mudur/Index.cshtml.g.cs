#pragma checksum "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f58c9ef7dbefe4235e9e46560371a37f179638b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mudur_Index), @"mvc.1.0.view", @"/Views/Mudur/Index.cshtml")]
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
#line 1 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f58c9ef7dbefe4235e9e46560371a37f179638b", @"/Views/Mudur/Index.cshtml")]
    public class Views_Mudur_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<LoginAndAdminPanel.Models.Mudur>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
  
    ViewBag.Title = "Müdür";
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
            <th scope=""col"">Okul</th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
          int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
         foreach (var mudur in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
           Write(mudur.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
           Write(mudur.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
           Write(mudur.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
           Write(mudur.Okul.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><button type=\"button\" class=\"btn btn-primary\">Details</button></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 949, "\"", 979, 2);
            WriteAttributeValue("", 956, "/Mudur/Update/", 956, 14, true);
#nullable restore
#line 35 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
WriteAttributeValue("", 970, mudur.Id, 970, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1054, "\"", 1084, 2);
            WriteAttributeValue("", 1061, "/Mudur/Delete/", 1061, 14, true);
#nullable restore
#line 36 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
WriteAttributeValue("", 1075, mudur.Id, 1075, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger\">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Guest_F\Desktop\studies\Practices\LoginAndAdminPanel\LoginAndAdminPanel\Views\Mudur\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Müdür Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<LoginAndAdminPanel.Models.Mudur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
