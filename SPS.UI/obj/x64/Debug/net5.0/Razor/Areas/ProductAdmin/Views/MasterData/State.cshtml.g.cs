#pragma checksum "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductAdmin\Views\MasterData\State.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "428f81834f1b016a868d08ffa33d919935833b08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProductAdmin_Views_MasterData_State), @"mvc.1.0.view", @"/Areas/ProductAdmin/Views/MasterData/State.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"428f81834f1b016a868d08ffa33d919935833b08", @"/Areas/ProductAdmin/Views/MasterData/State.cshtml")]
    public class Areas_ProductAdmin_Views_MasterData_State : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ProductOwner/State.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\SAAS\Smart Preschool\Code\smartpreschools\SPS.UI\Areas\ProductAdmin\Views\MasterData\State.cshtml"
  
    ViewData["Title"] = "State";
    Layout = "~/Areas/ProductAdmin/Views/Shared/_ProductOwner.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <!-- left column -->
            <div class=""col-md-6"">
                <!-- general form elements -->
                <div class=""card card-info"">
                    <div class=""card-header"">
                        <h3 class=""card-title""> Add State</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""form-group"">
                            <label>Select Country <em class=""text-danger"">*</em></label>
                            <select class=""form-control"" id=""ddlCountry"" msg-value=""country"" required>
                            </select>
                            <span id=""errddlCountry"" class=""hidden-span text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">State Name :  <em class=""text-danger"">*</em>  </label>
    ");
            WriteLiteral(@"                        <input type=""text"" class=""form-control"" id=""txtStateName"" placeholder=""State Name"" msg-value=""state name"" required>
                            <span id=""errtxtStateName"" class=""hidden-span text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Description : </label>
                            <textarea class=""form-control"" rows=""3"" placeholder=""Enter ..."" maxlength=""250"" id=""txtStateDesc""></textarea>
                        </div>
                        <div>
                            <label>Status</label>
                            <select class=""form-control"" id=""ddlStateStatus"">
                                <option value=""true"">Active</option>
                                <option value=""false"">InActive</option>
                            </select>
                        </div>
                    </div>

                    <div class=""card-foote");
            WriteLiteral(@"r"">
                        <input type=""hidden"" id=""hdnStateID"">
                        <button type=""button"" class=""btn btn-info"" id=""btnSubmit"">Submit</button>
                        <button type=""button"" class=""btn btn-secondary"" id=""btnClear"">Clear</button>
                    </div>
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""card card-info"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">State List</h3>
                    </div>
                    <div class=""card-body"">
                        <table id=""statelist"" class=""table table-bordered"" style=""width:100%;"">
                            <thead>
                                <tr>
                                    <th>Country</th>
                                    <th>State Name</th>
                                    <th>State Description</th>
                                    <th>Status</th>
               ");
            WriteLiteral(@"                     <th>Action</th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "428f81834f1b016a868d08ffa33d919935833b086954", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
