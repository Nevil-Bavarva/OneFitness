#pragma checksum "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ccf329fc7c59c6186202f91d75065ce3410472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideMenu/Default.cshtml")]
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
#line 1 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\_ViewImports.cshtml"
using OneFitnessVue.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\_ViewImports.cshtml"
using OneFitnessVue.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
using OneFitnessVue.Data.MenuMaster.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
using OneFitnessVue.Web.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ccf329fc7c59c6186202f91d75065ce3410472", @"/Views/Shared/Components/SideMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd84cc865654477ad3dcff4234ef1d21e0b1355", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OneFitnessVue.Model.MenuCategory.MenuCategoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            WriteLiteral("\n<nav class=\"mt-2\">\n    <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\n\n        <li class=\"nav-header\">PAGES</li>\n\n");
#nullable restore
#line 13 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
         foreach (var menucategory in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item has-treeview\">\n                <a href=\"javascript:void(0);\" class=\"nav-link\">\n                    <i class=\"nav-icon fas fa-book\"></i>\n                    <p>\n                        ");
#nullable restore
#line 19 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                   Write(menucategory.MenuCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <i class=\"right fas fa-angle-left\"></i>\n                    </p>\n                </a>\n\n");
#nullable restore
#line 24 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                 if (MenuMaster != null && MenuMaster.GetMenuByRoleId(menucategory.RoleId, menucategory.MenuCategoryId).Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"nav nav-treeview\">\n\n");
#nullable restore
#line 28 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                         foreach (var menu in MenuMaster.GetMenuByRoleId(menucategory.RoleId, menucategory.MenuCategoryId))
                        {

                            if (!string.IsNullOrEmpty(menu.Area))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"nav-item\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ccf329fc7c59c6186202f91d75065ce34104726171", async() => {
                WriteLiteral("\n                                        <i class=\"far fa-circle nav-icon\"></i>\n                                        <p>\n                                            ");
#nullable restore
#line 37 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                       Write(menu.MenuName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        </p>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                     WriteLiteral(menu.Area);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                                                 WriteLiteral(menu.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                                                                                   WriteLiteral(menu.ActionMethod);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1407, "nav-link", 1407, 8, true);
#nullable restore
#line 34 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
AddHtmlAttributeValue(" ", 1415, Url.MakeActiveClass(menu.ControllerName, menu.ActionMethod), 1416, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </li>\n");
#nullable restore
#line 41 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"nav-item\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ccf329fc7c59c6186202f91d75065ce341047210968", async() => {
                WriteLiteral("\n                                        <i class=\"far fa-circle nav-icon\"></i>\n                                        <p>\n                                            ");
#nullable restore
#line 48 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                       Write(menu.MenuName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        </p>\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                                       WriteLiteral(menu.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                                                                                         WriteLiteral(menu.ActionMethod);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2060, "nav-link", 2060, 8, true);
#nullable restore
#line 45 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
AddHtmlAttributeValue(" ", 2068, Url.MakeActiveClass(menu.ControllerName, menu.ActionMethod), 2069, 60, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </li>\n");
#nullable restore
#line 52 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                            }
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </ul>\n");
#nullable restore
#line 57 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\n");
#nullable restore
#line 59 "E:\Poj\OneFitnessVue-main\OneFitnessVueSolution\OneFitnessVue.Web\Views\Shared\Components\SideMenu\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n    </ul>\n</nav>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMenuMasterQueries MenuMaster { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OneFitnessVue.Model.MenuCategory.MenuCategoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591