#pragma checksum "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b63ad9de354a8e655cf1461640c694c1de32347"
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
#nullable restore
#line 1 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/_ViewImports.cshtml"
using AJWTEST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/_ViewImports.cshtml"
using AJWTEST.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
using AJW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b63ad9de354a8e655cf1461640c694c1de32347", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd676b36e8ccb6684e67e5e497733adb2896648", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<AJW.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1>AJW Test Application</h1>\r\n    <p class=\"lead\">Use the form below to search for a specific Sales Order or Part Number.</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b63ad9de354a8e655cf1461640c694c1de323474315", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
                    <input class=""form-control mr-sm-2"" type=""search"" name=""query"" placeholder=""Search"" aria-label=""Search"">&nbsp;
                </div>
        
        <div class=""form-group"">
            <button type=""submit"" class=""btn btn-default"">Submit</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    
</div>

<div class=""row"">
    
    <div class=""panel panel-default"">
      <!-- Default panel contents -->
      <div class=""panel-heading"">Click on any of the records below for more detail</div>
    
      <!-- Table -->
      <table class=""table table-hover"">
          <tr>
              <th>Sales Order</th>
              <th>Date</th>
              <th>Po Ref</th>
              <th>Line Item</th>
              <th>Ship To</th>
              <th>Customer</th>
              <th>Part Number</th>
          </tr>
");
#nullable restore
#line 41 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
           if (Model != null)
          {
               foreach (Order o in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr data-toggle=\"collapse\" data-target=\"#accordion_");
#nullable restore
#line 45 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                          Write(o.SoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"clickable\">\r\n                                <td>");
#nullable restore
#line 46 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.SoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 47 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 48 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.CompanyRefNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 49 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.ItemNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 50 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.ShipAddress1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 51 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 52 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                               Write(o.PnUpper);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n");
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"7\">\r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 1999, "\"", 2025, 2);
            WriteAttributeValue("", 2004, "accordion_", 2004, 10, true);
#nullable restore
#line 57 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
WriteAttributeValue("", 2014, o.SoNumber, 2014, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\">\r\n                                        \r\n                                        <ul class=\"list-group\">\r\n                                            <li class=\"list-group-item\">Sale Order Detail AutoKey : ");
#nullable restore
#line 60 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                               Write(o.SaleOrderDetailAutoKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Company AutoKey : ");
#nullable restore
#line 61 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                     Write(o.CompanyAutoKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Po Ref : ");
#nullable restore
#line 62 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                            Write(o.CompanyRefNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Sales Order : ");
#nullable restore
#line 63 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                 Write(o.SoNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Date : ");
#nullable restore
#line 64 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                          Write(o.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Ship Address 1 : ");
#nullable restore
#line 65 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                    Write(o.ShipAddress1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Ship Address 2 : ");
#nullable restore
#line 66 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                    Write(o.ShipAddress2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Attention : ");
#nullable restore
#line 67 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                               Write(o.Attention);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Open : ");
#nullable restore
#line 68 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                          Write(o.OpenFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Number Of Items : ");
#nullable restore
#line 69 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                     Write(o.NumberOfItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Item Number : ");
#nullable restore
#line 70 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                 Write(o.ItemNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Route Code : ");
#nullable restore
#line 71 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                Write(o.RouteCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Part Number : ");
#nullable restore
#line 72 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                 Write(o.PnUpper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Quantity Ordered : ");
#nullable restore
#line 73 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                      Write(o.QtyOrdered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Quantity Reserved : ");
#nullable restore
#line 74 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                       Write(o.QtyReserved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Quantity Pending Invoice : ");
#nullable restore
#line 75 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                              Write(o.QtyPendingInvoice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Quantity Invoiced : ");
#nullable restore
#line 76 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                       Write(o.QtyInvoiced);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Description : ");
#nullable restore
#line 77 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                 Write(o.DescriptionUpper);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Price : ");
#nullable restore
#line 78 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                           Write(o.CustomerPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Currency : ");
#nullable restore
#line 79 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                              Write(o.CurrencyCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Shimpment Date : ");
#nullable restore
#line 80 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                    Write(o.NextShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Parts Master AutoKey : ");
#nullable restore
#line 81 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                          Write(o.PartsMasterAutoKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li class=\"list-group-item\">Company Name : ");
#nullable restore
#line 82 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                                                                                  Write(o.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                        \r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 88 "/home/chris/RiderProjects/AJWTEST/AJWTEST/Views/Home/Index.cshtml"
                        }
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n       \r\n      </table>\r\n    </div>\r\n    \r\n    \r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<AJW.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
