#pragma checksum "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cdb76811e1f49533d7a3c86e5fe0d5a4cf93ce7"
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
#line 5 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
using Registrar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cdb76811e1f49533d7a3c86e5fe0d5a4cf93ce7", @"/Views/Students/Index.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Registrar.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Registered Students:</h1>\n\n");
#nullable restore
#line 10 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No students have registered yet!</h3>\n");
#nullable restore
#line 13 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 foreach (Student student in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 17 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 Write(Html.ActionLink($"{student.Description}", "Details", new { id = student.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 20 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
Write(Html.ActionLink("Register new student", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 21 "/Users/nickhennessy/Downloads/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
Write(Html.ActionLink("Return home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Registrar.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
