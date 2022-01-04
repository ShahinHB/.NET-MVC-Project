#pragma checksum "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c9a097141356db3e3149cbc5e0a8ffe7e8f07f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c9a097141356db3e3149cbc5e0a8ffe7e8f07f", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf0590a3647962861253c342f91d983130511b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmBlog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-wrapper"">
    <div id=""titlebar"" class=""gradient"">
        <div class=""title-bar-inner"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h2>Blog Listing</h2>
                        <span>Explore your search places</span>
                        <!-- Breadcrumbs -->
                        <nav id=""breadcrumbs"">
                            <ul>
                                <li><a>Home</a></li>
                                <li>Blog</li>
                                <li>List</li>
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
            <!-- Blog Posts -->
            <div class=""blog-page"">
                <div class=""row"">
           ");
            WriteLiteral("         <div class=\"col-lg-9 col-md-8 padding-right-30\">\r\n                        <!-- Blog Post -->\r\n");
#nullable restore
#line 36 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
                         foreach (var item in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card card-lift--hover shadow border-0 mb-4\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23c9a097141356db3e3149cbc5e0a8ffe7e8f07f7130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1416, "~/Uploads/", 1416, 10, true);
#nullable restore
#line 39 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1426, item.ImageName, 1426, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body py-4\">\r\n                                    <h5 class=\"text-primary\">");
#nullable restore
#line 41 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"text-primary\">");
#nullable restore
#line 42 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
                                                       Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"description mt-3\">");
#nullable restore
#line 43 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
                                                           Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c9a097141356db3e3149cbc5e0a8ffe7e8f07f9954", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"
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
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\Shahin\Desktop\practices\Backend_Project\Backend_Project\Views\Blog\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                       
                    </div>
                    <!-- Blog Posts / End -->
                    <!-- Widgets -->
                    <div class=""col-lg-3 col-md-4"">
                        <div class=""sidebar right"">
                            <!-- Widget -->
                            <div class=""widget"">
                                <div class=""form-group"">
                                    <div class=""input-group mb-4"">
                                        <div class=""input-group-prepend"">
                                            <span class=""input-group-text""><i class=""fa fa-search""></i></span>
                                        </div>
                                        <input class=""form-control"" placeholder=""Search"" type=""text"">
                                    </div>
                                </div>
                            </div>
                            <div class=""widget margin-top-40"">
                                <h3>P");
            WriteLiteral(@"opular Posts</h3>
                                <ul class=""widget-tabs"">
                                    <!-- Post #1 -->
                                    <li>
                                        <div class=""widget-content"">
                                            <div class=""widget-thumb"">
                                                <a href=""#""><img src=""assets/images/bw-1.jpg"" alt=""image""></a>
                                            </div>
                                            <div class=""widget-text"">
                                                <h5><a href=""#"">Hotels for All Budgets </a></h5>
                                                <span>October 26, 2016</span>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </li>
                                    <!-- Post #2 -->
                          ");
            WriteLiteral(@"          <li>
                                        <div class=""widget-content"">
                                            <div class=""widget-thumb"">
                                                <a href=""#""><img src=""assets/images/bw-2.jpg"" alt=""image""></a>
                                            </div>
                                            <div class=""widget-text"">
                                                <h5><a href=""#"">The 50 Greatest Street Arts In London</a></h5>
                                                <span>November 9, 2016</span>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </li>
                                    <!-- Post #3 -->
                                    <li>
                                        <div class=""widget-content"">
                                            <div class=""w");
            WriteLiteral(@"idget-thumb"">
                                                <a href=""3.html""><img src=""assets/images/bw-3.jpg"" alt=""image""></a>
                                            </div>
                                            <div class=""widget-text"">
                                                <h5><a href=""#"">The Best Cofee Shops In Sydney Neighborhoods</a></h5>
                                                <span>November 12, 2016</span>
                                            </div>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                            <!-- Widget / End-->
                            <!-- Widget -->
                            <div class=""widget margin-top-40"">
                                <h3 class=""margin-bottom-25"">Social</h3>
                                <div class=""b");
            WriteLiteral(@"tn-wrapper"">
                                    <a target=""_blank"" href=""#"" class=""btn btn-neutral btn-icon-only btn-twitter btn-round btn-lg"" data-toggle=""tooltip"" data-original-title=""Follow us"">
                                        <i class=""fa fa-twitter""></i>
                                    </a>
                                    <a target=""_blank"" href=""#"" class=""btn btn-neutral btn-icon-only btn-facebook btn-round btn-lg"" data-toggle=""tooltip"" data-original-title=""Like us"">
                                        <i class=""fa fa-facebook-square""></i>
                                    </a>
                                    <a target=""_blank"" href=""#"" class=""btn btn-neutral btn-icon-only btn-dribbble btn-lg btn-round"" data-toggle=""tooltip"" data-original-title=""Follow us"">
                                        <i class=""fa fa-dribbble""></i>
                                    </a>
                                    <a target=""_blank"" href=""#"" class=""btn btn-neutral btn-icon-only ");
            WriteLiteral(@"btn-github btn-round btn-lg"" data-toggle=""tooltip"" data-original-title=""Star on Github"">
                                        <i class=""fa fa-github""></i>
                                    </a>
                                </div>
                            </div>
                            <!-- Widget / End-->
                            <div class=""clearfix""></div>
                            <div class=""margin-bottom-40""></div>
                        </div>
                    </div>
                </div>
                <!-- Sidebar / End -->
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmBlog> Html { get; private set; }
    }
}
#pragma warning restore 1591
