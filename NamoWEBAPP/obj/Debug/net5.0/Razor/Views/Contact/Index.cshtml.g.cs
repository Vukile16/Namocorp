#pragma checksum "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3224c1b96f95cb532b9e8c210f28b4503b1432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\_ViewImports.cshtml"
using NamoWEBAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\_ViewImports.cshtml"
using NamoWEBAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3224c1b96f95cb532b9e8c210f28b4503b1432", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"435ddf8d30d222f179f4c961fbd2583a4d558e9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NamoWEBAPP.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetContactsOver35", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""margin-top:120px;"">
    <h1 class=""text-center"">Contact List</h1>

    <div class=""container"">
        <div class=""form-group"">
            <div class=""input-group"">
                <span class=""input-group-addon""><i class=""glyphicon glyphicon-search""></i></span>
                <input type=""text"" id=""Search"" placeholder=""Search by first name, surname or cell number to locate a record"" class=""form-control"" />
            </div>
        </div>
    </div>


    <p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd3224c1b96f95cb532b9e8c210f28b4503b14325243", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd3224c1b96f95cb532b9e8c210f28b4503b14326410", async() => {
                WriteLiteral("Show Contacts Over Age 35");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ContactingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 48 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"Search\">\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ContactingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.ContactId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 66 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.ContactId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 67 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.ContactId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "C:\ACER 1 TB\Vukile's stuff\Assesment\Namocorp\NamoWEBAPP\NamoWEBAPP\Views\Contact\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
        $(document).ready(function () {
            function Contains(text_one, text_two) {
                if (text_one.indexOf(text_two) != -1)
                    return true;
            }
            //the .Search is a class the forearch <tr>
            $(""#Search"").keyup(function () {
                var searchText = $(""#Search"").val().toLowerCase();
                $("".Search"").each(function () {
                    if (!Contains($(this).text().toLowerCase(), searchText)) {
                        $(this).hide();
                    }
                    else {
                        $(this).show();
                    }
                });
            });

        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NamoWEBAPP.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
