#pragma checksum "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "332b9fc8aa4920bd16a24f77f1c6565bdc2a3df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Rooms), @"mvc.1.0.view", @"/Views/Home/Rooms.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"332b9fc8aa4920bd16a24f77f1c6565bdc2a3df4", @"/Views/Home/Rooms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c4b899c8a65faa7366d5ebea9683dddb5a841c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Rooms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/RoomDetails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
  
    ViewData["Rooms"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Odalarımız";
    ViewData["Dark"] = "text-dark";
    ViewData["Info"] = "text-info";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""odafiyatlari mx-auto"">
    <div class=""odaimg"">
        <div class=""container"">
            <h1 style=""margin-top: 200px; margin-bottom: 200px;font-family: 'Playfair Display', serif;"" class=""text-center text-dark "">ODALARIMIZ</h1>
            <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                 foreach (var item in Model.rooms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xl-4 py-4\">\n                        <div style=\"border-radius: 10px;width: 18rem;\" class=\"card mx-auto\">\n                            <img class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=\"", 778, "\"", 816, 2);
            WriteAttributeValue("", 784, "/Home/RetrieveImage/", 784, 20, true);
#nullable restore
#line 19 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
WriteAttributeValue("", 804, item.RoomId, 804, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Room Image\">\n                            <div class=\"card-body\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332b9fc8aa4920bd16a24f77f1c6565bdc2a3df45403", async() => {
                WriteLiteral("\n                                    <input");
                BeginWriteAttribute("value", " value=\"", 1009, "\"", 1029, 1);
#nullable restore
#line 22 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
WriteAttributeValue("", 1017, item.RoomId, 1017, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"roomID\" class=\"form-control\" type=\"text\" style=\"display:none;\" />\n                                    <h6 class=\"card-text status\">Durum:");
#nullable restore
#line 23 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                                  Write(item.Status.RoomStatusName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6><br>\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                      Write(item.OtherType.OtherTypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                    <h6 class=\"card-title\">Oda Tipi:");
#nullable restore
#line 25 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                               Write(item.RoomType.RoomTypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                                    <h6 class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                     Write(item.OtherType.BasePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("₺ / Gecelik</h6><br>\n                                    <h6 class=\"card-text\">Kapasite: ");
#nullable restore
#line 27 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                               Write(item.OtherType.Capacity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6><br>\n                                    <h6 class=\"card-text\">Yatak: ");
#nullable restore
#line 28 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                            Write(item.OtherType.BedType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6><br>\n                                    <h6 class=\"card-text\">Servis: ");
#nullable restore
#line 29 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                                                             Write(item.OtherType.Services);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6><br>\n\n\n                                    <button type=\"submit\" class=\"btn btn-info\">Odayı Seç</button>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n\n\n                        </div>\n\n\n                    </div>\n");
#nullable restore
#line 41 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Views\Home\Rooms.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n<!--ODA BİTİŞ-->");
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
