#pragma checksum "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f8c653dac57991801aa11c5e8424b0643f98cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FighterTable), @"mvc.1.0.view", @"/Views/Home/FighterTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FighterTable.cshtml", typeof(AspNetCore.Views_Home_FighterTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f8c653dac57991801aa11c5e8424b0643f98cd", @"/Views/Home/FighterTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1f99e82ff4933a4c614c8d0b0b653bb025b946", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FighterTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fighter>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
  
    ViewData["Title"] = "Fighter Table";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
 foreach (Fighter f in Model)
{

#line default
#line hidden
            BeginContext(109, 127, true);
            WriteLiteral("    <div class=\"flex-row\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header text-center\">\r\n                <h3>");
            EndContext();
            BeginContext(237, 6, false);
#line 12 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
               Write(f.Name);

#line default
#line hidden
            EndContext();
            BeginContext(243, 83, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                Id:");
            EndContext();
            BeginContext(327, 11, false);
#line 15 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
              Write(f.FighterID);

#line default
#line hidden
            EndContext();
            BeginContext(338, 37, true);
            WriteLiteral(" <br />\r\n                Description:");
            EndContext();
            BeginContext(376, 13, false);
#line 16 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                       Write(f.Description);

#line default
#line hidden
            EndContext();
            BeginContext(389, 31, true);
            WriteLiteral(" <br />\r\n                Color:");
            EndContext();
            BeginContext(421, 7, false);
#line 17 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                 Write(f.Color);

#line default
#line hidden
            EndContext();
            BeginContext(428, 30, true);
            WriteLiteral(" <br />\r\n                Head:");
            EndContext();
            BeginContext(460, 43, false);
#line 18 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                 Write(f["Head"] != null ? f["Head"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(504, 31, true);
            WriteLiteral(" <br />\r\n                Chest:");
            EndContext();
            BeginContext(537, 45, false);
#line 19 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                  Write(f["Chest"] != null ? f["Chest"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(583, 31, true);
            WriteLiteral(" <br />\r\n                Pants:");
            EndContext();
            BeginContext(616, 45, false);
#line 20 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                  Write(f["Pants"] != null ? f["Pants"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(662, 31, true);
            WriteLiteral(" <br />\r\n                Shoes:");
            EndContext();
            BeginContext(695, 45, false);
#line 21 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                  Write(f["Shoes"] != null ? f["Shoes"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(741, 32, true);
            WriteLiteral(" <br />\r\n                Gloves:");
            EndContext();
            BeginContext(775, 47, false);
#line 22 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                   Write(f["Gloves"] != null ? f["Gloves"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(823, 30, true);
            WriteLiteral(" <br />\r\n                Ring:");
            EndContext();
            BeginContext(855, 43, false);
#line 23 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                 Write(f["Ring"] != null ? f["Ring"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(899, 36, true);
            WriteLiteral(" <br />\r\n                Right Hand:");
            EndContext();
            BeginContext(937, 55, false);
#line 24 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                       Write(f["Right Hand"] != null ? f["Right Hand"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(993, 35, true);
            WriteLiteral(" <br />\r\n                Left Hand:");
            EndContext();
            BeginContext(1030, 53, false);
#line 25 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                      Write(f["Left Hand"] != null ? f["Left Hand"].Name : "None");

#line default
#line hidden
            EndContext();
            BeginContext(1084, 30, true);
            WriteLiteral(" <br />\r\n                Wins:");
            EndContext();
            BeginContext(1115, 6, false);
#line 26 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                Write(f.Wins);

#line default
#line hidden
            EndContext();
            BeginContext(1121, 32, true);
            WriteLiteral(" <br />\r\n                Losses:");
            EndContext();
            BeginContext(1154, 8, false);
#line 27 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
                  Write(f.Losses);

#line default
#line hidden
            EndContext();
            BeginContext(1162, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\FighterTable.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fighter>> Html { get; private set; }
    }
}
#pragma warning restore 1591