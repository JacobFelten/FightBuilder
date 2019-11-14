#pragma checksum "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf2913a3482e33e42e8cc3c4c742cd2f7b5824ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DataTables), @"mvc.1.0.view", @"/Views/Home/DataTables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DataTables.cshtml", typeof(AspNetCore.Views_Home_DataTables))]
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
using FightBuilder.Other;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2913a3482e33e42e8cc3c4c742cd2f7b5824ae", @"/Views/Home/DataTables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1c6d1dbec6c5e752624ee5eb9cda19d9e77711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DataTables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Equipment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
  
    ViewData["Title"] = "Data Tables";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
 foreach (Equipment e in Model)
{

#line default
#line hidden
            BeginContext(111, 127, true);
            WriteLiteral("    <div class=\"flex-row\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header text-center\">\r\n                <h3>");
            EndContext();
            BeginContext(239, 6, false);
#line 12 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
               Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(245, 85, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                Type:");
            EndContext();
            BeginContext(331, 6, false);
#line 15 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                Write(e.Type);

#line default
#line hidden
            EndContext();
            BeginContext(337, 37, true);
            WriteLiteral(" <br />\r\n                Description:");
            EndContext();
            BeginContext(375, 13, false);
#line 16 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                       Write(e.Description);

#line default
#line hidden
            EndContext();
            BeginContext(388, 31, true);
            WriteLiteral(" <br />\r\n                Color:");
            EndContext();
            BeginContext(420, 7, false);
#line 17 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                 Write(e.Color);

#line default
#line hidden
            EndContext();
            BeginContext(427, 41, true);
            WriteLiteral(" <br />\r\n                Physical Damage:");
            EndContext();
            BeginContext(469, 9, false);
#line 18 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                           Write(e.PhysDam);

#line default
#line hidden
            EndContext();
            BeginContext(478, 38, true);
            WriteLiteral(" <br />\r\n                Magic Damage:");
            EndContext();
            BeginContext(517, 8, false);
#line 19 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                        Write(e.MagDam);

#line default
#line hidden
            EndContext();
            BeginContext(525, 37, true);
            WriteLiteral(" <br />\r\n                Fire Damage:");
            EndContext();
            BeginContext(563, 9, false);
#line 20 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                       Write(e.FireDam);

#line default
#line hidden
            EndContext();
            BeginContext(572, 42, true);
            WriteLiteral(" <br />\r\n                Physical Defence:");
            EndContext();
            BeginContext(615, 9, false);
#line 21 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                            Write(e.PhysDef);

#line default
#line hidden
            EndContext();
            BeginContext(624, 39, true);
            WriteLiteral(" <br />\r\n                Magic Defence:");
            EndContext();
            BeginContext(664, 8, false);
#line 22 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                         Write(e.MagDef);

#line default
#line hidden
            EndContext();
            BeginContext(672, 38, true);
            WriteLiteral(" <br />\r\n                Fire Defence:");
            EndContext();
            BeginContext(711, 9, false);
#line 23 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
                        Write(e.FireDef);

#line default
#line hidden
            EndContext();
            BeginContext(720, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\Jacob\Documents\Lane Stuff\CS295N\TermProject\FightBuilder\FightBuilder\Views\Home\DataTables.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Equipment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
