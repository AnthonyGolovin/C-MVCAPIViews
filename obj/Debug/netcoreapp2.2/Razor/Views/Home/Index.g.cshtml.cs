#pragma checksum "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea69eef38f203d0bb8a12fd07cacf9ece7fdd681"
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
#line 1 "/Users/Guest/Desktop/MVC/Views/_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/MVC/Views/_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea69eef38f203d0bb8a12fd07cacf9ece7fdd681", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h1>All Animals:</h1>\r\n\r\n<ol>\r\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
 foreach (Animal animal in Model)
{

#line default
#line hidden
            BeginContext(69, 28, true);
            WriteLiteral("    <ul>\r\n        <li>Name: ");
            EndContext();
            BeginContext(98, 11, false);
#line 7 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
             Write(animal.Name);

#line default
#line hidden
            EndContext();
            BeginContext(109, 24, true);
            WriteLiteral("</li>\r\n        <li>Age: ");
            EndContext();
            BeginContext(134, 10, false);
#line 8 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
            Write(animal.Age);

#line default
#line hidden
            EndContext();
            BeginContext(144, 27, true);
            WriteLiteral("</li>\r\n        <li>Gender: ");
            EndContext();
            BeginContext(172, 13, false);
#line 9 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
               Write(animal.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(185, 29, true);
            WriteLiteral(")</li>\r\n        <li>Species: ");
            EndContext();
            BeginContext(215, 14, false);
#line 10 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
                Write(animal.Species);

#line default
#line hidden
            EndContext();
            BeginContext(229, 29, true);
            WriteLiteral(")</li>\r\n    </ul>\r\n    <br>\r\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/MVC/Views/Home/Index.cshtml"
}

#line default
#line hidden
            BeginContext(261, 7, true);
            WriteLiteral("</ol>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
