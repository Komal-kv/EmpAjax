#pragma checksum "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca4271c2fe8cb0d90809c784be507fb710ce973e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee__ViewAll), @"mvc.1.0.view", @"/Views/Employee/_ViewAll.cshtml")]
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
#line 1 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\_ViewImports.cshtml"
using EmpAjaxJquery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\_ViewImports.cshtml"
using EmpAjaxJquery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4271c2fe8cb0d90809c784be507fb710ce973e", @"/Views/Employee/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79b1ee13b04a9eb3634bd02fea97dbfeda89782", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmpAjaxJquery.Models.EmployeeModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n            <h1 class=\"text-center\"> Employee Payroll</h1>\r\n\r\n\r\n        <table class=\"table\">\r\n                <thead class=\"thead-light\">\r\n                    <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 751, "\"", 856, 4);
            WriteAttributeValue("", 761, "showInPopup(\'", 761, 13, true);
#nullable restore
#line 24 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
WriteAttributeValue("", 774, Url.Action("AddEmployee","Employee",null,Context.Request.Scheme), 774, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 839, "\',\'New", 839, 6, true);
            WriteAttributeValue(" ", 845, "Employee\')", 846, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\"><i class=\"fas fa-random\"></i> New Employee</a>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
              foreach (var item in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr>\r\n                     <td>\r\n                         ");
#nullable restore
#line 33 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </td>\r\n                     <td>\r\n                         ");
#nullable restore
#line 36 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </td>\r\n                     <td>\r\n                         ");
#nullable restore
#line 39 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </td>\r\n                     <td>\r\n                         ");
#nullable restore
#line 42 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                     </td>\r\n                     <td>\r\n                         <div>\r\n                              <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1688, "\"", 1812, 4);
            WriteAttributeValue("", 1698, "showInPopup(\'", 1698, 13, true);
#nullable restore
#line 46 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
WriteAttributeValue("", 1711, Url.Action("AddEmployee","Employee",new {id=item.Emp_Id},Context.Request.Scheme), 1711, 81, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1792, "\',\'Update", 1792, 9, true);
            WriteAttributeValue(" ", 1801, "Employee\')", 1802, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\" ></i> Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca4271c2fe8cb0d90809c784be507fb710ce973e9670", async() => {
                WriteLiteral("\r\n                                   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca4271c2fe8cb0d90809c784be507fb710ce973e9963", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Emp_Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                   <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
                                                                    WriteLiteral(item.Emp_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                          </div>\r\n                     </td>\r\n                 </tr>\r\n");
#nullable restore
#line 54 "E:\Git\EmpAjax\EmpAjaxJquery\EmpAjaxJquery\Views\Employee\_ViewAll.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </tbody>\r\n         </table>\r\n    </div>\r\n    \r\n    \r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmpAjaxJquery.Models.EmployeeModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
