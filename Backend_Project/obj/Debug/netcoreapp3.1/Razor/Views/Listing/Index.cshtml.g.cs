#pragma checksum "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e1daa785d3efbe2db35914b9ce900608d56c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listing_Index), @"mvc.1.0.view", @"/Views/Listing/Index.cshtml")]
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
#line 1 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\_ViewImports.cshtml"
using Backend_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\_ViewImports.cshtml"
using Backend_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\_ViewImports.cshtml"
using Backend_Project.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\_ViewImports.cshtml"
using Backend_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e1daa785d3efbe2db35914b9ce900608d56c3f", @"/Views/Listing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf0590a3647962861253c342f91d983130511b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Listing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmListing>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-wrapper\">\r\n    <!--Title Bar -->\r\n    <div id=\"titlebar\" class=\"gradient\"");
            BeginWriteAttribute("style", " style=\"", 151, "\"", 224, 4);
            WriteAttributeValue("", 159, "background:", 159, 11, true);
            WriteAttributeValue(" ", 170, "url(~/wwwroot/Uploads/", 171, 23, true);
#nullable restore
#line 8 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
WriteAttributeValue("", 193, Model.Setting.BannerImageName, 193, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 223, ")", 223, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""title-bar-inner"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h2>List Full Width</h2>
                        <span>Explore New Places</span>
                        <!-- Breadcrumbs -->
                        <nav id=""breadcrumbs"">
                            <ul>
                                <li><a>Home</a></li>
                                <li>Listings</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
        <div class=""title-overlay""></div>
    </div>
    <!-- Content -->
    <div class=""content"">
        <div class=""container"">
            <div class=""row"">
                <!-- Search -->
                <div class=""col-md-12 grid-full-width page-search mb-3"">
                    <div class=""main-search-input mt-0"">
                        <div class=""c");
            WriteLiteral(@"ol-lg-3 col-sm-6"">
                            <div class=""form-group"">
                                <input type=""text"" placeholder=""What are you looking for?"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-lg-3 col-sm-6"">
                            <div class=""form-group"">
                                <input type=""text"" placeholder=""Location"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-lg-3 col-sm-6"">
                            <select class=""custom-select my-1 mr-sm-2 new-select"" id=""inlineFormCustomSelectPref"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e1daa785d3efbe2db35914b9ce900608d56c3f8405", async() => {
                WriteLiteral("Choose...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e1daa785d3efbe2db35914b9ce900608d56c3f9709", async() => {
                WriteLiteral("Hotel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e1daa785d3efbe2db35914b9ce900608d56c3f10899", async() => {
                WriteLiteral("Bar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e1daa785d3efbe2db35914b9ce900608d56c3f12088", async() => {
                WriteLiteral("Food Courts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""col-lg-3 col-sm-6 text-right"">
                            <a class=""btn main-search-btn btn-radius btn-lg btn-primary text-white""><span class=""btn-inner--text"">Search</span></a>
                        </div>
                    </div>
                </div>
                <!-- Search Section / End -->
                <div class=""col-md-12"">
                    <!-- Sorting - Filtering Section -->
                    <div class=""row mt-4 mb-5"">
                        <div class=""col-md-6"">
                            <!-- Layout Switcher -->
                            <div class=""layout-switcher"">
                                <a href=""listings-grid-with-sidebar.html"" class=""grid""> <span class=""round-pill d-block""><i class=""fa fa-th""></i></span></a>
                                <a href=""listings-list-with-sidebar.html"" class=""list active""><span class=""round-pill d-block""><i class=");
            WriteLiteral(@"""fa fa-align-justify""></i></span></a>
                            </div>
                        </div>
                    </div>
                    <!-- Sorting - Filtering Section / End -->
                    <div class=""row"">
                        <!-- Listing Item -->
");
#nullable restore
#line 73 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                         foreach (var item in Model.Restaurants)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-12 col-md-12 mb-5"">
                                <div class=""listing-item-container list-layout"">
                                    <div class=""listing-item"">
                                        <!-- Image -->
                                        <div class=""listing-item-image"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e1daa785d3efbe2db35914b9ce900608d56c3f15318", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1e1daa785d3efbe2db35914b9ce900608d56c3f15535", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4096, "~/Uploads/", 4096, 10, true);
#nullable restore
#line 80 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
AddHtmlAttributeValue("", 4106, item.CoverImageName, 4106, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

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
            WriteLiteral(@"
                                        </div>
                                        <!-- Content -->
                                        <div class=""listing-item-content"">
                                            <span class=""badge badge-pill list-banner badge-success text-uppercase"">");
#nullable restore
#line 84 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                                                                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            <div class=""listing-item-inner"">
                                                <!-- <DirectlistRating [rate]=""list.rating""></DirectlistRating> -->
                                                <a href=""listings-detail-two.html"">
                                                    <h3>");
#nullable restore
#line 88 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                </a>\r\n                                                <div class=\"address-bar\"> <small>");
#nullable restore
#line 90 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                                                                            Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small> </div>\r\n                                                <div class=\"mt-3\"><span class=\"badge badge-pill badge-primary text-uppercase badge-cat\">");
#nullable restore
#line 91 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"
                                                                                                                                   Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            </div>
                                            <span class=""round-pill like-banner d-block bg-primary""><i class=""fa fa-heart-o""></i></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 98 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Listing\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <!-- Listing Item / End -->
                    </div>
                    <!-- Pagination -->
                    <div class=""clearfix""></div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <!-- Pagination -->
                            <div class=""mt-3"">
                                <nav aria-label=""Page navigation"">
                                    <ul class=""pagination"">
                                        <li class=""page-item"">
                                            <a class=""page-link""><i class=""fa fa-angle-left""></i></a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">1</a>
                                        </li>
                                        <li class=""page-item active"">
                                            <a class=""page-link"">2</");
            WriteLiteral(@"a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">3</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">4</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link"">5</a>
                                        </li>
                                        <li class=""page-item"">
                                            <a class=""page-link""><i class=""fa fa-angle-right""></i></a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                    <!-- Pagin");
            WriteLiteral("ation / End -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmListing> Html { get; private set; }
    }
}
#pragma warning restore 1591
