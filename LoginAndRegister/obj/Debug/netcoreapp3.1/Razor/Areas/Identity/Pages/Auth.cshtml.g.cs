#pragma checksum "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\Auth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80e73a9e9963cf3935720afb9b703b208f423aa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Auth), @"mvc.1.0.view", @"/Areas/Identity/Pages/Auth.cshtml")]
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
#line 1 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\_ViewImports.cshtml"
using LoginAndRegister.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\_ViewImports.cshtml"
using LoginAndRegister.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\_ViewImports.cshtml"
using LoginAndRegister.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e73a9e9963cf3935720afb9b703b208f423aa7", @"/Areas/Identity/Pages/Auth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8bc30b361bdb0e50b1567b15cb20e15f093faeb", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Auth : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\Auth.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <ul class=""nav navbar-light bg-light"">
            <li class=""nav-item col-md-6 text-center""><a class="" nav-link""href=""/Identity/Account/Login"">Login</a></li>
            <li class=""nav-item col-md-6 text-center""><a class="" nav-link""href=""/Identity/Account/Register"">Register</a></li>
        </ul>
        ");
#nullable restore
#line 9 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\Auth.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Users\windows\Desktop\LoginAndRegister\LoginAndRegister\Areas\Identity\Pages\Auth.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
