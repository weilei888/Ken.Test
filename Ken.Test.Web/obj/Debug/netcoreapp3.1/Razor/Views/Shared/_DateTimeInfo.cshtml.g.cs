#pragma checksum "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\Shared\_DateTimeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a9a1b35372899bbc59c6f0057294497de5d6b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DateTimeInfo), @"mvc.1.0.view", @"/Views/Shared/_DateTimeInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9a1b35372899bbc59c6f0057294497de5d6b3c", @"/Views/Shared/_DateTimeInfo.cshtml")]
    public class Views_Shared__DateTimeInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("当前时间：");
#nullable restore
#line 1 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\Shared\_DateTimeInfo.cshtml"
Write(DateTime.Now.ToString("yyy-MM-dd HH:mm:ss:fff"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n当前星期：");
#nullable restore
#line 2 "C:\Users\夏天的风\Ken.Test\Ken.Test.Web\Views\Shared\_DateTimeInfo.cshtml"
Write(DateTime.Now.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
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