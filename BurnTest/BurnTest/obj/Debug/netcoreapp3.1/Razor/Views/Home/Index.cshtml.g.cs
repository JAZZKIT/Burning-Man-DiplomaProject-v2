#pragma checksum "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1b21fd319ea3fac530ef1ec02e14d91863e361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1b21fd319ea3fac530ef1ec02e14d91863e361", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12718014ce79932ac9a054f38a9810bf8b49a933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- partial:index.partial.html -->\r\n    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1b21fd319ea3fac530ef1ec02e14d91863e3615967", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta name=""description"" content=""Presentation of the Wild Circus project for the SNCF 2020 developer competition."">
        <title>Wild Circus Project 2020 by Suns</title>
        <link href=""https://fonts.googleapis.com/css?family=Amatic+SC&display=swap"" rel=""stylesheet"">
        <link href=""//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css"" rel=""stylesheet"">
        <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/Swiper/3.4.2/css/swiper.min.css'>
        <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800'>
        <link rel='stylesheet' href='https://use.fontawesome.com/73d812ac28.css'>
        <script src=""js/my_js.js""></script>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d1b21fd319ea3fac530ef1ec02e14d91863e3617101", async() => {
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
                WriteLiteral("\r\n        <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0\" crossorigin=\"anonymous\">\r\n    ");
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
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1b21fd319ea3fac530ef1ec02e14d91863e3619225", async() => {
                WriteLiteral(@"
        <h1 id=""main-title"" style=""margin-bottom: 0px;""><strong>Burning Man</strong></h1>
        <div>
            <img src=""/img/BmLogo.png.png"" alt=""Logo"" style=""display: block;margin-left: auto;margin-right: auto; margin-bottom: 30px;"" width=""500"" height=""500"">
        </div>
        <section id=""performances"">
            <h2 class=""title_perf""><strong>Performances</strong></h2>
            <ul class=""page-content"">
                <li>
                    <div id=""laugh"" class=""card"">
                        <div class=""content"">
                            <h2 id=""performance_Laugh"" class=""title"">Laugh</h2>
                            <p class=""copy""> As an adult, come and discover our irresistible clowns, between practical jokes and pranks let yourself be carried away by their joy and fall back into childhood.</p>
                        </div>
                    </div>
                </li>
                <li>
                    <div id=""dream"" class=""card"">
                    ");
                WriteLiteral(@"    <div class=""content"">
                            <h2 id=""performance_Dream"" class=""title"">Dream</h2>
                            <p class=""copy""> Let yourself be carried away in a world where the real and the imaginary are one, in the company of our talented magicians, discover a wonderful world limited only by your imagination.</p>
                        </div>
                    </div>
                </li>
                <li>
                    <div id=""marvel_at"" class=""card"">
                        <div class=""content"">
                            <h2 id=""performance_Marvel"" class=""title"">Marvel at</h2>
                            <p class=""copy""> Tame the untameable in the company of our tamers, between roar and razor-sharp claws, watch these fierce felines turn into sweet kittens.</p>
                        </div>
                    </div>
                </li>
            </ul>
        </section>

        <section id=""about_section"">
            <div class=""container_tl"">");
                WriteLiteral(@"
                <h2 id=""aboutus"" class=""title_about""><strong>About Us</strong></h2>
                <div class=""timeline"">
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">
                            <div id=""swiper-id1"" class=""swiper-slide"" data-year=""1986"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">1986</span>
                                    <h4 class=""timeline-title"">THE EARLY YEARSt</h4>
                                    <p class=""timeline-text"">... it was supremely romantic. And so two years later, having thought of this morning and night for a couple of years I woke up and it was the solstice, and I thought ""I'm tired of this."" So I called up a friend and I said ""Let's... let's burn a man, Jerry.""</p>
                                </div>
                            </div>
                            <div id=""swiper-id2"" class=""swiper-slide"" ");
                WriteLiteral(@"data-year=""2000"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2000</span>
                                    <h4 class=""timeline-title"">THE BODY</h4>
                                    <p class=""timeline-text"">We couldn’t believe it was cold again either. And the wind storms were back. Regardless of the elements that came our way, we put our goggled faces into the wind and marched off across the playa.</p>
                                </div>
                            </div>
                            <div id=""swiper-id3"" class=""swiper-slide"" data-year=""2008"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2008</span>
                                    <h4 class=""timeline-title"">American Dream</h4>
                                    <p class=""timeline-text"">“And so from hour to hour we ripe and ripe,
                    ");
                WriteLiteral(@"                                         And then from hour to hour we rot and rot;
                                                             And thereby hangs a tale.” — William Shakespeare,
                                                             — As You Like It.</p>
                                </div>
                            </div>
                            <div id=""swiper-id4"" class=""swiper-slide"" data-year=""2009"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2009</span>
                                    <h4 class=""timeline-title"">Evalution</h4>
                                    <p class=""timeline-text""> This year's art theme contemplates the power and the meaning of the process we call evolution. Design by Rod Garret and Larry Harvey. Rendering by Andrew Johnstone and Rod Garrett. In 2009, the Burning Man will rise above a 'tangled bank' consisting of irregular wooden triangles.</p>
      ");
                WriteLiteral(@"                          </div>
                            </div>
                            <div id=""swiper-id5"" class=""swiper-slide"" data-year=""2018"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2018</span>
                                    <h4 class=""timeline-title"">I, Robot</h4>
                                    <p class=""timeline-text"">So in the future when the machines have taken over our lives who is going to provide the answers of a technical nature. Will technical support for robots be out sourced, who is going to be at the other end of the phone or who is going to be on live chat or answer all the emails when something goes wrong with a robot.
                                                             There will be a technical support desk just off to the side of the robot and the words printed on the front of the desk will be “Technical Support Desk”. On the desk there will be a phone and a big th");
                WriteLiteral(@"ick manual the title of the manual will be “The 404 technical support manual” . But will this help?</p>
                                </div>
                            </div>
                            <div id=""swiper-id6"" class=""swiper-slide"" data-year=""2020"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2020</span>
                                    <h4 class=""timeline-title"">Cacophony</h4>
                                    <p class=""timeline-text"">
                                        ""The 2020 Burning Man event theme explores the quantum kaleidoscope of possibility, the infinite realities of the multiverse, and our own superpositioning as actors and observers in the cosmic Cacophony of resonant strings,"" says a statement released by the festival.
                                    </p>
                                </div>
                            </div>

                        </div>
      ");
                WriteLiteral(@"                  <div class=""swiper-button-prev""></div>
                        <div class=""swiper-button-next""></div>
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>
            </div>
        </section>

    <section id=""sectioncontact"">
        <div id=""abc"">
            <div id=""popupContact"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1b21fd319ea3fac530ef1ec02e14d91863e36117463", async() => {
                    WriteLiteral(@"
                    <i class=""icon-remove"" onclick=""div_hide()""></i>
                    <h6 id=title_contact><strong>Contact us</strong></h6>
                    <div class=""input-container"">
                        <p class=""input-field ""><label for=""subject""><strong>Name</strong></label></p>
                        <input type=""text"" id=""subject"" name=""usrnm"">
                    </div>
                    <div class=""input-container"">
                        <p class=""input-field""><label for=""subject""><strong>Email</strong></label></p>
                        <input type=""text"" name=""email"">
                    </div>

                    <div class=""input-container"">
                        <p class=""inputfield""><label for=""message""><strong>Your Message</strong></label></p>
                        <textarea id=""message"" rows=""10"" cols=""47"" name=""message""></textarea>
                    </div>

                    <div class=""sub-button""><a href=""https://codepen.io/Sunsworldz/full/MWwXgE");
                    WriteLiteral("K\">Submit</a></div>\r\n\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n");
                WriteLiteral(@"    </section>
    
    <div class=""wrapper"">
        <div class=""product-img"">
            <img src=""http://www.ijamming.net/wp-content/img_2860.jpg"" height=""420"" width=""327"">
        </div>
        <div class=""product-info"">
            <div class=""product-text"">
                <h1>Harvest Vase</h1>
                <h2>by studio and friends</h2>
                <p>Harvest Vases are a reinterpretation<br> of peeled fruits and vegetables as<br> functional objects. The surfaces<br> appear to be sliced and pulled aside,<br> allowing room for growth. </p>
            </div>
            <div class=""product-price-btn"">
");
#nullable restore
#line 165 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Tickets!", "TicketPreBuyPage", new {controller = "TicketManage"}, new {@target = "_blank", @class = "button-ticket", @style = "margin-left: 85%"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\Dev\Burning-Man-DiplomaProject-v2\BurnTest\BurnTest\Views\Home\Index.cshtml"
                                                                                                                                                                                        
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""container"">
        <img src=""/img/RV.png"" alt=""Italian Trulli"" style=""height: 500px; width: 500px; display: block;margin-left: auto;margin-right: auto"">
    </div>
            
            <!-- Button trigger modal -->
            <button type=""button"" class=""btn btn-dark btn-sm"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
              Rent RV
            </button>
            <!-- Modal -->
            <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
              <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                  <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">RV Rental</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                      <span aria-hid");
                WriteLiteral(@"den=""true"">&times;</span>
                    </button>
                  </div>
                  <div class=""modal-body"">
                      <div id=""BukzaContainer15868""></div>
                      <script type='text/javascript'>
                          (function () {
                              var d = document;
                              var w = window;
                              function l() {
                                  var s = d.createElement('script');
                                  s.type = 'text/javascript';
                                  s.async = true;
                                  s.src = 'https://public.bukza.com/api/script/generate/16923/15868/BukzaContainer15868?t=' + (new Date().getTime());
                                  var ss = d.getElementsByTagName('script')[0];
                                  ss.parentNode.insertBefore(s, ss);
                              }
                              if (d.readyState == 'complete') {
             ");
                WriteLiteral(@"                     l();
                              } else {
                                  w.addEventListener('load', l, false);
                              }
                          })();
                      </script>
                  </div>
                    
                </div>
              </div>
            </div>
    
      
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
            WriteLiteral("\r\n\r\n</html>\r\n<!-- partial -->\r\n<script src=\'https://cdnjs.cloudflare.com/ajax/libs/Swiper/3.4.2/js/swiper.min.js\'></script>\r\n<script src=\'https://code.jquery.com/jquery-3.4.1.min.js\'></script>\r\n<script src=\"./script.js\"></script>\r\n\r\n\r\n  \r\n\r\n\r\n");
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
