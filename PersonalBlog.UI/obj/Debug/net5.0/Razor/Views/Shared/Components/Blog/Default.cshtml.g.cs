#pragma checksum "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497c52fa1fdb8b2a7ba368cbdb5906431d4048fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Blog/Default.cshtml")]
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
#line 2 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using PersonalBlog.Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using PersonalBlog.Entities.ComplexType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497c52fa1fdb8b2a7ba368cbdb5906431d4048fb", @"/Views/Shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c654c1da404f3eb1ef48d035e33750fcbc726a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
   string culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"py-5 border-bottom wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n    <h1 class=\"title pb-3 mb-5\">");
#nullable restore
#line 5 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
                           Write(localizer["blogs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"owl-carousel testimonial-carousel\">\r\n");
#nullable restore
#line 7 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-left\">\r\n            <i class=\"fa fa-3x fa-quote-left text-primary mb-4\"></i>\r\n");
#nullable restore
#line 11 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
             if (culture == "tr")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>");
#nullable restore
#line 13 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
               Write(item.TitleTr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"fs-4 mb-4\">");
#nullable restore
#line 14 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
                                Write(item.DescriptionTR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>");
#nullable restore
#line 18 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
               Write(item.TitleEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"fs-4 mb-4\">");
#nullable restore
#line 19 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
                                Write(item.DescriptionEN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Blog\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<PersonalBlog.UI.SharedResource> localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591