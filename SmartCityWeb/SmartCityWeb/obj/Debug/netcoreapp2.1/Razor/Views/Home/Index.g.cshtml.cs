#pragma checksum "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "435f116cb83a6dce4a61855f012e540cdb3cc972"
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
#line 1 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\_ViewImports.cshtml"
using SmartCityWeb;

#line default
#line hidden
#line 2 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\_ViewImports.cshtml"
using SmartCityWeb.Models;

#line default
#line hidden
#line 13 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435f116cb83a6dce4a61855f012e540cdb3cc972", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ee7a5d102347063e72e245dc193eb4a9b06fda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("createbutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Locations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sensors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Trees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/location-index-vue.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 138, true);
            WriteLiteral("<br/>\r\n\r\n\r\n<div id=\"vueApp\" class=\"transparent\">\r\n\r\n    <div>\r\n        <h1 class=\"headline\">Welcome to Smart City Web</h1>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(282, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(333, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 17 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(382, 48, true);
            WriteLiteral("        <div class=\"flexboxclass\">\r\n            ");
            EndContext();
            BeginContext(430, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f34daedaa0450084174ff1ff280a4b", async() => {
                BeginContext(501, 19, true);
                WriteLiteral("Create New location");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(524, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(525, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ff9e6abf6004e8580e01432ae8bbceb", async() => {
                BeginContext(594, 17, true);
                WriteLiteral("Create new sensor");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(616, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4a3d1801da46268b216acc1db10f28", async() => {
                BeginContext(683, 21, true);
                WriteLiteral("Create new tree group");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(708, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(730, 198, true);
            WriteLiteral("        <div class=\"flexboxclass\">\r\n            <input class=\"searchbox\" type=\"text\" v-model=\"searchbox\" placeholder=\"Type in name to search for\" v-on:change=\"searchLocations()\" />\r\n        </div>\r\n");
            EndContext();
            BeginContext(930, 1722, true);
            WriteLiteral(@"        <h3 class=""h3class2"">Locations</h3>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Location ID
                    </th>
                    <th>
                        Location Name
                    </th>
                    <th>
                        Road Name
                    </th>
                    <th>
                        Road Number
                    </th>
                    <th>
                        Zip Code
                    </th>
                    <th>
                        City
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>

                <tr v-for=""item in searchlocations"">
                    <td>
                        {{item.locationID}}
                    </td>
                    <td>
                        {{item.name}}
                    </td>
                    <td>
      ");
            WriteLiteral(@"                  {{item.roadName}}
                    </td>
                    <td>
                        {{item.roadNumber}}
                    </td>
                    <td>
                        {{item.zipCode}}
                    </td>
                    <td>
                        {{item.city}}
                    </td>
                    <td>
                        <button v-on:click=""showSensorsfunction(item.locationID)"">View data</button>
                        <button v-on:click=""deletelocation(item.locationID)"">Delete location</button>
                        
                    </td>
                </tr>

            </tbody>
        </table>
");
            EndContext();
            BeginContext(2654, 62, true);
            WriteLiteral("        <h3 class=\"h3class2\" v-if=\"showsensors\">Sensors</h3>\r\n");
            EndContext();
            BeginContext(2718, 1097, true);
            WriteLiteral(@"        <table class=""table"" v-if=""showsensors"">
            <thead>
            <tr>
                <th>
                    Hexadecimal ID
                </th>
                <th>
                    Tree Sort
                </th>
                <th>
                    GPS Langitude
                </th>
                <th>
                    GPS Longitude
                </th>
                <th></th>
            </tr>
            </thead>
            <tbody>

            <tr v-for=""sensor in specificSensors"">
                <td>
                    {{sensor.hexaDecimalID}}
                </td>
                <td>
                    {{sensor.treeSort}}
                </td>
                <td>
                    {{sensor.gpsLan}}
                </td>
                <td>
                    {{sensor.gpsLon}}
                </td>
                <td>
                    <button v-on:click=""deleteSensor(sensor.sensorID)"">Delete sensor</button>
             ");
            WriteLiteral("   </td>\r\n\r\n            </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
            BeginContext(3817, 895, true);
            WriteLiteral(@"        <h3 class=""h3class2"" v-if=""showsensors"">Trees</h3>
        <table class=""table"" v-if=""showTrees"">
            <thead>
                <tr>
                    <th>
                        Tree sort
                    </th>
                    <th>
                        Number of trees
                    </th>

                    <th></th>
                </tr>
            </thead>
            <tbody>

                <tr v-for=""tree in specificTrees"">
                    <td>
                        {{tree.treeSort}}
                    </td>
                    <td>
                        {{tree.numberOfTrees}}
                    </td>
                    <td>
                        <button v-on:click=""deleteTree(tree.treeID)"">Delete trees</button>
                    </td>

                </tr>

            </tbody>
        </table>
");
            EndContext();
#line 159 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4736, 76, true);
            WriteLiteral("        <h3 class=\"h3class\"> Please sign in to use the Smart City Web</h3>\r\n");
            EndContext();
#line 163 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4819, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4845, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4851, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d76f647e9f64261ab15dcd6247a651e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 166 "C:\EksamenGUI\SmartCityWeb\SmartCityWeb\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4927, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
