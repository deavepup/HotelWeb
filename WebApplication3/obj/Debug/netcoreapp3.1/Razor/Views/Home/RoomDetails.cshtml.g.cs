#pragma checksum "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31775b36e8639b6a7c61d7c8d3680617bbfa03d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RoomDetails), @"mvc.1.0.view", @"/Views/Home/RoomDetails.cshtml")]
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
#line 1 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31775b36e8639b6a7c61d7c8d3680617bbfa03d9", @"/Views/Home/RoomDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9fc078e8e0dde1fecbeb96bd5ee4f4087234453", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RoomDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("reservation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Reservation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
  
    ViewData["Title"] = "RoomDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Oda Detay";
    ViewData["Dark"] = "text-dark";
    ViewData["Info"] = "text-info";

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"1.kısım\">\r\n    <div style=\"margin-top: 100px;\" class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h2 class=\"baslik text-info\">");
#nullable restore
#line 16 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                                              foreach (var item in Model.rooms)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
               Write(item.OtherType.OtherTypeName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                                                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n            <div class=\"col-md-12\">\r\n                <h6 style=\"color:grey\" class=\"baslik  py-2\">");
#nullable restore
#line 22 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                                                             foreach (var item in Model.settings)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
               Write(item.SiteName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                                  
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i></h6>
            </div>
        </div>
    </div>
</div>
<div class=""2.kısım"">
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31775b36e8639b6a7c61d7c8d3680617bbfa03d96703", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"cold-md-8\">\r\n");
#nullable restore
#line 35 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                     foreach (var item in Model.rooms)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=\"", 1311, "\"", 1349, 2);
                WriteAttributeValue("", 1317, "/Home/RetrieveImage/", 1317, 20, true);
#nullable restore
#line 37 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
WriteAttributeValue("", 1337, item.RoomId, 1337, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"RoomImage\">\r\n                        <input style=\"display:none\"");
                BeginWriteAttribute("value", " value=\"", 1420, "\"", 1440, 1);
#nullable restore
#line 38 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
WriteAttributeValue("", 1428, item.RoomId, 1428, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"roomID\" id=\"roomID\" />\r\n");
#nullable restore
#line 39 "C:\Users\Hüseyin\Source\Repos\deavepup\HotelWeb\WebApplication3\Views\Home\RoomDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
                <div style=""background-color: #193441;"" class=""col-md-4"">
                    <div style=""font-family: 'Noto Sans JP', sans-serif;"" class=""tarih text-light"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-md-12 mx-auto"">
                                    <div class=""md-form py-2"">
                                        <label for=""inputMDEx"">GİRİŞ</label>

                                        <input type=""date"" id=""checkIn"" name=""checkIn"" class=""form-control"">

                                    </div>
                                </div>
                                <div class=""col-md-12 mx-auto"">
                                    <div class=""md-form py-2"">
                                        <label for=""inputMDEx"">ÇIKIŞ</label>
                                        <input type=""date"" id=""checkOUT"" name=""checkOUT"" class=""form-control"">
");
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-6 py-2 mx-auto"">
                                    <label for=""inputMDEx"">MİSAFİR</label>
                                    <input style=""border-radius:5px;"" type=""number"" value=""0"" id=""guest "" name=""guest"" min=""0"" max=""5"">
                                </div>
                                <div class=""blabla mx-auto py-4"">
                                    <button class=""btn btn-info btn-sm py-2"" type=""submit"">REZERVASYON YAP</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        <div class=""hizmetler"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h4 class=""baslik text-info my-5"">ODA SERVİSLERİMİZ</h4>
                    </div>
                    <div class=""col-md-4 "">
                        <div class=""box "">
                            <i class=""fas fa-map-marker""></i>
                            <h4>Gezi Planı</h4>
                            <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Illum ab nulla id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>
                    <div class=""col-md-4 "">
                        <div class=""box"">
                            <i class=""fas fa-utensils""></i>
                            <h4>Yemek Servisi</h4>
                            <p>Lorem");
            WriteLiteral(@" ipsum dolor sit amet consectetur, adipisicing elit. Illum ab nulla id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>
                    <div class=""col-md-4 "">
                        <div class=""box "">
                            <i class=""fas fa-bed""></i>
                            <h4>Bebek Yatağı</h4>
                            <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Illum ab nulla id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>
                    <div class=""col-md-4 my-5"">
                        <div class=""box "">
                            <i class=""fas fa-car""></i>
                            <h4>Araba Park</h4>
                            <p>Lorem ipsum dolor sit amet consectetur, adi");
            WriteLiteral(@"pisicing elit. Illum ab nulla id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>
                    <div class=""col-md-4  my-5"">
                        <div class=""box "">
                            <i class=""fas fa-toilet""></i>
                            <h4>Temizlik/Hijyen</h4>
                            <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Illum ab nulla id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>
                    <div class=""col-md-4  my-5"">
                        <div class=""box "">
                            <i class=""fas fa-cocktail""></i>
                            <h4>Bar</h4>
                            <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Illum ab null");
            WriteLiteral(@"a id, accusamus quidem alias ut voluptates beatae molestias, officiis sit obcaecati culpa ea commodi cum et quia omnis incidunt!</p>
                        </div>
                    </div>

                </div>
            </div>

        </div>
        <hr>
<script>
    window.onload = function () {

        document.getElementById('checkIn').valueAsDate = new Date();
        var a = new Date();
        a.setDate(a.getDate() + 1)
        document.getElementById('checkOUT').valueAsDate = a;
    };
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
