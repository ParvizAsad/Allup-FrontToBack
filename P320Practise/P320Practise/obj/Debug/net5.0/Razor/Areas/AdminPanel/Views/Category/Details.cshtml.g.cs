#pragma checksum "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a777f68684394b72d7dfb94a206106acf49c5296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Category_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Category/Details.cshtml")]
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
#line 1 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\_ViewImports.cshtml"
using P320Practise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\_ViewImports.cshtml"
using P320Practise.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a777f68684394b72d7dfb94a206106acf49c5296", @"/Areas/AdminPanel/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfae922d79a50dff857f9144f82846669976b0b0", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminPanel_Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 11 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                                  Write(Html.Raw(@Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 12 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                 if (Model.IsMain)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a777f68684394b72d7dfb94a206106acf49c52965009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 356, "~/assets/images/", 356, 16, true);
#nullable restore
#line 14 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
AddHtmlAttributeValue("", 372, Model.Image, 372, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>Children: </p>\r\n                    <ul>\r\n");
#nullable restore
#line 17 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                         foreach (var item in Model.Children)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <li>");
#nullable restore
#line 19 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 20 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 22 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Parent: ");
#nullable restore
#line 25 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                          Write(Model.Parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "D:\P320\4. ASP .NET\2. MVC\16. 01032022 SelfJpin Created, Deleted\Allup-FronToBack\P320Practise\P320Practise\Areas\AdminPanel\Views\Category\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
