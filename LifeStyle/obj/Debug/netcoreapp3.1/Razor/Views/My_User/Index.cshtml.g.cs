#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc08416fd19fb97fb62fca22a50130ea7cc06e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_User_Index), @"mvc.1.0.view", @"/Views/My_User/Index.cshtml")]
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
#line 1 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\_ViewImports.cshtml"
using LifeStyle;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc08416fd19fb97fb62fca22a50130ea7cc06e2", @"/Views/My_User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fcd6937906b6e8603c49a09c10df1711a7bfab", @"/Views/_ViewImports.cshtml")]
    public class Views_My_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""padding: 5% 0 5%"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <!-- My Account Page Start -->
            <div class=""myaccount-page-wrapper"">
                <!-- My Account Tab Menu Start -->
                <div class=""row"">
                    <div class=""col-lg-3 col-md-4"">
                        <div class=""myaccount-tab-menu nav"" role=""tablist"">
                            <a href=""#dashboad""");
            BeginWriteAttribute("class", " class=\"", 509, "\"", 517, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"><i class=\"fa fa-dashboard\"></i>Əsas səhifə</a>\r\n                            <a href=\"#orders\" data-toggle=\"tab\"");
            BeginWriteAttribute("class", " class=\"", 648, "\"", 656, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-cart-arrow-down""></i> Sifarişlər</a>
                            <a href=""#payment-method"" data-toggle=""tab""><i class=""fa fa-credit-card""></i>Ödəmə metodu</a>
                            <a href=""#address-edit"" data-toggle=""tab"" class=""active""><i class=""fa fa-map-marker""></i>Əlaqə</a>
                            <a href=""#account-info"" data-toggle=""tab""");
            BeginWriteAttribute("class", " class=\"", 1032, "\"", 1040, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-user""></i>Hesab</a>
                            <a href=""#""><i class=""fa fa-sign-out""></i>Hesabdan çıxış</a>
                        </div>
                    </div>
                    <!-- My Account Tab Menu End -->
                    <!-- My Account Tab Content Start -->
                    <div class=""col-lg-9 col-md-8"">
                        <div class=""tab-content"" id=""myaccountContent"">
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""dashboad"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Əsas səhifə</h3>
                                    <div class=""welcome"">
                                        <p>Xoş gördük, <strong>Asif Orucov</strong></p>
                                    </div>

                                    <p class=""mb-0"">Hesabınızın idarə panelindən siz asanlıqla son sifarişlərinizi yoxlaya və baxa");
            WriteLiteral(@" bilərsiniz</p>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Sifarişlər</h3>
                                    <div class=""myaccount-table table-responsive text-center"">
                                        <table class=""table table-bordered"">
                                            <thead class=""thead-light"">
                                                <tr>
                                                    <th>№</th>
                                                    <th>Tarix</th>
                                                    <th>Status</th>
                                                    <th>Qiymət</th>
                             ");
            WriteLiteral(@"                       <th>Məhsul</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Aug 22, 2018</td>
                                                    <td>Pending</td>
                                                    <td>$3000</td>
                                                    <td><a href=""#"" class=""check-btn sqr-btn "">View</a></td>
                                                </tr>
                                                <tr>
                                                    <td>2</td>
                                                    <td>July 22, 2018</td>
                                                    <td>Approved</td>
                                                    <td>$200<");
            WriteLiteral(@"/td>
                                                    <td><a href=""#"" class=""check-btn sqr-btn "">View</a></td>
                                                </tr>
                                                <tr>
                                                    <td>3</td>
                                                    <td>June 12, 2017</td>
                                                    <td>On Hold</td>
                                                    <td>$990</td>
                                                    <td><a href=""#"" class=""check-btn sqr-btn "">View</a></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                         
                            <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
             ");
            WriteLiteral(@"                   <div class=""myaccount-content"">
                                    <h3>Ödəmə metodu</h3>
                                    <p class=""saved-message"">Onlayn ödəmə metodu yaxında...</p>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade active show"" id=""address-edit"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Əlaqə</h3>
                                    <address>
                                        <p>Telefon: (123) 456-7890</p>
                                    </address>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <");
            WriteLiteral(@"div class=""tab-pane fade"" id=""account-info"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Account Details</h3>
                                    <div class=""account-details-form"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc08416fd19fb97fb62fca22a50130ea7cc06e210698", async() => {
                WriteLiteral(@"
                                            <div class=""row"">
                                                <div class=""col-lg-6"">
                                                    <div class=""single-input-item"">
                                                        <label for=""first-name"" class=""required"">First Name</label>
                                                        <input type=""text"" id=""first-name"">
                                                    </div>
                                                </div>
                                                <div class=""col-lg-6"">
                                                    <div class=""single-input-item"">
                                                        <label for=""last-name"" class=""required"">Last Name</label>
                                                        <input type=""text"" id=""last-name"">
                                                    </div>
                                                </di");
                WriteLiteral(@"v>
                                            </div>
                                            <div class=""single-input-item"">
                                                <label for=""display-name"" class=""required"">Display Name</label>
                                                <input type=""text"" id=""display-name"">
                                            </div>
                                            <div class=""single-input-item"">
                                                <label for=""email"" class=""required"">Email Addres</label>
                                                <input type=""email"" id=""email"">
                                            </div>
                                            <fieldset>
                                                <legend>Password change</legend>
                                                <div class=""single-input-item"">
                                                    <label for=""current-pwd"" class=""required"">Current Pa");
                WriteLiteral(@"ssword</label>
                                                    <input type=""password"" id=""current-pwd"">
                                                </div>
                                                <div class=""row"">
                                                    <div class=""col-lg-6"">
                                                        <div class=""single-input-item"">
                                                            <label for=""new-pwd"" class=""required"">New Password</label>
                                                            <input type=""password"" id=""new-pwd"">
                                                        </div>
                                                    </div>
                                                    <div class=""col-lg-6"">
                                                        <div class=""single-input-item"">
                                                            <label for=""confirm-pwd"" class=""required"">Confirm Password<");
                WriteLiteral(@"/label>
                                                            <input type=""password"" id=""confirm-pwd"">
                                                        </div>
                                                    </div>
                                                </div>
                                            </fieldset>
                                            <div class=""single-input-item"">
                                                <button class=""check-btn sqr-btn "">Save Changes</button>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                            </div> <!-- Single Tab Content End -->
                        </div>
                    </div> <!-- My Account Tab Content End -->
                </div>
            </div> <!-- My Account Page End -->
        </div>
    </div>
</div>");
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