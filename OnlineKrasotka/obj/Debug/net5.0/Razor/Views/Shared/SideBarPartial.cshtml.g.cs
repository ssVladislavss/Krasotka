#pragma checksum "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\SideBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ef47499b5a28d769df3fb899794285aa02ea6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SideBarPartial), @"mvc.1.0.view", @"/Views/Shared/SideBarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ef47499b5a28d769df3fb899794285aa02ea6e", @"/Views/Shared/SideBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1156f1ead2bb4d6394835fc03c17a69d3ff66052", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SideBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 2 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\SideBarPartial.cshtml"
Write(await Component.InvokeAsync<SiderbarViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
