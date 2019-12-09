#pragma checksum "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac5bed3d6c4669c1cdeb572522c1a977b3c67f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\_ViewImports.cshtml"
using FightBuilder;

#line default
#line hidden
#line 2 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\_ViewImports.cshtml"
using FightBuilder.Models;

#line default
#line hidden
#line 3 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\_ViewImports.cshtml"
using FightBuilder.Repositories;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac5bed3d6c4669c1cdeb572522c1a977b3c67f4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1f99e82ff4933a4c614c8d0b0b653bb025b946", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Equipment Picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

    string hidden = "hidden";
    if (Model.Winners.Count > 0 || Model.Losers.Count > 0)
    {
        hidden = "";
    }

    string pic = "";
    string hidden2 = "hidden";
    if (Model.RandomEquipment != null)
    {
        pic = Logic.GenerateEquipmentPic(Model.RandomEquipment);
        hidden2 = "";
    }

#line default
#line hidden
            BeginContext(387, 988, true);
            WriteLiteral(@"
<div class=""jumbotron text-center"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-8"">
            <h1>Welcome to Fight Builder!</h1>
            <h6>Here you can create numerous fighters and pit them
            against each other to see who is stronger. Whether or
            not a fighter wins a battle is determined by what equipment
            they are wearing. Start by making some equipment on the
            <i>Design Equipment</i> page and then make some fighters to wear
            the equipment on the <i>Build a Fighter</i> page. Then head over
            to the <i>Fight!</i> page and pick two fighters that will go
            head to head. To see everything you’ve made or delete
            any fighters or equipment, go to the <i>Data Tables</i> page.</h6>
        </div>
        <div class=""col-2""></div>
    </div>
</div>

<div class=""row"">
    <div class=""col-1""></div>
    <div class=""col-4"">
        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1375, "\"", 1405, 3);
            WriteAttributeValue("", 1383, "card", 1383, 4, true);
            WriteAttributeValue(" ", 1387, "container", 1388, 10, true);
#line 43 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1397, hidden, 1398, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1406, 194, true);
            WriteLiteral(">\r\n            <div class=\"card-header\">\r\n                <h4>Leader Board</h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h3 class=\"text-center\">Most Wins</h3>\r\n");
            EndContext();
#line 49 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                 foreach (Fighter f in Model.Winners)
                {

#line default
#line hidden
            BeginContext(1674, 218, true);
            WriteLiteral("                    <div class=\"text-center\">\r\n                        <span class=\"font-weight-bold\">- - - - -<br /></span>\r\n                    </div>\r\n                    <div>\r\n                        <b>Name:</b> ");
            EndContext();
            BeginContext(1893, 6, false);
#line 55 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                Write(f.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 45, true);
            WriteLiteral("<br />\r\n                        <b>Wins:</b> ");
            EndContext();
            BeginContext(1945, 6, false);
#line 56 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                Write(f.Wins);

#line default
#line hidden
            EndContext();
            BeginContext(1951, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 58 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2000, 82, true);
            WriteLiteral("                <br />\r\n                <h3 class=\"text-center\">Most Losses</h3>\r\n");
            EndContext();
#line 61 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                 foreach (Fighter f in Model.Losers)
                {

#line default
#line hidden
            BeginContext(2155, 218, true);
            WriteLiteral("                    <div class=\"text-center\">\r\n                        <span class=\"font-weight-bold\">- - - - -<br /></span>\r\n                    </div>\r\n                    <div>\r\n                        <b>Name:</b> ");
            EndContext();
            BeginContext(2374, 6, false);
#line 67 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                Write(f.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 47, true);
            WriteLiteral("<br />\r\n                        <b>Losses:</b> ");
            EndContext();
            BeginContext(2428, 8, false);
#line 68 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                  Write(f.Losses);

#line default
#line hidden
            EndContext();
            BeginContext(2436, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 70 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2485, 116, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-2\"></div>\r\n    <div class=\"col-4\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2601, "\"", 2632, 3);
            WriteAttributeValue("", 2609, "card", 2609, 4, true);
            WriteAttributeValue(" ", 2613, "container", 2614, 10, true);
#line 76 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2623, hidden2, 2624, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2633, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 77 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
             if (Model.RandomEquipment != null)
            {

#line default
#line hidden
            BeginContext(2700, 199, true);
            WriteLiteral("                <div class=\"card-header\">\r\n                    <h4>Random Equipment</h4>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"text-center\">");
            EndContext();
            BeginContext(2900, 26, false);
#line 83 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                       Write(Model.RandomEquipment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2926, 27, true);
            WriteLiteral("</h3>\r\n                    ");
            EndContext();
            BeginContext(2953, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fac5bed3d6c4669c1cdeb572522c1a977b3c67f411562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2975, "~/Images/", 2975, 9, true);
#line 84 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2984, pic, 2984, 4, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3016, 42, true);
            WriteLiteral("\r\n                    <b>Description:</b> ");
            EndContext();
            BeginContext(3059, 33, false);
#line 85 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                   Write(Model.RandomEquipment.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3092, 62, true);
            WriteLiteral(" <br /> \r\n                    <b>Physical Damage/Defense:</b> ");
            EndContext();
            BeginContext(3155, 29, false);
#line 86 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                               Write(Model.RandomEquipment.PhysDam);

#line default
#line hidden
            EndContext();
            BeginContext(3184, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3186, 29, false);
#line 86 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                                                              Write(Model.RandomEquipment.PhysDef);

#line default
#line hidden
            EndContext();
            BeginContext(3215, 57, true);
            WriteLiteral("<br />\r\n                    <b>Magic Damage/Defense:</b> ");
            EndContext();
            BeginContext(3273, 28, false);
#line 87 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                            Write(Model.RandomEquipment.MagDam);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3303, 28, false);
#line 87 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                                                          Write(Model.RandomEquipment.MagDef);

#line default
#line hidden
            EndContext();
            BeginContext(3331, 56, true);
            WriteLiteral("<br />\r\n                    <b>Fire Damage/Defense:</b> ");
            EndContext();
            BeginContext(3388, 29, false);
#line 88 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                           Write(Model.RandomEquipment.FireDam);

#line default
#line hidden
            EndContext();
            BeginContext(3417, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3419, 29, false);
#line 88 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
                                                                          Write(Model.RandomEquipment.FireDef);

#line default
#line hidden
            EndContext();
            BeginContext(3448, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 90 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3489, 65, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-1\"></div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
