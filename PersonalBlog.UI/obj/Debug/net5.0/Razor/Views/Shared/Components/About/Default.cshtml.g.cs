#pragma checksum "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed8b0453b4de909d0348142f15ae8d11d5677cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
#line 2 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using PersonalBlog.Entities.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using PersonalBlog.Entities.ComplexType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed8b0453b4de909d0348142f15ae8d11d5677cd", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c654c1da404f3eb1ef48d035e33750fcbc726a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadCV", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn w-50 border-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
   string culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 sticky-lg-top vh-100\">\r\n    <div class=\"d-flex flex-column h-100 text-center overflow-auto shadow\">\r\n        <img class=\"w-100 img-fluid mb-4\"");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 277, 1);
#nullable restore
#line 5 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
WriteAttributeValue("", 252, Url.Content(Model.Photo), 252, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\">\r\n        <h1 class=\"text-primary mt-2\">");
#nullable restore
#line 6 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                             Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"mb-4\" style=\"height: 22px;\">\r\n            <h4 class=\"typed-text-output d-inline-block text-light\"></h4>\r\n");
#nullable restore
#line 9 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
             if (culture == "tr")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"typed-text d-none\">");
#nullable restore
#line 11 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                          Write(Model.JobTitleTr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"typed-text d-none\">");
#nullable restore
#line 15 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                          Write(Model.JobTitleEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"d-flex justify-content-center mt-auto mb-3\">\r\n            <a class=\"btn btn-secondary btn-square mx-1\"");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 905, 1);
#nullable restore
#line 19 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
WriteAttributeValue("", 891, Model.Twitter, 891, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fab fa-twitter\"></i></a>\r\n            <a class=\"btn btn-secondary btn-square mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1015, "\"", 1037, 1);
#nullable restore
#line 20 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
WriteAttributeValue("", 1022, Model.Facebook, 1022, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fab fa-facebook-f\"></i></a>\r\n            <a class=\"btn btn-secondary btn-square mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1172, 1);
#nullable restore
#line 21 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
WriteAttributeValue("", 1157, Model.LinkedIn, 1157, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fab fa-linkedin-in\"></i></a>\r\n            <a class=\"btn btn-secondary btn-square mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1286, "\"", 1309, 1);
#nullable restore
#line 22 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
WriteAttributeValue("", 1293, Model.Instagram, 1293, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\"fab fa-instagram\"></i></a>\r\n        </div>\r\n        <div class=\"d-flex align-items-end justify-content-between border-top\">\r\n");
#nullable restore
#line 25 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
             if (culture == "tr")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed8b0453b4de909d0348142f15ae8d11d5677cd9969", async() => {
#nullable restore
#line 27 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                                                                                                       Write(localizer["downcv"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CVPath", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                                                       WriteLiteral(Model.CVTr);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CVPath"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CVPath", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CVPath"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed8b0453b4de909d0348142f15ae8d11d5677cd13033", async() => {
#nullable restore
#line 31 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                                                                                                       Write(localizer["downcv"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CVPath", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                                                       WriteLiteral(Model.CVEn);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CVPath"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CVPath", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CVPath"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"#contact\" class=\"btn w-50 btn-scroll\">");
#nullable restore
#line 33 "C:\Users\Resul\Desktop\PersonalBlog\PersonalBlog.UI\Views\Shared\Components\About\Default.cshtml"
                                                      Write(localizer["contactMe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
