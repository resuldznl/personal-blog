#pragma checksum "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f1ca44bc6fc0be16bce59672278610870e6e58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Skill_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Skill/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f1ca44bc6fc0be16bce59672278610870e6e58", @"/Views/Shared/Components/Skill/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c654c1da404f3eb1ef48d035e33750fcbc726a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Skill_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"py-5 border-bottom wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n    <h1 class=\"title pb-3 mb-5\">");
#nullable restore
#line 3 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
                           Write(localizer["skills"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 6 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
             foreach (var item in Model)
            {
                
                string color = item.Degree <= 50 ? "bg-warning" : "bg-primary";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"skill mb-2\">\r\n                    <div class=\"d-flex justify-content-between\">\r\n                        <p class=\"mb-2\">");
#nullable restore
#line 12 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
                                   Write(item.SkillName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"mb-2\">");
#nullable restore
#line 13 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
                                   Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</p>\r\n                    </div>\r\n                    <div class=\"progress\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 692, "\"", 719, 2);
            WriteAttributeValue("", 700, "progress-bar", 700, 12, true);
#nullable restore
#line 16 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
WriteAttributeValue(" ", 712, color, 713, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 739, "\"", 767, 1);
#nullable restore
#line 16 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
WriteAttributeValue("", 755, item.Degree, 755, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 19 "C:\Users\Resul\source\repos\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\Skill\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
