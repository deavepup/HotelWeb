#pragma checksum "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d9c0c11d851893b743ac9387880e3d68b67e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d9c0c11d851893b743ac9387880e3d68b67e75", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c4b899c8a65faa7366d5ebea9683dddb5a841c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Setting>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer style=""margin-top: 200px;"" class=""container-fluid bg-grey py-3 text-light"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""row"">
                        <div class=""col-md-6 "">
                            <div class=""logo-part"">
");
#nullable restore
#line 9 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2>");
#nullable restore
#line 11 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                   Write(item.SiteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                                    <p>");
#nullable restore
#line 12 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                  Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 13 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\n                        </div>\n                        <div class=\"col-md-6 px-4\">\n                            <h6>HAKKIMIZDA</h6>\n                            <p>");
#nullable restore
#line 18 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                foreach (var item in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                           Write(item.AboutUs);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                             
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""row"">
                        <div class=""col-md-6 px-4"">
                            <h6>SOSYAL MEDYA</h6>
                            <div class=""social"">
                                <div class=""addthis_inline_follow_toolbox""></div>
                            </div>
                        </div>
                        <div class=""col-md-6 px-4"">
                            <h6>KONUM</h6>
                            <iframe");
            BeginWriteAttribute("src", " src=\"", 1549, "\"", 1719, 2);
            WriteAttributeValue("", 1555, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 35 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                          foreach (var item in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                           Write(item.Location);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                              
                            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1555, 136, false);
            WriteAttributeValue("                            ", 1691, "", 1719, 28, true);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"200\" style=\"border:0;\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1763, "\"", 1781, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\n\n                        </div>\n                    </div>\n\n                </div>\n\n            </div>\n\n        </div>\n        <p class=\" text-center\">Tüm hakları saklıdır © ");
#nullable restore
#line 49 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                                                        foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
       Write(item.SiteName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
                          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" | 2020-");
#nullable restore
#line 52 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Shared\Components\Footer\Default.cshtml"
            Write(DateTime.Today.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Setting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
