#pragma checksum "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751c7c10e263e971ce1edd000ee54a588c3ecd38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RenderData_ViewBagDemo), @"mvc.1.0.view", @"/Views/RenderData/ViewBagDemo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751c7c10e263e971ce1edd000ee54a588c3ecd38", @"/Views/RenderData/ViewBagDemo.cshtml")]
    public class Views_RenderData_ViewBagDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
  
    var hobby=ViewBag.Hobby as string[];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 5 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<ul>\r\n    <li>姓名：");
#nullable restore
#line 7 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
      Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>生日：");
#nullable restore
#line 8 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
      Write(ViewBag.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>爱好：");
#nullable restore
#line 9 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
      Write(hobby[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 9 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\RenderData\ViewBagDemo.cshtml"
                Write(hobby[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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