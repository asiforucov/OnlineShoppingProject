#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4e8291c55a872b4334d103e73c286d94add7e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_detail_admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product_detail_admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4e8291c55a872b4334d103e73c286d94add7e5", @"/Areas/Admin/Views/Product_detail_admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b795336a130b780a97e73202b08b246735e162d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_detail_admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.ViewModels.ProductDetail.ProductDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-zoom-image", new global::Microsoft.AspNetCore.Html.HtmlString("image/product1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/product-logo/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 90px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("costomer-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product_detail_admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- -----PRODUCT DETAIL----- -->
<section class=""products-detail-section pt_large "" style=""padding-top: 10%"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""product-image"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad4e8291c55a872b4334d103e73c286d94add7e58380", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 401, "~/assets/image/", 401, 15, true);
#nullable restore
#line 12 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
AddHtmlAttributeValue("", 416, Model.product.ProductImages.Where(p=>p.IsMain == true).FirstOrDefault().Image, 416, 78, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                <div id=""pr_item_gallery"" class=""product_gallery_item owl-thumbs-slider owl-carousel owl-theme owl-loaded owl-drag"">


                    <div class=""owl-stage-outer"">
                        <div class=""owl-stage"" style=""transform: translate3d(0px, 0px, 0px); transition: all 0s ease 0s; width: 190px;"">
");
#nullable restore
#line 19 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                             foreach (var item in Model.product.ProductImages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""owl-item active"" style=""width: 85px; margin-right: 10px;"">
                                    <div class=""item"">
                                        <a href=""#"" class=""active"" data-image=""image/product1.png"" data-zoom-image=""image/product1.png"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad4e8291c55a872b4334d103e73c286d94add7e511156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1349, "~/assets/image/", 1349, 15, true);
#nullable restore
#line 24 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
AddHtmlAttributeValue("", 1364, item.Image, 1364, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 28 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div><div class=""owl-nav disabled""><button type=""button"" role=""presentation"" class=""owl-prev disabled""><i class=""ion-ios-arrow-back""></i></button><button type=""button"" role=""presentation"" class=""owl-next disabled""><i class=""ion-ios-arrow-forward""></i></button></div><div class=""owl-dots disabled""></div>
                </div>
            </div>
            <div class=""col-md-7"">
                <div class=""quickview-product-detail"">
                    <h2 class=""box-title"">");
#nullable restore
#line 35 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                     Write(Model.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3 class=\"box-price\">$ ");
#nullable restore
#line 36 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                       Write(Model.product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"box-text\">");
#nullable restore
#line 37 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                   Write(Model.product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"quantity-box\">\r\n                        <div class=\"count\">\r\n                            <p>Say:</p>\r\n                            <div class=\"input-group\" style=\"font-size: 20px\">\r\n                              ");
#nullable restore
#line 42 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                         Write(Model.product.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>
<!-- -----PRODUCT DETAIL----- -->
<!-- -----COMMENT OZELLIKLER----- -->
<section class=""products-detail-tabs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""products-tabs"">
                    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""discription-tab"" data-toggle=""tab"" href=""#discription"" role=""tab"" aria-controls=""discription"" aria-selected=""true"">məhsul haqqında</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""reviews-tab"" data-toggle=""tab"" href=""#reviews"" role=""tab"" aria-controls=""reviews"" aria-selected=""false"">şərhlər (");
#nullable restore
#line 64 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                                                                                                                Write(Model.Comments.Where(c => c.IsDelete == false).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a>
                        </li>
                    </ul>
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade tab-1 show active"" id=""discription"" role=""tabpanel"" aria-labelledby=""discription-tab"">
                            <div class=""tab-title"">
                                <h6>Məhsul haqqında</h6>
                            </div>
                            <div class=""tab-caption"">
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <tbody>
                                        <tr>
                                            <td colspan=""1"">Marka</td>
                                            <td>");
#nullable restore
#line 78 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                           Write(Model.product.ProductBrand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td colspan=\"1\">Rəng</td>\r\n                                            <td>");
#nullable restore
#line 82 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                           Write(Model.product.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td colspan=\"1\">Ölçü</td>\r\n                                            <td>");
#nullable restore
#line 86 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                           Write(Model.product.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <td colspan=\"1\">Kateqoriya</td>\r\n                                            <td>");
#nullable restore
#line 90 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                           Write(Model.product.GenderCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 90 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                               Write(Model.product.ProductCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade tab-2"" id=""ai"" role=""tabpanel"" aria-labelledby=""ai-tab"">

                        </div>
                        <div class=""tab-pane fade tab-3"" id=""reviews"" role=""tabpanel"" aria-labelledby=""reviews-tab"">
                            <div class=""tab-title"">
                                <h6>Şərhlər</h6>
                            </div>
                            <div class=""tab-caption"">
                                <div class=""costomer-reviews"">
");
#nullable restore
#line 106 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                     foreach (var comment in @Model.Comments)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"costomer-reviews-box\">\r\n                                            <div class=\"reviews-img\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad4e8291c55a872b4334d103e73c286d94add7e520918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            </div>\r\n                                            <div class=\"reviews-text\">\r\n                                                <p class=\"reviewer-name\">");
#nullable restore
#line 114 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                    Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <span class=\"reviews-date\">");
#nullable restore
#line 115 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                      Write(comment.CreateDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <p class=\"reviewer-text\">");
#nullable restore
#line 116 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                    Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4e8291c55a872b4334d103e73c286d94add7e523524", async() => {
                WriteLiteral("Şərhi sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                                                                                                                  WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 121 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Areas\Admin\Views\Product_detail_admin\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 7237, "\"", 7245, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align: center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4e8291c55a872b4334d103e73c286d94add7e526755", async() => {
                WriteLiteral("Geri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- -----COMMENT OZELLIKLER----- -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.ViewModels.ProductDetail.ProductDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591