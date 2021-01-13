#pragma checksum "C:\Users\lukeg\Documents\GitHub\Highfield\ExamInvigilatorProject\ExamInvigilatorProject\Pages\LoggedIn\Exam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a254cb3fa2bb7efcdb2c551e382db229b263db5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExamInvigilatorProject.Pages.LoggedIn.Pages_LoggedIn_Exam), @"mvc.1.0.razor-page", @"/Pages/LoggedIn/Exam.cshtml")]
namespace ExamInvigilatorProject.Pages.LoggedIn
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
#line 1 "C:\Users\lukeg\Documents\GitHub\Highfield\ExamInvigilatorProject\ExamInvigilatorProject\Pages\_ViewImports.cshtml"
using ExamInvigilatorProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a254cb3fa2bb7efcdb2c551e382db229b263db5", @"/Pages/LoggedIn/Exam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445f110198505bc186245420e857ac6cf81ec239", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoggedIn_Exam : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
#line 3 "C:\Users\lukeg\Documents\GitHub\Highfield\ExamInvigilatorProject\ExamInvigilatorProject\Pages\LoggedIn\Exam.cshtml"
  
    ViewData["Title"] = "Exam";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a254cb3fa2bb7efcdb2c551e382db229b263db53401", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Highfield Education - Exam Invigilation Software Login </title>

    <!-- links and includes-->
    <!-- links and includes-->
    <link href=""../../wwwroot/css/styles.css"" rel=""stylesheet"" />
    <link href=""../../wwwroot/lib/css/bootstrap/css/dist/bootstrap-grid.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.1/css/all.css"">

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a254cb3fa2bb7efcdb2c551e382db229b263db54895", async() => {
                WriteLiteral(@"


    <div class=""mainContent"">

    <div class=""mainContent"">

        <div class=""leftPanel"">
            <div class=""leftPanelViews"">

                <div class=""viewBoxSmall"">
                    <i class=""fas fa-user-graduate fa-8x""></i>
                </div>
                <div class=""viewBoxSmall"">
                    <i class=""fas fa-user-graduate fa-8x""></i>
                </div>
                <div class=""viewBoxSmall"">
                    <i class=""fas fa-user-graduate fa-8x""></i>
                </div>
                <div class=""viewBoxSmall"">
                    <i class=""fas fa-user-graduate fa-8x""></i>
                </div>       

            </div>

            <!-------------------------------------------------- Buttons -------------------------------------------------------->
            <div class=""actionBtn"">
                <button class=""startBtn"">Start Exam</button>

                <button class=""endBtn"">End Exam </button> <!-- only shown if exam h");
                WriteLiteral(@"as started, otherwise show start button -->
            </div>

            <div class=""timer"">
                    <!-- space here for countdown timer for exam-->
            </div>
        </div>
        <div class=""rightPanel"">
            <div class=""rightPanelMain"">

            </div>
            <div class=""rightPanelOptions"">
                <div class=""rightPanelOptionItems"">
                    <button class=""addNotes"">Add Notes</button> <!-- If no notes exist yet, show add notes button -->

                    <button class=""editNotes"">Edit Notes</button>   <!-- This button will need to be  coded so that if a notes record already exists, edit is shown instead of add: change css display: none etc.-->
                </div>

                <div class=""rightPanelOptionItems"">
                    <button class=""mute"">Mute/Unmute</button> <!-- optional addition - mute/unmute microphone to chat with the selected person-->
                </div>

                <div class=""rightPan");
                WriteLiteral("elOptionItems\">\r\n                    <button class=\"endforThis\">End for this Learner</button> <!-- End Exam For This Learner-->\r\n                </div>\r\n\r\n            </div>\r\n            \r\n        </div>\r\n   </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExamModel>)PageContext?.ViewData;
        public ExamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
