#pragma checksum "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d763b537d8c7302b624ccb955d37e5dfee31bd02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usage_AddNewUsage), @"mvc.1.0.view", @"/Views/Usage/AddNewUsage.cshtml")]
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
#line 1 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\_ViewImports.cshtml"
using BookLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d763b537d8c7302b624ccb955d37e5dfee31bd02", @"/Views/Usage/AddNewUsage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74a20da30516801813781460676a58521fc3f21", @"/Views/_ViewImports.cshtml")]
    public class Views_Usage_AddNewUsage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookLibrary.Models.Bhagyastorage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewUsage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
  
    ViewData["Title"] = "AddNewUsage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddNewUsage</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d763b537d8c7302b624ccb955d37e5dfee31bd025152", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 19 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.Itemname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.Tamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.dm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.ym));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 53 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Itemname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.month));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.DisplayFor(modelItem => item.UpdatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 78 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 79 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<input class=\"search btn-default\" type=\"button\" value=\"Add\" id=\"partialView\"\r\n       data-assigned-id=\"1\" data-toggle=\"modal\" data-target=\"#exampleModalLong\" />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d763b537d8c7302b624ccb955d37e5dfee31bd0213731", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d763b537d8c7302b624ccb955d37e5dfee31bd0213994", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 91 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""modal fade"" id=""exampleModalLong"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div id=""partial""></div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div id=\"addusage\">\r\n\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 118 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <script type=""text/javascript"">

        $(document).ready(function () {
            $('input#btnaddusage').click(function () {
                $('div#addusage').show();
            })
            $('input#btnretriveusage').click(function () {
                $('div#addusage').hide();
                $('div#getusage').show();
            })

");
                WriteLiteral("\r\n\r\n        });\r\n\r\n         $(function () {\r\n             $(\'input#partialView\').click(function () {\r\n                //var id = $(this).data(\'assigned-id\');\r\n                var route = \'");
#nullable restore
#line 142 "D:\S\CORE APP\DotnetCore_Videos\Learning\BookLibrary\BookLibrary\Views\Usage\AddNewUsage.cshtml"
                        Write(Url.Action("Employee", "Usage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                $(\'#partial\').load(route);\r\n            });\r\n\r\n        });\r\n        </script>\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookLibrary.Models.Bhagyastorage>> Html { get; private set; }
    }
}
#pragma warning restore 1591