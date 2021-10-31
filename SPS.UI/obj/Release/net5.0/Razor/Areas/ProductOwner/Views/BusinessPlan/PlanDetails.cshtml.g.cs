#pragma checksum "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductOwner\Views\BusinessPlan\PlanDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657bce1ce7df51c957a263f7c15779f6230b2e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProductOwner_Views_BusinessPlan_PlanDetails), @"mvc.1.0.view", @"/Areas/ProductOwner/Views/BusinessPlan/PlanDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657bce1ce7df51c957a263f7c15779f6230b2e94", @"/Areas/ProductOwner/Views/BusinessPlan/PlanDetails.cshtml")]
    public class Areas_ProductOwner_Views_BusinessPlan_PlanDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductOwner\Views\BusinessPlan\PlanDetails.cshtml"
  
    ViewData["Title"] = "PlanDetails";
    Layout = "~/Areas/ProductOwner/Views/Shared/_ProductOwner.cshtml";

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
                        <h3 class=""card-title"">Plan Details</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Plan Name : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtPlanName"" placeholder=""Plan Name"" msg-value=""plan name"" required>
                                    <span id=""errtxtPlanName"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
    ");
            WriteLiteral(@"                        <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Plan Cost : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtPlanCost"" placeholder=""Plan Cost"" msg-value=""plan cost"" required>
                                    <span id=""errtxtPlanCost"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Plan Validity : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtPlanValidity"" placeholder=""Plan Validity"" msg-value=""plan validity"" required>
                                    <span id=""errtxtPlanValidity"" class=""hidden-span text-danger""></span>
              ");
            WriteLiteral(@"                  </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Offer Cost : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtOfferCost"" placeholder=""Offer Cost"" msg-value=""offer cost"" required>
                                    <span id=""errtxtOfferCost"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Offer Period : <em class=""text-danger"">*</em> </label>
                                    <br />
                                    <label>Start Date:</label>
                              ");
            WriteLiteral("      <input type=\"date\" id=\"txtOfferPeriod\"");
            BeginWriteAttribute("name", " name=\"", 3237, "\"", 3244, 0);
            EndWriteAttribute();
            WriteLiteral("><br />\r\n                                    <label>End Date:</label>\r\n                                    <input type=\"date\" id=\"txtOfferPeriod\"");
            BeginWriteAttribute("name", " name=\"", 3390, "\"", 3397, 0);
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
                                    <label>Is Offer Live : <em class=""text-danger"">*</em> </label>
                                    <br />
       ");
            WriteLiteral("                             <input type=\"radio\" id=\"yes\"");
            BeginWriteAttribute("name", " name=\"", 4479, "\"", 4486, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4487, "\"", 4495, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label>Yes</label>\r\n                                    <input type=\"radio\" id=\"no\"");
            BeginWriteAttribute("name", " name=\"", 4618, "\"", 4625, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4626, "\"", 4634, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label>No</label>
                                    <span id=""errtxtIsOfferLive"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Module List :  <em class=""text-danger"">*</em></label>
                                    <br />
                                    <label>
                                        <input type=""checkbox"" name=""SMS"" value=""1"" />
                                        SMS
                                    </label>
                                    <br />
                                    <label>
                                        <input type=""checkbox"" name=""Add Blog"" value=""2"" />
                                        Add Blog
                                    </label>
                              ");
            WriteLiteral(@"      <br />
                                    <label>
                                        <input type=""checkbox"" name=""Add Photo"" value=""3"" />
                                        Add Photo
                                    </label>
                                    <span id=""errtxtModuleList"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Status :  <em class=""text-danger"">*</em> </label>
                                    <select id=""ddlStatus"" class=""form-control"" required>
                                        <option");
            BeginWriteAttribute("value", " value=\"", 6507, "\"", 6515, 0);
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
                  ");
            WriteLiteral("          <button type=\"button\" class=\"btn btn-secondary\" id=\"btnClear\">Clear</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
