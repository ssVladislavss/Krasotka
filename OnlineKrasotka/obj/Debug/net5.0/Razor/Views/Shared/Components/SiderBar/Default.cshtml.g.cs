#pragma checksum "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a51f0bf612bb359c6af282eda3c0089bd24cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SiderBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SiderBar/Default.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\_ViewImports.cshtml"
using OnlineKrasotka.Domain.Entities.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a51f0bf612bb359c6af282eda3c0089bd24cfd", @"/Views/Shared/Components/SiderBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1156f1ead2bb4d6394835fc03c17a69d3ff66052", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SiderBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<ThingItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
 if(Model?.Any() == true)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <section>\r\n           <h2>Наши товары</h2>\r\n           <ul class=\"small-image-list\">\r\n");
#nullable restore
#line 8 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
                foreach(ThingItem item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <li>\r\n                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a51f0bf612bb359c6af282eda3c0089bd24cfd6892", async() => {
                WriteLiteral("\r\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76a51f0bf612bb359c6af282eda3c0089bd24cfd7174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 398, "~/images/", 398, 9, true);
#nullable restore
#line 12 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
AddHtmlAttributeValue("", 407, item.TitleImagesPath, 407, 21, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
                                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                       <h4>");
#nullable restore
#line 14 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                       <p>");
#nullable restore
#line 15 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
                     Write(item.ShortDesk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   </li>\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </ul>\r\n       </section>\r\n");
#nullable restore
#line 20 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\Components\SiderBar\Default.cshtml"
   }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<ThingItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
