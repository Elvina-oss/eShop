#pragma checksum "C:\Users\User\source\repos\ehoptryafterfail\eShop\eShop\Views\Orders\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6df8fc678ba0561249b9b00e22402bda493c5d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Payment), @"mvc.1.0.view", @"/Views/Orders/Payment.cshtml")]
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
#line 1 "C:\Users\User\source\repos\ehoptryafterfail\eShop\eShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\ehoptryafterfail\eShop\eShop\Views\_ViewImports.cshtml"
using eShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\ehoptryafterfail\eShop\eShop\Views\_ViewImports.cshtml"
using eShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df8fc678ba0561249b9b00e22402bda493c5d75", @"/Views/Orders/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f2452c3164306e8b6a089a6a22ed7b385093e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\ehoptryafterfail\eShop\eShop\Views\Orders\Payment.cshtml"
   
    ViewData["Title"] = "Оплата заказа";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .credit-card-div span {
        padding-top: 10px;
    }

    .credit-card-div img {
        padding-top: 30px;
    }

    .credit-card-div .small-font {
        font-size: 9px;
    }

    .credit-card-div .pad-adjust {
        padding-top: 10px;
    }
</style>

<div class=""container"">
    <div class=""row "">
        <div class=""col-md-4 col-offset-4"">

            <div class=""credit-card-div"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">

                        <div class=""row "">
                            <div class=""col-md-12"">
                                <input type=""text"" class=""form-control"" placeholder=""Номер карты"" />
                            </div>
                        </div>

                        <div class=""row "">
                            <div class=""col-md-3 col-sm-3 col-xs-3"">
                                <span class=""help-block text-muted small-font""> Expiry Month</span>
      ");
            WriteLiteral(@"                          <input type=""text"" class=""form-control"" placeholder=""MM"" />
                            </div>
                            <div class=""col-md-3 col-sm-3 col-xs-3"">
                                <span class=""help-block text-muted small-font""> Expiry Year</span>
                                <input type=""text"" class=""form-control"" placeholder=""YY"" />
                            </div>
                            <div class=""col-md-3 col-sm-3 col-xs-3"">
                                <span class=""help-block text-muted small-font""> CCV</span>
                                <input type=""text"" class=""form-control"" placeholder=""CCV"" />
                            </div>
                            <div class=""col-md-3 col-sm-3 col-xs-3"">
                                <img src=""https://bootstraptema.ru/snippets/form/2016/form-card/card.png"" class=""img-rounded"" />
                            </div>
                        </div>

                        <div class=""row ");
            WriteLiteral(@""">
                            <div class=""col-md-12 pad-adjust"">

                                <input type=""text"" class=""form-control"" placeholder=""Имя на карте"" />
                            </div>
                        </div>

                        

                        <div class=""row "">
                            <div class=""col-md-6 col-sm-6 col-xs-6 pad-adjust"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6df8fc678ba0561249b9b00e22402bda493c5d757012", async() => {
                WriteLiteral("<input type=\"submit\" class=\"btn btn-outline-danger\" value=\"Отмена\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-6 pad-adjust\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6df8fc678ba0561249b9b00e22402bda493c5d758597", async() => {
                WriteLiteral("<input type=\"submit\" class=\"btn btn-outline-success btn-block\" value=\"Оплатить\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div><!-- ./credit-card-div -->\r\n\r\n        </div>\r\n    </div>\r\n</div><!-- /.container -->");
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
