#pragma checksum "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9999dda6b2536e61bee1230b144bc704590eb2e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournament_Details), @"mvc.1.0.view", @"/Views/Tournament/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tournament/Details.cshtml", typeof(AspNetCore.Views_Tournament_Details))]
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
#line 1 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\_ViewImports.cshtml"
using Asp.MVCCoreWeb;

#line default
#line hidden
#line 2 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\_ViewImports.cshtml"
using Asp.MVCCoreWeb.Models;

#line default
#line hidden
#line 3 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9999dda6b2536e61bee1230b144bc704590eb2e4", @"/Views/Tournament/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac05bc060a9dfc7327d5caab474f005c32c58a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournament_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asp.MVCCoreWeb.Models.Tournaments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/Screenshot_1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(92, 25, false);
#line 8 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(117, 104, true);
            WriteLiteral("\r\n<div>\r\n    <br />\r\n    <div class=\"card text-center\">\r\n        <div class=\"card-header\">\r\n            ");
            EndContext();
            BeginContext(221, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9999dda6b2536e61bee1230b144bc704590eb2e45172", async() => {
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
            EndContext();
            BeginContext(277, 88, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(366, 11, false);
#line 17 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
                              Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(377, 289, true);
            WriteLiteral(@"</h5>

            <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
            <div class=""row"" style=""font-size:x-large"">
                <div class=""col-sm"">
                    <i class=""fas fa-clock""></i><br />
                    ");
            EndContext();
            BeginContext(667, 15, false);
#line 23 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
               Write(Model.Date_Time);

#line default
#line hidden
            EndContext();
            BeginContext(682, 140, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <i class=\"fas fa-award\"></i><br />\r\n                    ");
            EndContext();
            BeginContext(823, 11, false);
#line 27 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
               Write(Model.Prize);

#line default
#line hidden
            EndContext();
            BeginContext(834, 140, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <i class=\"fas fa-users\"></i><br />\r\n                    ");
            EndContext();
            BeginContext(975, 11, false);
#line 31 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
               Write(Model.Slots);

#line default
#line hidden
            EndContext();
            BeginContext(986, 82, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-sm\">\r\n");
            EndContext();
#line 36 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
                   if (Model.Date_Time < DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1147, 148, true);
            WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\r\n                            Match was over!\r\n                        </div>\r\n");
            EndContext();
#line 41 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1367, 55, true);
            WriteLiteral("                        <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1422, "\"", 1494, 3);
            WriteAttributeValue("", 1432, "javascript:location.replace(\'/Payment/startpayment/", 1432, 51, true);
#line 44 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
WriteAttributeValue("", 1483, Model.Id, 1483, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1492, "\')", 1492, 2, true);
            EndWriteAttribute();
            BeginContext(1495, 16, true);
            WriteLiteral(">Join</button>\r\n");
            EndContext();
#line 45 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"

                    }
                

#line default
#line hidden
            BeginContext(1555, 95, true);
            WriteLiteral("                <label>Go back to <a href=\"/\" class=\"\">Home</a></label>\r\n\r\n            </div>\r\n");
            EndContext();
#line 51 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
             if (!String.IsNullOrEmpty(Model.Roomkey))
            {

#line default
#line hidden
            BeginContext(1721, 278, true);
            WriteLiteral(@"                <div class=""row""  style=""font-size:x-large"">

                    <div class=""col"">
                        <label  class="""">Room Key <i class=""fas fa-key""></i> </label>
                        <input type=""text"" readonly class=""form-control form-control-lg""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1999, "\"", 2044, 2);
#line 57 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
WriteAttributeValue("", 2007, Model.Roomkey, 2007, 14, false);

#line default
#line hidden
            WriteAttributeValue("                       ", 2021, "", 2044, 23, true);
            EndWriteAttribute();
            BeginContext(2045, 250, true);
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <label class=\"\">Password <i class=\"fas fa-lock-open\"></i> </label>\r\n                        <input type=\"text\" readonly class=\"form-control form-control-lg\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2295, "\"", 2322, 1);
#line 61 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
WriteAttributeValue("", 2303, Model.Roompassword, 2303, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2323, 57, true);
            WriteLiteral(">\r\n                    </div>\r\n\r\n                </div>\r\n");
            EndContext();
#line 65 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"

            }
            else
            {


#line default
#line hidden
            BeginContext(2432, 193, true);
            WriteLiteral("                <div class=\"alert alert-info\" role=\"alert\">\r\n                    Rook Id and password will be display here before match start (id you joined the match)\r\n                </div>\r\n");
            EndContext();
#line 73 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2640, 498, true);
            WriteLiteral(@"
        </div>
        <div class=""card-footer text-muted"">
            <table class=""table table-dark"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Players</th>
                        <th scope=""col"">Country</th>
                    </tr>
                </thead>
                <tbody id=""tablebody"">
                </tbody>
            </table>
        </div>
    </div>

</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3156, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3162, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9999dda6b2536e61bee1230b144bc704590eb2e413512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3201, 37, true);
                WriteLiteral("\r\n    <script>\r\n\r\n\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.MVCCoreWeb.Models.Tournaments> Html { get; private set; }
    }
}
#pragma warning restore 1591
