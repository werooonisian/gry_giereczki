#pragma checksum "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c6997b218f7832c81d064b20e0399528167702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\_ViewImports.cshtml"
using GryGiereczki.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\_ViewImports.cshtml"
using GryGiereczki.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using GryGiereczki.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c6997b218f7832c81d064b20e0399528167702", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c5da4abf68b6ca8f7e3e76768154df4fe435c1e", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5561a2e21c8d464a046cf3b0fd328bcaf05440d8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Potwierdzenie rejestracji";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 407, "\"", 441, 1);
#nullable restore
#line 13 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 414, Model.EmailConfirmationUrl, 414, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\n</p>\n");
#nullable restore
#line 15 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\n        Na Twojego email\'a została wysłana wiadomość z potwierdzeniem konta.\n</p>\n");
#nullable restore
#line 21 "C:\Users\shogi\OneDrive\Pulpit\llaczenie js test\Gry-Giereczki-Schematy-martaa\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
