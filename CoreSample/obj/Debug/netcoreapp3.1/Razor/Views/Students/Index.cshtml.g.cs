#pragma checksum "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742cfdd5591dd45692f23342dbf6cd984060e36e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\_ViewImports.cshtml"
using CoreSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\_ViewImports.cshtml"
using CoreSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742cfdd5591dd45692f23342dbf6cd984060e36e", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40df0a14584430d1678f827610e0c0d6b72d36f", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreSample.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\Students\Index.cshtml"
 foreach(Student student in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\Students\Index.cshtml"
Write(student.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\Students\Index.cshtml"
Write(student.Id);

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kalaiarasy\source\repos\CoreSample\CoreSample\Views\Students\Index.cshtml"
               
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreSample.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
