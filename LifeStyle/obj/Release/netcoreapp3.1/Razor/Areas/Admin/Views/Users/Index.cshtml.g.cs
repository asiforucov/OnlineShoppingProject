#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac530e15bd9dece96f2e7546d5c0c5d283e96ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac530e15bd9dece96f2e7546d5c0c5d283e96ca", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b795336a130b780a97e73202b08b246735e162d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.ViewModels.User.UsersVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div style=""padding-top: 10%"" class="" container"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">№</th>
                    <th scope=""col"">Ad Soyad</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Telefon</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
                 foreach (var user in Model.ApplicationUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <th>");
#nullable restore
#line 24 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
                   Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"
                   Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Users\Index.cshtml"

                    count++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            </table>\r\n    </div>\r\n");
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.ViewModels.User.UsersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
