#pragma checksum "C:\Users\Samsung\Desktop\StockInAll\src\StockInAll.App\Views\Home\Cards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172b867cba788564af714afae18c9a295a08a8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cards), @"mvc.1.0.view", @"/Views/Home/Cards.cshtml")]
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
#line 11 "C:\Users\Samsung\Desktop\StockInAll\src\StockInAll.App\Views\_ViewImports.cshtml"
using StockInAll.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Samsung\Desktop\StockInAll\src\StockInAll.App\Views\_ViewImports.cshtml"
using StockInAll.App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172b867cba788564af714afae18c9a295a08a8b8", @"/Views/Home/Cards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5132c38412f0bbe5466494ae2a4bb4910a7a02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cards : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Samsung\Desktop\StockInAll\src\StockInAll.App\Views\Home\Cards.cshtml"
  
    ViewData["Title"] = "Cards";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Cards</h1>
    </div>

    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-primary shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                                Earnings (Monthly)
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">$40,000</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                       ");
            WriteLiteral(@" </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Annual) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                                Earnings (Annual)
                            </div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">$215,000</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Tasks Card Example ");
            WriteLiteral(@"-->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">
                                Tasks
                            </div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                                </div>
                                <div class=""col"">
                                    <div class=""progress progress-sm mr-2"">
                                        <div class=""progress-bar bg-info"" role=""progressbar""
                                             style=""width: 50%"" aria-valueno");
            WriteLiteral(@"w=""50"" aria-valuemin=""0""
                                             aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Pending Requests Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                                Pending Requests
                            </div>
       ");
            WriteLiteral(@"                     <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">

        <div class=""col-lg-6"">

            <!-- Default Card Example -->
            <div class=""card mb-4"">
                <div class=""card-header"">
                    Default Card Example
                </div>
                <div class=""card-body"">
                    This card uses Bootstrap's default styling with no utility classes added. Global
                    styles are the only things modifying the look and feel of this default card example.
                </div>
            </div>

            <!-- Basic Card Example -->
            <div class=""card shadow mb-4"">
                <d");
            WriteLiteral(@"iv class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Basic Card Example</h6>
                </div>
                <div class=""card-body"">
                    The styling for this basic card example is created by using default Bootstrap
                    utility classes. By using utility classes, the style of the card component can be
                    easily modified with no need for any custom CSS!
                </div>
            </div>

        </div>

        <div class=""col-lg-6"">

            <!-- Dropdown Card Example -->
            <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Dropdown Card Example</h6>
                    <div class=""dropdown no-arrow"">
                        <a class=""dropdown-toggle"" href=""#"" role=""button"" id=");
            WriteLiteral(@"""dropdownMenuLink""
                           data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in""
                             aria-labelledby=""dropdownMenuLink"">
                            <div class=""dropdown-header"">Dropdown Header:</div>
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </div>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                    Dropdown menus can be placed in the card header in order");
            WriteLiteral(@" to extend the functionality
                    of a basic card. In this dropdown card example, the Font Awesome vertical ellipsis
                    icon in the card header can be clicked on in order to toggle a dropdown menu.
                </div>
            </div>

            <!-- Collapsable Card Example -->
            <div class=""card shadow mb-4"">
                <!-- Card Header - Accordion -->
                <a href=""#collapseCardExample"" class=""d-block card-header py-3"" data-toggle=""collapse""
                   role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Collapsable Card Example</h6>
                </a>
                <!-- Card Content - Collapse -->
                <div class=""collapse show"" id=""collapseCardExample"">
                    <div class=""card-body"">
                        This is a collapsable card example using Bootstrap's built in collapse
                        func");
            WriteLiteral("tionality. <strong>Click on the card header</strong> to see the card body\r\n                        collapse and expand!\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
