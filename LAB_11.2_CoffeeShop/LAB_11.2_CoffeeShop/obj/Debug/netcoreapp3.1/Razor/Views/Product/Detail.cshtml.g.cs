#pragma checksum "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbdc21f34216915044dcac916c002f0acaca11cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\_ViewImports.cshtml"
using LAB_11._2_CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\_ViewImports.cshtml"
using LAB_11._2_CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbdc21f34216915044dcac916c002f0acaca11cf", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29712885550cc76deedb771dbfc067e84f7c5eb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
  
    Product prod = (Product)ViewData["Product"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div><a href=\"/Product\">Menu</a>/<a");
            BeginWriteAttribute("href", " href=\"", 94, "\"", 132, 2);
            WriteAttributeValue("", 101, "/Product/Cat?cat=", 101, 17, true);
#nullable restore
#line 5 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
WriteAttributeValue("", 118, prod.Category, 118, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 5 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
                                                                      Write(prod.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>/");
#nullable restore
#line 5 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
                                                                                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n<h1>");
#nullable restore
#line 6 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
Write(prod.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>______________________________________________________________________________________________________________________________________________________________________</p>\r\n<p>");
#nullable restore
#line 10 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
Write(prod.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\Detail.cshtml"
Write(prod.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
