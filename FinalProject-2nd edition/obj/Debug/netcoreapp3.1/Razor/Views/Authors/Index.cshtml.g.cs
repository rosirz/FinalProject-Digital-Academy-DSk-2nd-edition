#pragma checksum "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda8fdaec141380a2bc8a934f3112fd820031dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Index), @"mvc.1.0.view", @"/Views/Authors/Index.cshtml")]
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
#line 1 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\_ViewImports.cshtml"
using FinalProject_2nd_edition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\_ViewImports.cshtml"
using FinalProject_2nd_edition.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda8fdaec141380a2bc8a934f3112fd820031dc7", @"/Views/Authors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb19ff728417af6d3dfc0e665abcaebf21fc033b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProject_2nd_edition.Models.AuthorViewModel_List>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Authors</h1>\r\n");
#nullable restore
#line 9 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
 if ((await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda8fdaec141380a2bc8a934f3112fd820031dc75460", async() => {
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
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 14 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Search by name: ");
#nullable restore
#line 18 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                   Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
#nullable restore
#line 21 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
         foreach (var item in Model.List)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td>\r\n                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda8fdaec141380a2bc8a934f3112fd820031dc78274", async() => {
#nullable restore
#line 31 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                                  WriteLiteral(item.AuthorId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </div>\r\n\r\n                </td>\r\n                 <td>\r\n                    \r\n                    ");
#nullable restore
#line 37 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                </td>\r\n                <td>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                     if ((await AuthorizationService.AuthorizeAsync(User, "RequireAdministratorRole")).Succeeded)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda8fdaec141380a2bc8a934f3112fd820031dc711698", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                               WriteLiteral(item.AuthorId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda8fdaec141380a2bc8a934f3112fd820031dc713940", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                                 WriteLiteral(item.AuthorId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"...\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 55 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
         if (Model.CurrentPage == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\" tabindex=\"-1\">Previous</a>\r\n            </li>\r\n");
#nullable restore
#line 60 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1823, "\"", 1879, 2);
            WriteAttributeValue("", 1830, "/Authors/Index?currentPage=", 1830, 27, true);
#nullable restore
#line 64 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
WriteAttributeValue("", 1857, Model.CurrentPage-1, 1857, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">Previous</a>\r\n            </li>\r\n");
#nullable restore
#line 66 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
         for (int i = 0; i < Model.TotalPages; i++)
        {
            if (i + 1 == Model.CurrentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2150, "\"", 2192, 2);
            WriteAttributeValue("", 2157, "/Authors/Index?currentPage=", 2157, 27, true);
#nullable restore
#line 72 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
WriteAttributeValue("", 2184, i + 1, 2184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                                                                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 74 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2376, "\"", 2418, 2);
            WriteAttributeValue("", 2383, "/Authors/Index?currentPage=", 2383, 27, true);
#nullable restore
#line 77 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
WriteAttributeValue("", 2410, i + 1, 2410, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
                                                                                                  Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 78 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
         if (Model.CurrentPage == Model.TotalPages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\">Next</a>\r\n            </li>\r\n");
#nullable restore
#line 86 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2759, "\"", 2815, 2);
            WriteAttributeValue("", 2766, "/Authors/Index?currentPage=", 2766, 27, true);
#nullable restore
#line 90 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
WriteAttributeValue("", 2793, Model.CurrentPage+1, 2793, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n            </li>\r\n");
#nullable restore
#line 92 "C:\Users\Rositsa\Documents\Digital Academy\Programming\Web\FinalProject-2nd edition\FinalProject-2nd edition\Views\Authors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</nav>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProject_2nd_edition.Models.AuthorViewModel_List> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
