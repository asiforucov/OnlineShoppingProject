#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a8f2f6e1e2e93274bd6ea7614c5b0a794d6486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductBFOS_Basket), @"mvc.1.0.view", @"/Views/ProductBFOS/Basket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a8f2f6e1e2e93274bd6ea7614c5b0a794d6486", @"/Views/ProductBFOS/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fcd6937906b6e8603c49a09c10df1711a7bfab", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductBFOS_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.ViewModels.ProductBFOS.BasketVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cart-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductBFOS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletebasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- -----BASKET TABLE----- -->
<section class=""cart-section pt_large"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""cart-table table-responsive"">
                    <table class=""table table-bordered text-center"">
                        <thead>
                            <tr class=""row-1"">
                                <th class=""row-title""><p>#</p></th>
                                <th class=""row-title""><p>Məhsul</p></th>
                                <th class=""row-title""><p>Məhsulun adı</p></th>
                                <th class=""row-title""><p>Qiymət</p></th>
                                <th class=""row-title""><p>Say</p></th>
                                <th class=""row-title""><p>Cəmi</p></th>
                                <th class=""row-title""><p></p></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                         foreach (var item in Model.ProductOperations)
                        {
                            var product = Model.Products.Where(p => p.Id == item.ProductId).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"row-2\">\r\n                                <td class=\"row-close \">");
#nullable restore
#line 30 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                                  Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"row-img\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2a8f2f6e1e2e93274bd6ea7614c5b0a794d64867707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1488, "~/assets/image/", 1488, 15, true);
#nullable restore
#line 31 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
AddHtmlAttributeValue("", 1503, Model.ProductImages.Where(p => p.ProductId == product.Id && p.IsMain == true).FirstOrDefault().Image, 1503, 101, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td class=\"product-name\"><a href=\"#\" style=\"color: black;\">");
#nullable restore
#line 32 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                                                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td class=\"product-price\" data-title=\"Price\">\r\n                                    <p> ");
#nullable restore
#line 34 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                                <td class=\"product-price\" data-title=\"Price\">\r\n                                    <p> ");
#nullable restore
#line 37 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                   Write(product.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                                <td class=\"product-price\" data-title=\"Price\">\r\n                                    <p> ");
#nullable restore
#line 40 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                   Write(product.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                                <td class=\"row-close close-2\" data-title=\"product-remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a8f2f6e1e2e93274bd6ea7614c5b0a794d648611232", async() => {
                WriteLiteral("<i class=\"bi bi-x-circle\"></i>");
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
#line 42 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                                                                                                                                                      WriteLiteral(product.Id);

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
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Basket.cshtml"
                            count++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan=""12"">
                                    <ul class=""table-btn"">
                                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a8f2f6e1e2e93274bd6ea7614c5b0a794d648614288", async() => {
                WriteLiteral("<i class=\"fa fa-chevron-left\"></i>Alışverişə keç");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                    </ul>
                                </td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- -----BASKET TABLE----- -->
<!-- -----CARD TOTAL----- -->
<section class=""cart-box-section pb_large"">
    <div class=""container"">
        <div class=""row justify-content-between"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""cart-inner-box box-1 text-center"">
                    <div class=""ci-title"">
                        <h6>Promo kod</h6>
                    </div>
                    <div class=""ci-caption"">
                        <p>Promo kod daxil edərək endirim qazanın</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a8f2f6e1e2e93274bd6ea7614c5b0a794d648616615", async() => {
                WriteLiteral("\r\n                            <input");
                BeginWriteAttribute("required", " required=\"", 3854, "\"", 3865, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" type=\"text\" placeholder=\"Kod\">\r\n                            <button class=\"btn btn-secondary\" type=\"submit\">Daxil et</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""cart-inner-box box-2 text-center"">
                    <div class=""ci-title"">
                        <h6>Cəmi</h6>
                    </div>
                    <div class=""ci-caption"">
                        <ul>
                            <li>Məhsul dəyəri <span>$237.00</span></li>
                            <li>Ümumi <span>$237.00</span></li>

                        </ul>
                    </div>
                    <div class=""ci-btn"">
                        <a href=""checkout.html"" class=""btn btn-primary btn-block rounded-0"">Sifariş ver</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- -----CARD TOTAL----- -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.ViewModels.ProductBFOS.BasketVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
