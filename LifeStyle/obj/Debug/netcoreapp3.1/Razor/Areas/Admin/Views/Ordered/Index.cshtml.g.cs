#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d23735d47d1e2e9e3dcf9390bf541186d4a691c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Ordered_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Ordered/Index.cshtml")]
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
#line 1 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\_ViewImports.cshtml"
using LifeStyle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\_ViewImports.cshtml"
using Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\_ViewImports.cshtml"
using Core.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d23735d47d1e2e9e3dcf9390bf541186d4a691c", @"/Areas/Admin/Views/Ordered/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b795336a130b780a97e73202b08b246735e162d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Ordered_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""padding-top: 10%"" class="" "">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">№</th>
                <th scope=""col"">Ad</th>
                <th scope=""col"">Soyad</th>
                <th scope=""col"">Ölçü</th>
                <th scope=""col"">Rəng</th>
                <th scope=""col"">Telefon</th>
                <th scope=""col"">Adres</th>
                <th scope=""col"">Poçt</th>
                <th scope=""col"">Şəhər</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
             foreach (var o in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                   Write(o.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Ordered\Index.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
