#pragma checksum "C:\Users\beyza\Desktop\BirElinVerdigi\BirElinVerdigi.WebUl\Views\Home\Ilanlar2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b84e8a2ecaa46a4ac4d14f96f57ac80cf00ac4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ilanlar2), @"mvc.1.0.view", @"/Views/Home/Ilanlar2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Ilanlar2.cshtml", typeof(AspNetCore.Views_Home_Ilanlar2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b84e8a2ecaa46a4ac4d14f96f57ac80cf00ac4e", @"/Views/Home/Ilanlar2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ilanlar2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\beyza\Desktop\BirElinVerdigi\BirElinVerdigi.WebUl\Views\Home\Ilanlar2.cshtml"
  
    ViewData["Title"] = "Ilanlar2";

#line default
#line hidden
            BeginContext(46, 3266, true);
            WriteLiteral(@"




<div class=""container"">
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-4"">
                <ul class=""nav nav-sidebar"">
                    <li>
                        <div class=""sidebar_list"">
                            <p>Filter by Category</p>
                            <ul class=""list-unstyled"" id=""category"">
                                <li>
                                    <input id=""smart"" value=""smart"" type=""checkbox"">
                                    <span>Smart Devices</span>
                                </li>
                                <li>
                                    <input id=""mobiles"" value=""mobiles"" type=""checkbox"">
                                    <span>Mobiles</span>
                                </li>
                                <li>
                                    <input id=""accessories"" value=""accessories"" type=""checkbox"">
                                    <span>Accessories</span>
 ");
            WriteLiteral(@"                               </li>
                            </ul>
                        </div>
                    </li>
                    <li>
                        <div class=""sidebar_list"">
                            <p>Filter by Performance</p>
                            <ul class=""list-unstyled"" id=""performance"">
                                <li>
                                    <input id=""2gb"" value=""2gb"" type=""checkbox"">
                                    <span>2 GB</span>
                                </li>
                                <li>
                                    <input id=""3gb"" value=""3gb"" type=""checkbox"">
                                    <span>3 GB</span>
                                </li>
                                <li>
                                    <input id=""4gb"" value=""4gb"" type=""checkbox"">
                                    <span>4 GB</span>
                                </li>
                            </ul>
      ");
            WriteLiteral(@"                  </div>
                    </li>
                </ul>
            </div>
            <div class=""col-8"">
                <div class=""col-md-12 col-sm-12 col-xs-12 main"">
                    <div class=""pro_list col-md-12 col-sm-12 col-xs-12"" id=""product_list""></div>
                </div>
                <script id=""template"" type=""text/html"">
                    <div class=""col-md-3 col-sm-6 col-xs-6 product"">
                        <img src=""<%= image %>"" class=""img-responsive product-img"">
                        <span class=""product-name""><%= title %></span>
                        <div class=""product-price"">$<%= amount %></div>
                        <a href=""#"" title=""Add to Wish List""><span class=""glyphicon glyphicon-heart wish-list""></span></a>
                        <div class=""product-des"">
                            <p><%= description %></p>
                            <a class=""buy-now"" title=""<%= title %>"" href=""<%= permalink %>""> <span class=""glyphicon glyp");
            WriteLiteral("hicon-shopping-cart\"></span> Buy Now </a>\r\n                        </div>\r\n                    </div>\r\n                </script>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>");
            EndContext();
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
