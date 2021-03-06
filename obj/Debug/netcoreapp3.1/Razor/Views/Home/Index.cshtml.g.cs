#pragma checksum "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "056d1d2f94ef23ea7e936b04c1be92b49ba51be6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\CodeGym\C#\PXUProduct\Views\_ViewImports.cshtml"
using PXUProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CodeGym\C#\PXUProduct\Views\_ViewImports.cshtml"
using PXUProduct.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\CodeGym\C#\PXUProduct\Views\_ViewImports.cshtml"
using PXUProduct.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\CodeGym\C#\PXUProduct\Views\_ViewImports.cshtml"
using PXUProduct.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"056d1d2f94ef23ea7e936b04c1be92b49ba51be6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395f4bd0e533cfdf58ab6ba6ef8e59ad54c61b2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"text-center\">\r\n            <button class=\"btn btn-dark filter-product-btn\" data-filter=\"all\">All</button>\r\n");
#nullable restore
#line 6 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-dark filter-product-btn\" data-filter=\"");
#nullable restore
#line 8 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
                                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 8 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
                                                                                            Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 9 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"row mt-5\">\r\n");
#nullable restore
#line 13 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 523, "\"", 579, 4);
            WriteAttributeValue("", 531, "col-md-6", 531, 8, true);
            WriteAttributeValue(" ", 539, "pb-4", 540, 5, true);
            WriteAttributeValue(" ", 544, "filter", 545, 7, true);
#nullable restore
#line 15 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 551, item.Category.CategoryName, 552, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card bg-white rounded shadow-sm\">\r\n                        <div class=\"card-body row\">\r\n                            <div class=\"col-7\"><label>");
#nullable restore
#line 18 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                            <div class=\"col-5\"><label>");
#nullable restore
#line 19 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
                                                 Write(string.Format("{0:c0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                        </div>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 949, "\"", 993, 2);
#nullable restore
#line 21 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
WriteAttributeValue("", 955, CommonDefault.ImagePath, 955, 24, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
WriteAttributeValue("", 979, item.ImageUrl, 979, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" class=""card-img-top img-fluid d-block mx-auto mb-3"" />
                        <div class=""card-body row"">
                            <div class=""col-12"">
                                <span class=""badge w-100"" style=""background-color: lawngreen"">");
#nullable restore
#line 24 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
                                                                                         Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 29 "E:\CodeGym\C#\PXUProduct\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n");
            DefineSection("ScriptsValidate", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".filter-product-btn"").click(function () {
                let value = $(this).attr('data-filter');

                if (value == ""all"") {
                    $("".filter"").show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $("".filter"").filter('.' + value).show('3000');
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
