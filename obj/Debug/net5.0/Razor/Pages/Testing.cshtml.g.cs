#pragma checksum "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6209921114b1287e2a4a90613776dd09aa482226"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(covidwatch.Pages.Pages_Testing), @"mvc.1.0.razor-page", @"/Pages/Testing.cshtml")]
namespace covidwatch.Pages
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
#line 1 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\_ViewImports.cshtml"
using covidwatch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6209921114b1287e2a4a90613776dd09aa482226", @"/Pages/Testing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db27c92baa2b1f71a632b9dfe1719784bc8ca30", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Testing : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
  
    ViewData["Title"] = "Testing";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6209921114b1287e2a4a90613776dd09aa4822263634", async() => {
                WriteLiteral(@"
    <div class=""body"">
        <p>This is where the main service will be.</p></br>
        <p>Once databases are configured then we will make it so users can browse different regions, and login to save
            their preferences. Until then, this chart is provided by <button class=""clickable-element""
                onclick=""window.open('https://resources-covid19canada.hub.arcgis.com/pages/media')"" target=""_blank"">Esri
                Canada.</button></label></p></br>
        <div class=""chart"">
            <!-- <iframe src=""https://covid19canada.maps.arcgis.com/apps/opsdashboard/index.html#/cfbd8528810042d38d4e184e6731f2f9"" height=""550"" width=""100%""></iframe>
             <iframe src=""https://covid19canada.maps.arcgis.com/apps/opsdashboard/index.html#/2772c0489f43411ca9493fc5888fbe67"" height=""550"" width=""100%""></iframe> 
               <iframe src=""https://covid19canada.maps.arcgis.com/apps/Minimalist/index.html?appid=b3baccb0f30e4516b8e64009b3383f55"" height=""500"" width=""100%""></iframe>
      ");
                WriteLiteral(@"      <iframe
                src=""https://covid19canada.maps.arcgis.com/apps/Minimalist/index.html?appid=b3baccb0f30e4516b8e64009b3383f55""
                height=""500"" width=""100%""></iframe> -->
        </div>
    </div>
    <div class=""container""> <!-- **This is for testing the username/password Model, please don't touch :) -->
        <div class=""card border-secondary"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-header"">Add user to DB... (in progress)</div>

                </div>
            </div>
            <div class=""card-header""><b>Users in database:</b> </div>
            <div class=""row"">
");
#nullable restore
#line 34 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
             foreach (var pers in Model.Users)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-sm\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <h4 class=\"card-header\">");
#nullable restore
#line 39 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                   Write(pers.UID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 40 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                Write(pers.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 41 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                Write(pers.Password);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <div class=\"card-header\"><b>Assessment centers in database: </b></div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 49 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
             foreach (var assess in Model.AssessmentCenters)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-sm\">\r\n                        <div class=\"card\">\r\n                            <div class=\"card-body\">\r\n                                <h4 class=\"card-header\">");
#nullable restore
#line 54 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                   Write(assess.location_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 55 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                Write(assess.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 56 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                Write(assess.phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 57 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                                                Write(assess.city);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\Users\Administrator\Documents\GitHub\cv19project\Pages\Testing.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestingModel>)PageContext?.ViewData;
        public TestingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
