#pragma checksum "C:\Users\Aydar\Documents\Обучение\ИТМО\02_Инженер-программист\08 ASP.NET\Lab_ASP\ITMO.ASP.NET\ITMO.ASP.NET-MVC-L01Ex01-WebMVCR1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd0fdcd998006b0763341b9a308b7f7fef2c3d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0fdcd998006b0763341b9a308b7f7fef2c3d49", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div> ");
#nullable restore
#line 5 "C:\Users\Aydar\Documents\Обучение\ИТМО\02_Инженер-программист\08 ASP.NET\Lab_ASP\ITMO.ASP.NET\ITMO.ASP.NET-MVC-L01Ex01-WebMVCR1\Views\Home\Index.cshtml"
     Write(ViewBag.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral(", спасибо, что зашли и ");
#nullable restore
#line 5 "C:\Users\Aydar\Documents\Обучение\ИТМО\02_Инженер-программист\08 ASP.NET\Lab_ASP\ITMO.ASP.NET\ITMO.ASP.NET-MVC-L01Ex01-WebMVCR1\Views\Home\Index.cshtml"
                                             Write(ViewData["Mes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>");
#nullable restore
#line 6 "C:\Users\Aydar\Documents\Обучение\ИТМО\02_Инженер-программист\08 ASP.NET\Lab_ASP\ITMO.ASP.NET\ITMO.ASP.NET-MVC-L01Ex01-WebMVCR1\Views\Home\Index.cshtml"
  Write(Html.ActionLink("Введите свои данные", "InputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n    <p> ");
#nullable restore
#line 7 "C:\Users\Aydar\Documents\Обучение\ИТМО\02_Инженер-программист\08 ASP.NET\Lab_ASP\ITMO.ASP.NET\ITMO.ASP.NET-MVC-L01Ex01-WebMVCR1\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Посмотрите, кто уже здесь", "OutputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
