#pragma checksum "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductAdmin\Views\BusinessPlan\DomainDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da36ee572fcac56a8fa829afeb07b2d9e8f90d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProductAdmin_Views_BusinessPlan_DomainDetails), @"mvc.1.0.view", @"/Areas/ProductAdmin/Views/BusinessPlan/DomainDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da36ee572fcac56a8fa829afeb07b2d9e8f90d4b", @"/Areas/ProductAdmin/Views/BusinessPlan/DomainDetails.cshtml")]
    public class Areas_ProductAdmin_Views_BusinessPlan_DomainDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductAdmin\Views\BusinessPlan\DomainDetails.cshtml"
  
    ViewData["Title"] = "DomainDetails";
    Layout = "~/Areas/ProductAdmin/Views/Shared/_ProductOwner.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <!-- left column -->
            <div class=""col-md-12"">
                <!-- general form elements -->
                <div class=""card card-info"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Domain Plan Details</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Domain Name : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtDomainName"" placeholder=""Domain Name"" msg-value=""domain name"" required>
                                    <span id=""errtxtDomainName"" class=""hidden-span text-danger""></span>
                                </div>
                       ");
            WriteLiteral(@"     </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Domain Validity : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtDomainValidity"" placeholder=""Domain Validity"" msg-value=""domain validity"" required>
                                    <span id=""errtxtDomainValidity"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Domain Cost : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtDomainCost"" placeholder=""Domain Cost"" msg-value=""domain cost"" required>
                                    <span id=""errtxtDomainCost"" class=""hidden-span");
            WriteLiteral(@" text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Offer Cost : </label>
                                    <input type=""text"" class=""form-control"" id=""txtOfferCost"" placeholder=""Offer Cost"" msg-value=""offer cost"" required>
                                    <span id=""errtxtOfferCost"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Offer Period :  </label>
                                    <br />
                                    <label>Start Date:</label>
                                    <input type=""date""");
            WriteLiteral(" id=\"txtOfferPeriod\"");
            BeginWriteAttribute("name", " name=\"", 3215, "\"", 3222, 0);
            EndWriteAttribute();
            WriteLiteral("><br />\r\n                                    <label>End Date:</label>\r\n                                    <input type=\"date\" id=\"txtOfferPeriod\"");
            BeginWriteAttribute("name", " name=\"", 3368, "\"", 3375, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span id=""errtxtOfferPeriod"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Without Offer Cost : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtWithoutOfferCost"" placeholder=""Without Offer Cost"" msg-value=""without offer cost"" required>
                                    <span id=""errtxtWithoutOfferCost"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Is Offer Live : </label>
                                    <br />
                                    <i");
            WriteLiteral("nput type=\"radio\" id=\"yes\"");
            BeginWriteAttribute("name", " name=\"", 4426, "\"", 4433, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4434, "\"", 4442, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label>Yes</label>\r\n                                    <input type=\"radio\" id=\"no\"");
            BeginWriteAttribute("name", " name=\"", 4565, "\"", 4572, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4573, "\"", 4581, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label>No</label>
                                    <span id=""errtxtIsOfferLive"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Feature List :  <em class=""text-danger"">*</em></label>
                                    <br />
                                    <label>
                                        <input type=""checkbox"" name=""5 Email"" value=""1"" />
                                        5 Email
                                    </label>
                                    <br />
                                    <label>
                                        <input type=""checkbox"" name=""10 Email"" value=""2"" />
                                        10 Email
                                    </label>
                     ");
            WriteLiteral(@"               <span id=""errtxtFeatureList"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Status :  <em class=""text-danger"">*</em> </label>
                                    <select id=""ddlStatus"" class=""form-control"" required>
                                        <option");
            BeginWriteAttribute("value", " value=\"", 6184, "\"", 6192, 0);
            EndWriteAttribute();
            WriteLiteral(@">Select</option>
                                        <option value=""active"">Active</option>
                                        <option value=""inactive"">Inactive</option>
                                    </select>
                                    <span id=""errddlStatus"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Description :  </label>
                                    <textarea placeholder=""Description"" class=""form-control"" id=""txtDescription"" rows=""3""></textarea>
                                </div>
                            </div>
                        </div>
                        <div class=""card-footer"">
                            <button type=""button"" class=""btn btn-info"" id=""btnSubmit"">Submit</button>
                            <button type=""b");
            WriteLiteral("utton\" class=\"btn btn-secondary\" id=\"btnClear\">Clear</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
