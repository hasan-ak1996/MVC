#pragma checksum "C:\Users\LENOVO\source\repos\UploadImage\UploadImage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1e19c4e60fcd3f0a5896d9203c3eb29bc5426d2"
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
#line 1 "C:\Users\LENOVO\source\repos\UploadImage\UploadImage\Views\_ViewImports.cshtml"
using UploadImage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\UploadImage\UploadImage\Views\_ViewImports.cshtml"
using UploadImage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1e19c4e60fcd3f0a5896d9203c3eb29bc5426d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240b91c2367e793d02d100811efeb8df23513147", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\LENOVO\source\repos\UploadImage\UploadImage\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1e19c4e60fcd3f0a5896d9203c3eb29bc5426d24008", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""col-md-12"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-2"">
                    <label>Name:</label>

                </div>
                <div class=""col-md-10"">
                    <input id=""txtname"" type=""text"" placeholder=""Order Name"" style=""width:100%;"" />
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-2"">
                    <label>Photo:</label>

                </div>
                <div class=""col-md-10"">
                    <input id=""txtFile"" type=""file"" value=""Upload File"" style=""width:100%;"" />
                </div>
            </div>

        </div>
        <div class=""col-md-6"">
            <img id=""img"" width=""200"" height=""200"" style=""border:1px solid #000;"" />
        </div>

    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <button id=""btnSave"" class=""btn btn-primary"" style=""width:10");
            WriteLiteral(@"0%;margin-top:10px;"">Save</button>
            <button id=""btnRead"" class=""btn btn-danger"" style=""width:100%;margin-top:10px;"">Get</button>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {

    });
    $(""#txtFile"").change(function (event) {
        var files = event.target.files;

        $(""#img"").attr('src', window.URL.createObjectURL(files[0]));

    });
    $(""#btnSave"").click(function () {
        var files = $(""#txtFile"").prop(""files"");
        var formData = new FormData();
        for (var i = 0; i < files.length; i++) {
            formData.append(""file"", files[i]);
        }
        var order = {
            Name: $(""#txtname"").val()
        };
        formData.append(""Order"", JSON.stringify(order));
        $.ajax({
            type: ""POST"",
            url: ""/Home/SaveFile"",
            data: formData,
            processData: false,
            contentType: false,
            success: function (data) {
          ");
            WriteLiteral(@"      ResetFields();
                alert(data);

            },
            error: function (data) {
                console.log(""Error"", data);
            }
        });
    });
    $(""#btnRead"").click(function () {
        $.ajax({
            type: ""GET"",
            url: ""/Home/GetSavedOrder"",
            success: function (data) {
                $(""#txtname"").val(data.Name);
                $(""#img"").attr('src', ""data:image/jpg;base64,"" + data.Photo + """");
                console.log(""data:image/jpg;base64,"" + data.Photo + """")

            },
            error: function (data) {
                console.log(""Error"", data);
            }
        });
    });
    function ResetFields() {
        $(""#txtname"").val("""");
        $(""#img"").attr('src', """");
    }

</script>
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
