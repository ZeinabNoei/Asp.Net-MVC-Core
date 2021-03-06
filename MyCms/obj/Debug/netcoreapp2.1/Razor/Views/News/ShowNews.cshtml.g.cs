#pragma checksum "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e96ce4456b13dbafbdb8457089d6bddb0beaf9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowNews), @"mvc.1.0.view", @"/Views/News/ShowNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/ShowNews.cshtml", typeof(AspNetCore.Views_News_ShowNews))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e96ce4456b13dbafbdb8457089d6bddb0beaf9e", @"/Views/News/ShowNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCms.DomainClasses.Page.Page>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
  
    ViewData["Title"] = "ShowNews";

#line default
#line hidden
            BeginContext(82, 64, true);
            WriteLiteral("\r\n<section class=\"single-news border-radius\">\r\n    <header><h2> ");
            EndContext();
            BeginContext(147, 15, false);
#line 7 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
            Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(162, 57, true);
            WriteLiteral("   </h2> <span> <i class=\"fa fa-calendar\"></i>  انتشار : ");
            EndContext();
            BeginContext(220, 16, false);
#line 7 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
                                                                                     Write(Model.RecordDate);

#line default
#line hidden
            EndContext();
            BeginContext(236, 58, true);
            WriteLiteral("</span></header>\r\n    <article>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(295, 19, false);
#line 10 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
       Write(Model.PageShortDesc);

#line default
#line hidden
            EndContext();
            BeginContext(314, 41, true);
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(356, 14, false);
#line 13 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
       Write(Model.PageText);

#line default
#line hidden
            EndContext();
            BeginContext(370, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 15 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
         if (Model.PageImageName != null)
        {

#line default
#line hidden
            BeginContext(440, 35, true);
            WriteLiteral("            <div>\r\n                ");
            EndContext();
            BeginContext(475, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e96ce4456b13dbafbdb8457089d6bddb0beaf9e5351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 485, "~/PageImages/", 485, 13, true);
#line 18 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
AddHtmlAttributeValue("", 498, Model.PageImageName, 498, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
AddHtmlAttributeValue("", 525, Model.PageTitle, 525, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(563, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 20 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
        }

#line default
#line hidden
            BeginContext(596, 66, true);
            WriteLiteral("    </article>\r\n</section>\r\n<div class=\"keywords border-radius\">\r\n");
            EndContext();
#line 24 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
     foreach (var item in Model.PageTags.Split('-'))
    {

#line default
#line hidden
            BeginContext(723, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 733, "\"", 755, 2);
            WriteAttributeValue("", 740, "/Search?q=", 740, 10, true);
#line 26 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 750, item, 750, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(756, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(759, 4, false);
#line 26 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
                              Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(763, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 27 "D:\Project\MVCProject\CoreNewsProject\MyCms\Views\News\ShowNews.cshtml"
    }

#line default
#line hidden
            BeginContext(776, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCms.DomainClasses.Page.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
