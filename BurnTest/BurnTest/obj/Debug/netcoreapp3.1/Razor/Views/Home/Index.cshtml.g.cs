#pragma checksum "D:\Dev\BurnTest\BurnTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68687bd47056cf5d4048da0b956ffed5a99dc2c3"
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
#line 1 "D:\Dev\BurnTest\BurnTest\Views\_ViewImports.cshtml"
using BurnTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\BurnTest\BurnTest\Views\_ViewImports.cshtml"
using BurnTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68687bd47056cf5d4048da0b956ffed5a99dc2c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12718014ce79932ac9a054f38a9810bf8b49a933", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Dev\BurnTest\BurnTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- partial:index.partial.html -->\r\n    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68687bd47056cf5d4048da0b956ffed5a99dc2c34988", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta name=""description"" content=""Presentation of the Wild Circus project for the SNCF 2020 developer competition."">
        <title>Wild Circus Project 2020 by Suns</title>
        <link href=""https://fonts.googleapis.com/css?family=Amatic+SC&display=swap"" rel=""stylesheet"">
        <link href=""//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css"" rel=""stylesheet"">
        <script src=""js/my_js.js""></script>
    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68687bd47056cf5d4048da0b956ffed5a99dc2c36534", async() => {
                WriteLiteral(@"
        <h1 id=""main-title"" style=""margin-bottom: 0px;""><strong>Burning Man</strong></h1>
        <div>
            <img src=""/img/BmLogo.png.png"" alt=""Logo"" style=""display: block;margin-left: auto;margin-right: auto"" width=""500"" height=""500"">
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
                        <div class=""conten");
                WriteLiteral(@"t"">
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
            <div class=""container_tl"">
                <h2 ");
                WriteLiteral(@"id=""aboutus"" class=""title_about""><strong>About Us</strong></h2>
                <div class=""timeline"">
                    <div class=""swiper-container"">
                        <div class=""swiper-wrapper"">
                            <div id=""swiper-id1"" class=""swiper-slide"" data-year=""1862"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">1862</span>
                                    <h4 class=""timeline-title"">The Start</h4>
                                    <p class=""timeline-text"">Created in 1862 by brothers Julian and William Wild, specialists in equestrian art, The Wild Circus first set foot on French soil in 1876 for a series of performances. Very quickly, the back and forth between the two countries multiplied before a final installation in France in 1912 under the direction of Arthur Wild, the son of William.</p>
                                </div>
                            </div>
                  ");
                WriteLiteral(@"          <div id=""swiper-id2"" class=""swiper-slide"" data-year=""1936"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">1936</span>
                                    <h4 class=""timeline-title"">Kovacs's revolution</h4>
                                    <p class=""timeline-text"">When he died in 1936, the circus was bought by Rubben KOVACS, a descendant of Hungarian fairgrounds, who modernized it and increased its media notoriety by hosting television and radio programs in association with the ORTF.</p>
                                </div>
                            </div>
                            <div id=""swiper-id3"" class=""swiper-slide"" data-year=""1952"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">1952</span>
                                    <h4 class=""timeline-title"">Gillieron’ years</h4>
                                 ");
                WriteLiteral(@"   <p class=""timeline-text"">After his disappearance in 1952, actor Adam Gilliéron became the owner. If public success is at the rendezvous, it is not the same concerning finances and the circus files for bankruptcy in 1992.</p>
                                </div>
                            </div>
                            <div id=""swiper-id4"" class=""swiper-slide"" data-year=""1993"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">1993</span>
                                    <h4 class=""timeline-title"">The arrival of Eric FAURE</h4>
                                    <p class=""timeline-text"">Eric FAURE, former collaborator of Adam Gilliéron, can not bring himself to see Wild Circus disappear and buy the company convinced that it can be revived. He modernized management and quickly returned to popular and financial success to make it one of the jewels of the Swiss and European circus in a few years. Jean FAURE share");
                WriteLiteral(@"s this great adventure with his family and thus creates a new circus dynasty. His wife Edwige, actively participates in the reorganization of the company as General Manager, and his children, Lucie, great illusionist, and Louis, tamer of wild animals, are recognized artists.</p>
                                </div>
                            </div>
                            <div id=""swiper-id5"" class=""swiper-slide"" data-year=""2015"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2015</span>
                                    <h4 class=""timeline-title"">Renewal</h4>
                                    <p class=""timeline-text"">In the spring of 2015, like many entertainment companies, Wild Circus faces difficulties and must stop its tour. Passionate, man of challenges, Jean FAURE cannot resolve the disappearance of this flagship of the circus that he has helped to develop and keep alive for more than 30 years. Surroun");
                WriteLiteral(@"ded by his team, he decides that Wild Circus will be present in Monaco as every year. He entrusts the operational direction to his right hand Edward Snowden and the artistic direction to Michael McIntyre, a young artist and director already recognized. Together, they are betting on offering a completely new show that showcases the new generation of Swiss artists, all with respect for the traditional circus.</p>
                                </div>
                            </div>
                            <div id=""swiper-id6"" class=""swiper-slide"" data-year=""2020"">
                                <div class=""swiper-slide-content"">
                                    <span class=""timeline-year"">2020</span>
                                    <h4 class=""timeline-title"">Present day</h4>
                                    <p class=""timeline-text"">
                                        We participate in the biggest world events, from the Monaco festival to Las Vegas, passing through Quebec.
      ");
                WriteLiteral(@"                                  The reputation of Wild Circus is well established and we offer a show that will delight all generations because this is our vocation, 'To provide entertainment accessible to all'.
                                    </p>
                                </div>
                            </div>

                        </div>
                        <div class=""swiper-button-prev""></div>
                        <div class=""swiper-button-next""></div>
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>
            </div>
        </section>

        <section id=""Prices_section"">
            <h2 class=""title_price""><strong>Prices</strong></h2>
            <table class=""content-table"">
                <thead>
                    <tr>
                        <th>Period</th>
                        <th>Weeks except Wednesday</th>
                        <th>Ticket Office</th>
                        <th");
                WriteLiteral(@">Weekend and Wednesday</th>
                        <th>Ticket Office</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Childrens <i>(under 12)</i></td>
                        <td>10$</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJMBJ"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                        <td>12$</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJzLN"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                    </tr>
                    <tr class=""active-row"">
                        <td>Adults<i> (over 12)</i></td>
                        <td>15$</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJMBJ"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                        <td>18$</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJzLN");
                WriteLiteral(@""" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                    </tr>
                    <tr>
                        <td>Groups** <i>(more 10 people)</i></td>
                        <td>10$</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJMBJ"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                        <td>12$*</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJzLN"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                    </tr>
                    <tr class=""active-row"">
                        <td>Schools</td>
                        <td>200$*</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJMBJ"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
                        <td>250$*</td>
                        <td><a href=""https://codepen.io/Sunsworldz/full/NWqJzLN"" target=""_blank"" class=""button-ticket"">Buy ticket</a></td>
            ");
                WriteLiteral(@"        </tr>
                </tbody>

            </table>
            <p class=""legend_price"">* Only by reservation, please contact us by phone or by online form.<br>** We offer a declining rate beyond 20 people, contact us.</p>

        </section>

        <section id=""sectioncontact"">
            <div id=""abc"">
                <div id=""popupContact"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68687bd47056cf5d4048da0b956ffed5a99dc2c318004", async() => {
                    WriteLiteral(@"
                        <i class=""icon-remove"" onclick=""div_hide()""></i>
                        <h6 id=title_contact><strong>Contact us</strong></h6>
                        <div class=""input-container"">
                            <p class=""input-field ""><label for=""subject""><strong>Name</strong></label></p>
                            <input type=""text"" id=""subject"" name=""usrnm"" placeholder=""First, last name"">
                        </div>
                        <div class=""input-container"">
                            <p class=""input-field""><label for=""subject""><strong>Email</strong></label></p>
                            <input type=""text"" name=""email"" placeholder=""youremail@gmail.com"">
                        </div>

                        <div class=""input-container"">
                            <p class=""inputfield""><label for=""message""><strong>Your Message</strong></label></p>
                            <textarea id=""message"" rows=""10"" cols=""47"" name=""message""></textarea>
       ");
                    WriteLiteral("                 </div>\r\n\r\n                        <div class=\"sub-button\"><a href=\"https://codepen.io/Sunsworldz/full/MWwXgEK\">Submit</a></div>\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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

            <div class=""sectioncontact"">
                <a onclick=""div_show()""><img src=""https://i.ibb.co/z87dXbS/Fichier-1.png"" alt=""Bouton_contact""></a>
            </div>
        </section>


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
            WriteLiteral("\r\n\r\n</html>\r\n<!-- partial -->\r\n<script src=\'https://cdnjs.cloudflare.com/ajax/libs/Swiper/3.4.2/js/swiper.min.js\'></script>\r\n<script src=\'https://code.jquery.com/jquery-3.4.1.min.js\'></script>\r\n<script src=\"./script.js\"></script>");
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