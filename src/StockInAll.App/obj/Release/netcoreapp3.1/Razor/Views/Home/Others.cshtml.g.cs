#pragma checksum "C:\Projetos\Happen\SistemaHappen2.0\src\Happen.App\Views\Home\Others.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910be0631f0badbd7e3628111ed3d4bc85fca216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Others), @"mvc.1.0.view", @"/Views/Home/Others.cshtml")]
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
#line 11 "C:\Projetos\Happen\SistemaHappen2.0\src\Happen.App\Views\_ViewImports.cshtml"
using Happen.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projetos\Happen\SistemaHappen2.0\src\Happen.App\Views\_ViewImports.cshtml"
using Happen.App.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"910be0631f0badbd7e3628111ed3d4bc85fca216", @"/Views/Home/Others.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1033300263d6792bb64a4a9a926a43b596197bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Others : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projetos\Happen\SistemaHappen2.0\src\Happen.App\Views\Home\Others.cshtml"
  
    ViewData["Title"] = "Cards";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-1 text-gray-800"">Other Utilities</h1>
    <p class=""mb-4"">
        Bootstrap's default utility classes can be found on the official <a href=""https://getbootstrap.com/docs"">Bootstrap Documentation</a> page. The custom utilities
        below were created to extend this theme past the default utility classes built into Bootstrap's
        framework.
    </p>

    <!-- Content Row -->
    <div class=""row"">

        <div class=""col-lg-6"">

            <!-- Overflow Hidden -->
            <div class=""card mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Overflow Hidden Utilty</h6>
                </div>
                <div class=""card-body"">
                    Use <code>.o-hidden</code> to set the overflow property of any element to hidden.
                </div>
            </div>

            <!-- Progress Small -->
            <div cla");
            WriteLiteral(@"ss=""card mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Progress Small Utility</h6>
                </div>
                <div class=""card-body"">
                    <div class=""mb-1 small"">Normal Progress Bar</div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 75%""
                             aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""mb-1 small"">Small Progress Bar</div>
                    <div class=""progress progress-sm mb-2"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 75%""
                             aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    Use the <code>.progress-sm</code> class along with <code>.progress</code>
                </div>
       ");
            WriteLiteral(@"     </div>

            <!-- Dropdown No Arrow -->
            <div class=""card mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Dropdown - No Arrow</h6>
                </div>
                <div class=""card-body"">
                    <div class=""dropdown no-arrow mb-4"">
                        <button class=""btn btn-secondary dropdown-toggle"" type=""button""
                                id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true""
                                aria-expanded=""false"">
                            Dropdown (no arrow)
                        </button>
                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
      ");
            WriteLiteral(@"                  </div>
                    </div>
                    Add the <code>.no-arrow</code> class alongside the <code>.dropdown</code>
                </div>
            </div>

        </div>

        <div class=""col-lg-6"">

            <!-- Roitation Utilities -->
            <div class=""card"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Rotation Utilities</h6>
                </div>
                <div class=""card-body text-center"">
                    <div class=""bg-primary text-white p-3 rotate-15 d-inline-block my-4"">
                        .rotate-15
                    </div>
                    <hr>
                    <div class=""bg-primary text-white p-3 rotate-n-15 d-inline-block my-4"">
                        .rotate-n-15
                    </div>
                </div>
            </div>

        </div>

    </div>

</div>
<!-- /.container-fluid -->
");
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
