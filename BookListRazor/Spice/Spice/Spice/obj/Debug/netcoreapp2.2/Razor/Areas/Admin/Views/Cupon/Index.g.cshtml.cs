#pragma checksum "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7389edaff78d7e943b0b4576c7b407f8bf73ce26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cupon_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Cupon/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Cupon/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Cupon_Index))]
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
#line 1 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7389edaff78d7e943b0b4576c7b407f8bf73ce26", @"/Areas/Admin/Views/Cupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Cupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cupon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 219, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">Cupon List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(336, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7389edaff78d7e943b0b4576c7b407f8bf73ce264598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 62, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"\">\r\n");
            EndContext();
#line 20 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(481, 126, true);
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>");
            EndContext();
            BeginContext(608, 32, false);
#line 24 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(640, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(672, 36, false);
#line 25 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(708, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(740, 41, false);
#line 26 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.MinimumAmount));

#line default
#line hidden
            EndContext();
            BeginContext(781, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(813, 36, false);
#line 27 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(849, 92, true);
            WriteLiteral("</th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1006, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1053, 31, false);
#line 34 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1116, 35, false);
#line 35 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1183, 40, false);
#line 36 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.MinimumAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1255, 35, false);
#line 37 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1321, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7389edaff78d7e943b0b4576c7b407f8bf73ce2610274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 38 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1375, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 40 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1424, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 42 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1482, 37, true);
            WriteLiteral("            <p>No cupons exists</p>\r\n");
            EndContext();
#line 46 "C:\Users\yairf\OneDrive\Escritorio\Master .NET CORE\BookListRazor\Spice\Spice\Spice\Areas\Admin\Views\Cupon\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1530, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cupon>> Html { get; private set; }
    }
}
#pragma warning restore 1591