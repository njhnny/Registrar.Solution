#pragma checksum "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b68f8eafa1bcb5196590699cc3450492a769fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3b68f8eafa1bcb5196590699cc3450492a769fc", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Course Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No students are currently enrolled in this course</p>\n");
#nullable restore
#line 14 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>The following students are enrolled in ");
#nullable restore
#line 17 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h4>\n  <ul>\n");
#nullable restore
#line 19 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
   Write(join.Student.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 24 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 26 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Back to courses", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 27 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 28 "/Users/nickhennessy/Downloads/c-sharp-to-do-list-dotnet5-week-4-6_m2m_delete/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591