#pragma checksum "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04964ec94f94b4de1f97423a8a8a132148b20a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_addRoom), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/addRoom.cshtml")]
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
#line 1 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04964ec94f94b4de1f97423a8a8a132148b20a6", @"/Areas/Admin/Views/Admin/addRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c4b899c8a65faa7366d5ebea9683dddb5a841c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Admin_addRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("roomTypeName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("roomTypeName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("roomStatusName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("roomStatusName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addRoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
  
    ViewData["Title"] = "addRoom";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex flex-column"" id=""content-wrapper"">
    <div id=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col"">
                    <div>
                        <div class=""container-fluid"">
                            <h1>Oda Ekleme</h1>
                            <hr>
                           
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04964ec94f94b4de1f97423a8a8a132148b20a65997", async() => {
                WriteLiteral(@"
                                    <div class=""form-row"">
                                        <div class=""col-md-6"">
                                            <div id=""successfail""></div>
                                        </div>
                                    </div>
                                    <div class=""form-row"">
                                        <div class=""col-12 col-md-6"" id=""message"">
                                            <div class=""form-group"">
                                                <label for=""from-name"">Oda Odı</label><span class=""required-input"">*</span>
                                                <div class=""input-group"">
                                                    <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-home""></i></span></div><input class=""form-control"" type=""text"" id=""roomName"" name=""roomName""");
                BeginWriteAttribute("required", " required=\"", 1478, "\"", 1489, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Oda Adı"">
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""from-email"">Oda Tipi</label><span class=""required-input"">*</span>
                                                <div class=""input-group"">
                                                    <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-map-pin""></i></span></div><select id=""roomTypeName"" name=""roomTypeName"" class=""form-control"">
                                                        <optgroup>
");
#nullable restore
#line 36 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                             foreach (var type in Model.roomtype)
                                                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04964ec94f94b4de1f97423a8a8a132148b20a68517", async() => {
#nullable restore
#line 39 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                                                                                  Write(type.RoomTypeName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                                                         WriteLiteral(type.RoomTypeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 40 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                        </optgroup>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class=""form-row"">
                                                <div class=""col-12 col-sm-6 col-md-12 col-lg-6"">
                                                    <div class=""form-group"">
                                                        <label for=""from-phone"">Fiyat</label><span class=""required-input"">*</span>
                                                        <div class=""input-group"">
                                                            <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-bitcoin""></i></span></div><input class=""form-control"" type=""text"" id=""price"" name=""price""");
                BeginWriteAttribute("required", " required=\"", 3487, "\"", 3498, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Fiyat"">
                                                        </div>
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label for=""from-phone""><strong>Kapasite</strong><br></label><span class=""required-input"">*</span>
                                                        <div class=""input-group"">
                                                            <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-battery-half""></i></span></div><input class=""form-control"" type=""text"" id=""capacity"" name=""capacity""");
                BeginWriteAttribute("required", " required=\"", 4197, "\"", 4208, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Kapasite"">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""col-12 col-sm-6 col-md-12 col-lg-6"">
                                                    <div class=""form-group"">
                                                        <label for=""from-calltime"">Oda Durumu</label>
                                                        <div class=""input-group"">
                                                            <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-hourglass-start""></i></span></div><select class=""form-control"" id=""roomStatusName"" name=""roomStatusName"">
                                                                <optgroup>
");
#nullable restore
#line 66 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                     foreach (var st in Model.roomstatus)
                                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e04964ec94f94b4de1f97423a8a8a132148b20a614391", async() => {
#nullable restore
#line 68 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                                                                                              Write(st.RoomStatusName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                                                                     WriteLiteral(st.RoomStatusId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 69 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                </optgroup>
                                                            </select>
                                                        </div>
                                                    </div>
                                                    <div class=""form-group"">
                                                        <label for=""from-phone"">Yatak Tipi<br></label><span class=""required-input"">*</span>
                                                        <div class=""input-group"">
                                                            <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-bitcoin""></i></span></div><input  class=""form-control"" type=""text"" id=""bedType"" name=""bedType""");
                BeginWriteAttribute("required", " required=\"", 6312, "\"", 6323, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Yatak Tipi"">
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <div class=""form-row"">
                                                    <div class=""col"">
                                                        <div class=""form-group"">
                                                            <label for=""from-phone"">Servisler</label><span class=""required-input"">*</span>
                                                            <div class=""input-group"">
                                                                <div class=""input-group-prepend""><span class=""input-group-text""><i class=""fa fa-gears""></i></span></div><textarea name=""services"" id=""services"" class=""form-control""></textarea>
            ");
                WriteLiteral(@"                                                </div>
                                                        </div><button class=""btn btn-primary btn-block"" type=""submit"">Submit <i class=""fa fa-chevron-circle-right""></i></button>
                                                    </div>
                                                </div>
                                            </div>
                                            <hr class=""d-flex d-md-none"">
                                        </div>

                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\Hüseyin\Desktop\backup\HotelWeb\WebApplication3\Areas\Admin\Views\Admin\addRoom.cshtml"
AddHtmlAttributeValue("", 513, Url.Action("addRoom", "Admin"), 513, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            \n\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
