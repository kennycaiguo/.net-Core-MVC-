#pragma checksum "D:\atomwork\C# MVC\DemoCoreStudy\DemoCoreStudy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34266b87bbdd4a5cb119fd7deb3c9884edc6011e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34266b87bbdd4a5cb119fd7deb3c9884edc6011e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44ae01019361e377f0244715cd5b6d7561d01a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoCoreStudy.Models.Cinema>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 450, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Location</th>
                    <th scope=""col"">Capacity</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                ");
            EndContext();
            BeginContext(500, 22, false);
#line 16 "D:\atomwork\C# MVC\DemoCoreStudy\DemoCoreStudy\Views\Home\Index.cshtml"
           Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(522, 60, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoCoreStudy.Models.Cinema>> Html { get; private set; }
    }
}
#pragma warning restore 1591
