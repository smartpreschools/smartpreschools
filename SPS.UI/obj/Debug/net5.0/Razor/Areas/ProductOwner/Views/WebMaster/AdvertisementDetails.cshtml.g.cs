#pragma checksum "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductOwner\Views\WebMaster\AdvertisementDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05920f703d1423a82b91372926ce64304b6d3c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProductOwner_Views_WebMaster_AdvertisementDetails), @"mvc.1.0.view", @"/Areas/ProductOwner/Views/WebMaster/AdvertisementDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05920f703d1423a82b91372926ce64304b6d3c01", @"/Areas/ProductOwner/Views/WebMaster/AdvertisementDetails.cshtml")]
    public class Areas_ProductOwner_Views_WebMaster_AdvertisementDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductOwner\Views\WebMaster\AdvertisementDetails.cshtml"
  
    ViewData["Title"] = "AdvertisementDetails";
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
                        <h3 class=""card-title"">Advertisement Plan Details</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""form-group"">
                                    <label>Advertisement Type Name : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtAdvertisementTypeName"" placeholder=""Advertisement Type Name"" msg-value=""advertisement type name"" required>
                                    <span id=""errtxtAdvertisementTypeName"" class=""hidden-span text-danger""></span>");
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""form-group"">
                                    <label>Cost : <em class=""text-danger"">*</em> </label>
                                    <input type=""text"" class=""form-control"" id=""txtCost"" placeholder=""Cost"" msg-value=""cost"" required>
                                    <span id=""errtxtCost"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-1"">
                                <div class=""form-group"">
                                    <label>Type : <em class=""text-danger"">*</em> </label>
                                    <br />
                                    <input type=""radio""");
            BeginWriteAttribute("id", " id=\"", 2044, "\"", 2049, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2050, "\"", 2057, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2058, "\"", 2066, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label>5 Days</label><br />\r\n                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 2190, "\"", 2195, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2196, "\"", 2203, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2204, "\"", 2212, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label>10 Days</label><br />\r\n                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 2337, "\"", 2342, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2343, "\"", 2350, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2351, "\"", 2359, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <label>20 Days</label><br />\r\n                                    <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 2484, "\"", 2489, 0);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2490, "\"", 2497, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2498, "\"", 2506, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label>30 Days</label>
                                    <span id=""errtxtType"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""form-group"">
                                    <label>Status :  <em class=""text-danger"">*</em> </label>
                                    <select id=""ddlStatus"" class=""form-control"" required>
                                        <option");
            BeginWriteAttribute("value", " value=\"", 3087, "\"", 3095, 0);
            EndWriteAttribute();
            WriteLiteral(@">Select</option>
                                        <option value=""active"">Active</option>
                                        <option value=""inactive"">Inactive</option>
                                    </select>
                                    <span id=""errddlStatus"" class=""hidden-span text-danger""></span>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""form-group"">
                                    <label>Description :  </label>
                                    <textarea placeholder=""Description"" class=""form-control"" id=""txtDescription"" rows=""3""></textarea>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">                                                 
                            
                        </div>
                            <div class=""car");
            WriteLiteral(@"d-footer"">
                                <button type=""button"" class=""btn btn-info"" id=""btnSubmit"">Submit</button>
                                <button type=""button"" class=""btn btn-secondary"" id=""btnClear"">Clear</button>
                            </div>
                        </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
