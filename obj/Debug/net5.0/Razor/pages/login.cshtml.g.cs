#pragma checksum "C:\Users\Administrator\Documents\GitHub\cv19project\pages\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc87a0626624a35162da84146eb697f431efc95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.pages_login), @"mvc.1.0.razor-page", @"/pages/login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc87a0626624a35162da84146eb697f431efc95", @"/pages/login.cshtml")]
    public class pages_login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("log"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\GitHub\cv19project\pages\login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc87a0626624a35162da84146eb697f431efc953192", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <script type=\'text/javascript\'>\r\n            function coming_soon()\r\n            {\r\n                alert(\"Coming soon!\")\r\n            }\r\n    \r\n        </script>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fc87a0626624a35162da84146eb697f431efc954391", async() => {
                WriteLiteral(@"
             <div class=""container"">
            <form class=""form"" id=""login"">
                <h1 class=""form__title"">Login</h1>
                <div class=""form__message form__message--error""></div>
                <div class=""form__input-group"">
                    <input type=""text"" class=""form__input"" autofocus placeholder=""Username or email"">
                    <div class=""form__input-error-message""></div>
                </div>
                <div class=""form__input-group"">
                    <input type=""password"" class=""form__input"" autofocus placeholder=""Password"">
                    <div class=""form__input-error-message""></div>
                </div>
                <button class=""form__button"" type=""submit"">Continue</button>
                <p class=""form__text"">
                    <a href=""#"" class=""form__link"">Forgot your password?</a>
                </p>
                <p class=""form__text"">
                    <a class=""form__link"" href=""./"" id=""linkCreateAccount"">Do");
                WriteLiteral(@"n't have an account? Create account</a>
                </p>
            </form>
            <form class=""form form--hidden"" id=""createAccount"">
                <h1 class=""form__title"">Create Account</h1>
                <div class=""form__message form__message--error""></div>
                <div class=""form__input-group"">
                    <input type=""text"" id=""signupUsername"" class=""form__input"" autofocus placeholder=""Username"">
                    <div class=""form__input-error-message""></div>
                </div>
                <div class=""form__input-group"">
                    <input type=""text"" class=""form__input"" autofocus placeholder=""Email Address"">
                    <div class=""form__input-error-message""></div>
                </div>
                <div class=""form__input-group"">
                    <input type=""password"" class=""form__input"" autofocus placeholder=""Password"">
                    <div class=""form__input-error-message""></div>
                </div>
           ");
                WriteLiteral(@"     <div class=""form__input-group"">
                    <input type=""password"" class=""form__input"" autofocus placeholder=""Confirm password"">
                    <div class=""form__input-error-message""></div>
                </div>
                <button class=""form__button"" type=""submit"">Continue</button>
                <p class=""form__text"">
                    <a class=""form__link"" href=""./"" id=""linkLogin"">Already have an account? Sign in</a>
                </p>
            </form>
        </div>
        <script src=""site.js""></script>
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cv19project.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cv19project.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<cv19project.Pages.LoginModel>)PageContext?.ViewData;
        public cv19project.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
