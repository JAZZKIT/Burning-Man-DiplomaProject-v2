#pragma checksum "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\TicketManage\TicketPreBuyPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd50b87ff69653c7bf71afdafca79e7a04c580a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TicketManage_TicketPreBuyPage), @"mvc.1.0.view", @"/Views/TicketManage/TicketPreBuyPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd50b87ff69653c7bf71afdafca79e7a04c580a3", @"/Views/TicketManage/TicketPreBuyPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12718014ce79932ac9a054f38a9810bf8b49a933", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketManage_TicketPreBuyPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Photos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\TicketManage\TicketPreBuyPage.cshtml"
  
    ViewBag.Title = "Pre-Buy";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd50b87ff69653c7bf71afdafca79e7a04c580a34263", async() => {
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd50b87ff69653c7bf71afdafca79e7a04c580a35381", async() => {
                WriteLiteral("\r\n<div style=\"text-align: center\">\r\n  <h1>Order Your Ticket Now</h1>\r\n  ");
#nullable restore
#line 11 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\TicketManage\TicketPreBuyPage.cshtml"
Write(Html.ActionLink("Tickets!", "TicketMainPage", new { controller = "TicketManage" }, new { @class = "waves-effect waves-light btn" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
</div>
<!-- partial:index.partial.html -->
<div class=""cards"">

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""\img/bed.jpg"" alt=""wave"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Burning Art Installations
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        Each August, Black Rock Desert in Nevada, US turns to an amazingly vibrant city, an art and community experiment dedicated to radical self reliance and self expression.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img");
                WriteLiteral(@"/ball.jpg"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devices. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/Rawen.jpg"" alt=""mountain"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title");
                WriteLiteral(@"
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devices. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/art.png"" alt=""field"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devic");
                WriteLiteral(@"es. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/desert.jpg"" alt=""water"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Black Rock Desert
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        The Black Rock Desert is a semi-arid region of lava beds and playa, or alkali flats, situated in the Black Rock Desert???High Rock Canyon.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </d");
                WriteLiteral(@"iv>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/people.jpg"" alt=""river"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devices. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/home.jpg"" alt=""kite"" />
    </div>
    <div class=""card-title"">
      <a ");
                WriteLiteral(@"href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devices. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>
  
  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/ufo.jpg"" alt=""underwater"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Card title
          <small>Burning man 2021</small>
      </h2>
    </");
                WriteLiteral(@"div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        This grid is an attempt to make something nice that works on touch devices. Ignoring hover states when they're not available etc.
      </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
  </div>

  <div class=""card"">
    <div class=""card__image-holder"">
      <img class=""card__image"" src=""/img/tower.jpg"" alt=""desert"" />
    </div>
    <div class=""card-title"">
      <a href=""#"" class=""toggle-info btn"">
        <span class=""left""></span>
        <span class=""right""></span>
      </a>
      <h2>
          Burning Man
          <small>Burning man 2021</small>
      </h2>
    </div>
    <div class=""card-flap flap1"">
      <div class=""card-description"">
        Burning Man started in 1986 in San Francisco. An artist named Larry Harvey made a 9-foot tall (2.7 m) wooden sculpture of a man.
  ");
                WriteLiteral(@"    </div>
      <div class=""card-flap flap2"">
        <div class=""card-actions"">
          <a href=""#"" class=""btn"">Read more</a>
        </div>
      </div>
    </div>
</div>

</div>
<!-- partial -->
  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js'></script><script  src=""./script.js""></script>

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
            WriteLiteral(@"
<script src=""https://cpwebassets.codepen.io/assets/common/stopExecutionOnTimeout-157cd5b220a5c80d4ff8e0e70ac069bffd87a61252088146915e8726e5d9f147.js""></script>

      <script id=""rendered-js"">
$(document).ready(function () {
  var zindex = 10;

  $(""div.card"").click(function (e) {
    e.preventDefault();

    var isShowing = false;

    if ($(this).hasClass(""show"")) {
      isShowing = true;
    }

    if ($(""div.cards"").hasClass(""showing"")) {
      // a card is already in view
      $(""div.card.show"").
      removeClass(""show"");

      if (isShowing) {
        // this card was showing - reset the grid
        $(""div.cards"").
        removeClass(""showing"");
      } else {
        // this card isn't showing - get in with it
        $(this).
        css({ zIndex: zindex }).
        addClass(""show"");

      }

      zindex++;

    } else {
      // no cards in view
      $(""div.cards"").
      addClass(""showing"");
      $(this).
      css({ zIndex: zindex }).
      addCla");
            WriteLiteral("ss(\"show\");\r\n\r\n      zindex++;\r\n    }\r\n\r\n  });\r\n});\r\n//# sourceURL=pen.js\r\n    </script>");
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
