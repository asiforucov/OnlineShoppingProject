<<<<<<< HEAD
#pragma checksum "C:\Users\asifr\Source\Repos\OnlineShoppingProject\LifeStyle\Views\My_User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2284b102717ee72719adeb02904073d9a1e324fc"
=======
#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a030f3e7654545084133fd94eaa4ffc3e1b71dbc"
>>>>>>> 3c19e7b4e4aeda33952e9a8cf0f8c98357821858
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
#line 1 "C:\Users\asifr\Source\Repos\OnlineShoppingProject\LifeStyle\Views\_ViewImports.cshtml"
using LifeStyle;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a030f3e7654545084133fd94eaa4ffc3e1b71dbc", @"/Views/My_User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fcd6937906b6e8603c49a09c10df1711a7bfab", @"/Views/_ViewImports.cshtml")]
    public class Views_My_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.ViewModels.My_User.My_UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product_detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("check-btn sqr-btn "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\asifr\Source\Repos\OnlineShoppingProject\LifeStyle\Views\My_User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

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
            BeginWriteAttribute("class", " class=\"", 573, "\"", 581, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"><i class=\"fa fa-dashboard\"></i>Əsas səhifə</a>\r\n                            <a href=\"#orders\" data-toggle=\"tab\"");
            BeginWriteAttribute("class", " class=\"", 712, "\"", 720, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-cart-arrow-down""></i> Sifarişlər</a>
                            <a href=""#payment-method"" data-toggle=""tab""><i class=""fa fa-credit-card""></i>Ödəmə metodu</a>
                            <a href=""#address-edit"" data-toggle=""tab"" class=""active""><i class=""fa fa-map-marker""></i>Əlaqə</a>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a030f3e7654545084133fd94eaa4ffc3e1b71dbc6576", async() => {
                WriteLiteral("<i class=\"fa fa-sign-out\"></i>Hesabdan çıxış");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                    <!-- My Account Tab Menu End -->
                    <!-- My Account Tab Content Start -->
                    <div class=""col-lg-9 col-md-8"">
                        <div class=""tab-content"" id=""myaccountContent"">
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""dashboad"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Əsas səhifə</h3>
                                    <div class=""welcome"">
                                        <p>Xoş gördük, <strong>");
#nullable restore
#line 32 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                          Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></p>
                                    </div>

                                    <p class=""mb-0"">Hesabınızın idarə panelindən siz asanlıqla son sifarişlərinizi yoxlaya və baxa bilərsiniz</p>
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
                                            ");
            WriteLiteral(@"        <th>Məhsulun adı</th>
                                                    <th>Məhsulun qiyməti</th>
                                                    
                                                    <th></th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 55 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                 foreach (var item in Model.ProductOperations.Where(p => p.Ordered == true))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 58 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                        <td>");
#nullable restore
#line 60 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                        <td>");
#nullable restore
#line 62 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                       Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼</td>\r\n                                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a030f3e7654545084133fd94eaa4ffc3e1b71dbc11968", async() => {
                WriteLiteral("Məhsula bax");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                                                                                    WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                                    count++;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                            <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
                                <div class=""myaccount-content"">
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
                 ");
            WriteLiteral("                       <p>Email: ");
#nullable restore
#line 85 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Telefon: ");
#nullable restore
#line 86 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\My_User\Index.cshtml"
                                               Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </address>
                                </div>
                            </div>
                            <!-- Single Tab Content End -->
                            <!-- Single Tab Content Start -->
                            <div class=""tab-pane fade"" id=""account-info"" role=""tabpanel"">
                                <div class=""myaccount-content"">
                                    <h3>Account Details</h3>
                                    <div class=""account-details-form"">
                                        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2284b102717ee72719adeb02904073d9a1e324fc10790", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a030f3e7654545084133fd94eaa4ffc3e1b71dbc17133", async() => {
>>>>>>> 3c19e7b4e4aeda33952e9a8cf0f8c98357821858
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.ViewModels.My_User.My_UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
