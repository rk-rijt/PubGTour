#pragma checksum "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe6ed6055771a43d369d3ef64a3678ecc2db27da"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6ed6055771a43d369d3ef64a3678ecc2db27da", @"/Views/Tournament/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac05bc060a9dfc7327d5caab474f005c32c58a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournament_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asp.MVCCoreWeb.Models.Tournaments>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            BeginContext(87, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Tournaments</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(222, 45, false);
#line 14 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_Time));

#line default
#line hidden
            EndContext();
            BeginContext(267, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(331, 41, false);
#line 17 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date_Time));

#line default
#line hidden
            EndContext();
            BeginContext(372, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(435, 40, false);
#line 20 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(475, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(539, 36, false);
#line 23 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
            EndContext();
            BeginContext(575, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(638, 41, false);
#line 26 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Slots));

#line default
#line hidden
            EndContext();
            BeginContext(679, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(743, 37, false);
#line 29 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.Slots));

#line default
#line hidden
            EndContext();
            BeginContext(780, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(843, 39, false);
#line 32 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fee));

#line default
#line hidden
            EndContext();
            BeginContext(882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(946, 35, false);
#line 35 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.fee));

#line default
#line hidden
            EndContext();
            BeginContext(981, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1044, 41, false);
#line 38 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prize));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1149, 37, false);
#line 41 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prize));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1249, 43, false);
#line 44 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1356, 39, false);
#line 47 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
       Write(Html.DisplayFor(model => model.Details));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1442, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6ed6055771a43d369d3ef64a3678ecc2db27da9376", async() => {
                BeginContext(1488, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "F:\profession\Asp.MVCCoreWeb\Asp.MVCCoreWeb\Views\Tournament\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1496, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1504, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6ed6055771a43d369d3ef64a3678ecc2db27da11693", async() => {
                BeginContext(1526, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1542, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.MVCCoreWeb.Models.Tournaments> Html { get; private set; }
    }
}
#pragma warning restore 1591
