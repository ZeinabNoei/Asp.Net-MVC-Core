#pragma checksum "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593a498c1d2a40c7f7dbc133ea5daf293735b73c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DefaultLayout.cshtml", typeof(AspNetCore.Views_Shared__DefaultLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593a498c1d2a40c7f7dbc133ea5daf293735b73c", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_showgroupsInMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 64, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html class=\"no-js\" dir=\"rtl\" lang=\"fa-IR\">\r\n");
            EndContext();
            BeginContext(64, 834, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593a498c1d2a40c7f7dbc133ea5daf293735b73c4882", async() => {
                BeginContext(70, 821, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title> سایت خبری برنامه نویسان </title>
    <base href="""">
    <meta name=""googlebot"" content=""index,follow"">
    <meta name=""robots"" content=""noodp,noydir"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap-rtl.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/owl.carousel.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"">
    <script src=""/js/jquery.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(898, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(900, 4513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593a498c1d2a40c7f7dbc133ea5daf293735b73c6939", async() => {
                BeginContext(906, 1381, true);
                WriteLiteral(@"
    <script src=""/js/modernizr.js""></script>

    <!-- Top Menu -->
    <div class=""top-menu"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-5"">
                    <ul>
                        <li><a href=""""><i class=""fa fa-home""></i></a></li>
                        <li><a href=""""><i class=""fa fa-question-circle""></i></a></li>
                        <li><a href=""""><i class=""fa fa-envelope""></i></a></li>
                    </ul>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-7"">
                    <span>امروز : 18/08/1395</span>
                </div>
            </div>
        </div>
    </div>
    <!-- End Top Menu -->
    <!-- header -->
    <header class=""main-header"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    <a href="""" class=""logo""><img src=""img/logo.png"" alt="""" title=""""></a>
   ");
                WriteLiteral(@"                 <div class=""left-side"">
                        <h1><a href="""">سایت خبری برنامه نویسان</a></h1>
                        <h2> پایگاه اطلاع رسانی و خبری</h2>
                    </div>
                    <div class=""clearfix""></div>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-12"">
                    ");
                EndContext();
                BeginContext(2287, 260, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593a498c1d2a40c7f7dbc133ea5daf293735b73c8789", async() => {
                    BeginContext(2345, 195, true);
                    WriteLiteral("\r\n                        <input class=\"border-radius\" name=\"q\" type=\"text\" placeholder=\"Search ... \">\r\n                        <button><i class=\"fa fa-search\"></i></button>\r\n                    ");
                    EndContext();
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
                EndContext();
                BeginContext(2547, 251, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <!-- End Header -->\r\n    <!-- menu -->\r\n    <nav class=\"main-menu\">\r\n        <div class=\"container\">\r\n            <span><i class=\"fa fa-th-list\"></i></span>\r\n            ");
                EndContext();
                BeginContext(2798, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "593a498c1d2a40c7f7dbc133ea5daf293735b73c11191", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2835, 214, true);
                WriteLiteral("\r\n        </div>\r\n    </nav>\r\n    <!-- End menu -->\r\n\r\n    <div class=\"container margin-top-30\">\r\n        <div class=\"row\">\r\n\r\n            <aside class=\"col-md-4 col-sm-12 col-xs-12 pull-right\">\r\n\r\n                ");
                EndContext();
                BeginContext(3050, 50, false);
#line 77 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\Shared\_DefaultLayout.cshtml"
           Write(await Component.InvokeAsync("ShowGroupsComponent"));

#line default
#line hidden
                EndContext();
                BeginContext(3100, 60, true);
                WriteLiteral("\r\n                <!-- most views news -->\r\n                ");
                EndContext();
                BeginContext(3161, 51, false);
#line 79 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\Shared\_DefaultLayout.cshtml"
           Write(await Component.InvokeAsync("ShowTopPageComponent"));

#line default
#line hidden
                EndContext();
                BeginContext(3212, 154, true);
                WriteLiteral("\r\n\r\n              \r\n                <!-- end most views news -->\r\n            </aside>\r\n\r\n\r\n            <div class=\"col-md-8 col-sm-12 col-xs-12 \">\r\n\r\n   ");
                EndContext();
                BeginContext(3367, 12, false);
#line 88 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\Shared\_DefaultLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3379, 1994, true);
                WriteLiteral(@"

            </div>


        </div>
    </div>

    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-12 col-xs-12"">
                    <section class=""access-links"">
                        <header> دسترسی سریع </header>
                        <ul>
                            <li><a href=""""> صفحه اصلی </a></li>
                            <li><a href=""""> قوانین سایت  </a></li>
                            <li><a href=""""> راهنمای سایت  </a></li>
                            <li><a href=""""> پیوندهای سایت </a></li>
                            <li><a href=""""> صفحه اصلی </a></li>
                            <li><a href=""""> قوانین سایت  </a></li>
                            <li><a href=""""> صفحه اصلی </a></li>
                            <li><a href=""""> قوانین سایت  </a></li>
                            <li><a href=""""> راهنمای سایت  </a></li>
                        </ul>
                    </section>
                </div");
                WriteLiteral(@">
                <div class=""col-md-5 col-md-offset-1 col-sm-12 col-xs-12"">
                    <div class=""socials"">
                        <span> شبکه های اجتماعی  سایت</span>
                        <a href=""""><i class=""fa fa-facebook""></i></a>
                        <a href=""""><i class=""fa fa-twitter""></i></a>
                        <a href=""""><i class=""fa fa-paper-plane""></i></a>
                        <a href=""""><i class=""fa fa-google-plus""></i></a>
                        <div class=""clearfix""></div>
                    </div>
                    <p>
                        تمامی حقوق مادی و معنوی این طرح متعلق به آموزشگاه برنامه نویسان می باشد و کپی برداری از این طرح غیر اخلاقی می باشد.
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/owl.carousel.js""></script>
    <script src=""/js/script.js""></script>
    ");
                EndContext();
                BeginContext(5374, 30, false);
#line 135 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\Shared\_DefaultLayout.cshtml"
Write(RenderSection("Scripts",false));

#line default
#line hidden
                EndContext();
                BeginContext(5404, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5413, 9, true);
            WriteLiteral("\r\n</html>");
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