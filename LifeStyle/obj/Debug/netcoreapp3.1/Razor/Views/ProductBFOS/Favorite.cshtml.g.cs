#pragma checksum "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f359f11ae3d42fcd0f6fd7f0f7619ef711cec868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductBFOS_Favorite), @"mvc.1.0.view", @"/Views/ProductBFOS/Favorite.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f359f11ae3d42fcd0f6fd7f0f7619ef711cec868", @"/Views/ProductBFOS/Favorite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44fcd6937906b6e8603c49a09c10df1711a7bfab", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductBFOS_Favorite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.ViewModels.ProductBFOS.FavoriteVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cart-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
  
    ViewData["Title"] = "Favorite";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- -----Favorite TABLE----- -->
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
                                <th class=""row-title""><p>Sil</p></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 24 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
                            foreach (var item in Model.ProductOperations)
                           {
                               var product = Model.Products.Where(p => p.Id == item.ProductId).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"row-2\">\r\n                                <td class=\"row-close close-1\"></td>\r\n                                <td class=\"row-close close-1\">");
#nullable restore
#line 29 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
                                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"row-img\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f359f11ae3d42fcd0f6fd7f0f7619ef711cec8685690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1439, "~/assets/image/", 1439, 15, true);
#nullable restore
#line 30 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
AddHtmlAttributeValue("", 1454, Model.ProductImages.Where(p => p.ProductId == product.Id && p.IsMain == true).FirstOrDefault().Image, 1454, 101, false);

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
#line 31 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
                                                                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                <td class=\"product-price\" data-title=\"Price\">\r\n                                    <p>$ ");
#nullable restore
#line 33 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </td>\r\n                                <td class=\"row-close close-2\" data-title=\"product-remove\"><a href=\"#\"><i class=\"bi bi-x-circle\"></i></a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\asifr\source\repos\LifeStyle\LifeStyle\Views\ProductBFOS\Favorite.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan=""12"">
                                    <ul class=""table-btn"">
                                        <li><a href=""Category-Product.html"" class=""btn btn-secondary""><i class=""fa fa-chevron-left""></i>Alışverişə keç</a></li>
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
<!-- -----Favorite TABLE----- -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.ViewModels.ProductBFOS.FavoriteVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
