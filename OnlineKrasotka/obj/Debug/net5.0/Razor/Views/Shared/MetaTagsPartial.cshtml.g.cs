#pragma checksum "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b603055b32af3f56392e2406852353a5d115ebe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetaTagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetaTagsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b603055b32af3f56392e2406852353a5d115ebe5", @"/Views/Shared/MetaTagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1156f1ead2bb4d6394835fc03c17a69d3ff66052", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetaTagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 306, "\"", 336, 1);
#nullable restore
#line 14 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 316, ViewBag.Description, 316, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 405, "\"", 432, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 415, ViewBag.Keywords, 415, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\Все проекты\Пишу проекты\Конечный сайт Красотка\OnlineKrasotka\OnlineKrasotka\Views\Shared\MetaTagsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
