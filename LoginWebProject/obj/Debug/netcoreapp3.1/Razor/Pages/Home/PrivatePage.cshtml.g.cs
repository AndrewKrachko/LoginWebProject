#pragma checksum "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f5e843250b93997980369fc02a7882a6a237560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LoginWebProject.Pages.Home.Pages_Home_PrivatePage), @"mvc.1.0.razor-page", @"/Pages/Home/PrivatePage.cshtml")]
namespace LoginWebProject.Pages.Home
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
#line 1 "D:\AK\LoginWebProject\LoginWebProject\Pages\_ViewImports.cshtml"
using LoginWebProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f5e843250b93997980369fc02a7882a6a237560", @"/Pages/Home/PrivatePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ec00d0ee046f3e77a0c2190672e25e47dbff2a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_PrivatePage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Hello, boy!</h1>\r\n<div>\r\n");
#nullable restore
#line 7 "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml"
      
        var array = string.Empty;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml"
         foreach (var value in Model.Array)
        {
            array += $"{value} ";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Числа ");
#nullable restore
#line 14 "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml"
        Write(array);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    <p>Наименьшее ");
#nullable restore
#line 18 "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml"
             Write(Model.MinInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    <p>Наибольшее ");
#nullable restore
#line 22 "D:\AK\LoginWebProject\LoginWebProject\Pages\Home\PrivatePage.cshtml"
             Write(Model.MaxInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginWebProject.Pages.PrivatePageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginWebProject.Pages.PrivatePageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginWebProject.Pages.PrivatePageModel>)PageContext?.ViewData;
        public LoginWebProject.Pages.PrivatePageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591