#pragma checksum "C:\Users\User\source\repos\eShop\eShop\eShop\Views\Orders\OrderCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5be7711c0d433c4ca226770091f7974d013299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrderCompleted), @"mvc.1.0.view", @"/Views/Orders/OrderCompleted.cshtml")]
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
#line 1 "C:\Users\User\source\repos\eShop\eShop\eShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\eShop\eShop\eShop\Views\_ViewImports.cshtml"
using eShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\eShop\eShop\eShop\Views\_ViewImports.cshtml"
using eShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5be7711c0d433c4ca226770091f7974d013299", @"/Views/Orders/OrderCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f2452c3164306e8b6a089a6a22ed7b385093e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_OrderCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-6 offset-3 alert alert-success"" text-center>
        <h2>Заказ успешно выполнен</h2>
        <p>Вы можете проверить ваши заказы в разделе Заказы в своем профиле</p>
        <hr />
        <p>Спасибо!</p>
    </div>
</div>");
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
