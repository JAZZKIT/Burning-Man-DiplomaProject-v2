#pragma checksum "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86fbf61325b892c13b774484d12c88da79876b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_OrderHistory), @"mvc.1.0.view", @"/Views/Manage/OrderHistory.cshtml")]
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
#line 1 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\_ViewImports.cshtml"
using BurnTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\_ViewImports.cshtml"
using BurnTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86fbf61325b892c13b774484d12c88da79876b90", @"/Views/Manage/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12718014ce79932ac9a054f38a9810bf8b49a933", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BurnTest.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/History.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86fbf61325b892c13b774484d12c88da79876b904561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86fbf61325b892c13b774484d12c88da79876b905675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86fbf61325b892c13b774484d12c88da79876b906836", async() => {
                WriteLiteral(@"
        <section>
            <!--for demo wrap-->
            <h1>Purchase History</h1>
            <div class=""tbl-header"" style=""padding-right: 0px;"">
                <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Mail</th>
                            <th>Type</th>
                            <th>Order Date</th>
                            <th>Amount</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class=""tbl-content"">
                <table cellpadding=""0"" cellspacing=""0"" border=""0"">
                    <tbody>
");
#nullable restore
#line 43 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                           foreach (var itm in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">");
#nullable restore
#line 46 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                                                     Write(itm.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>Black Desert</td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                                   Write(itm.OrderDateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>$");
#nullable restore
#line 50 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                                    Write(itm.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Manage\OrderHistory.cshtml"
                            } 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </section>

        <script src=""https://cpwebassets.codepen.io/assets/common/stopExecutionOnTimeout-157cd5b220a5c80d4ff8e0e70ac069bffd87a61252088146915e8726e5d9f147.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js""></script>
        <script src=""https://cdpn.io/cp/internal/boomboom/pen.js?key=pen.js-418ac8af-acc6-f783-a196-2f36e7d493b0""");
                BeginWriteAttribute("crossorigin", " crossorigin=\"", 2366, "\"", 2380, 0);
                EndWriteAttribute();
                WriteLiteral(@"></script>
        <script id=""rendered-js"">$(window).on(""load resize "", function () {
                var scrollWidth = $('.tbl-content').width() - $('.tbl-content table').width();
                $('.tbl-header').css({ 'padding-right': scrollWidth });
            }).resize();
        </script>

    ");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BurnTest.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591