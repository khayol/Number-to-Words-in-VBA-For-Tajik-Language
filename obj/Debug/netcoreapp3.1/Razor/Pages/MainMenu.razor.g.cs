#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\MainMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ff560a7da4a6bbc3c4629cf76dc4cdf2c8b845"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MainMenu")]
    public partial class MainMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrQuestOrMsg>(0);
            __builder.AddAttribute(1, "TxtSize", "h2");
            __builder.AddAttribute(2, "Txt", "MainMenu");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "nav flex-column");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(7);
            __builder.AddAttribute(8, "PageName", "Index");
            __builder.AddAttribute(9, "Link", "");
            __builder.AddAttribute(10, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\MainMenu.razor"
                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "FieldCaption", "Home");
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n         ");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(13);
            __builder.AddAttribute(14, "PageName", "ApplicationRoleViewStd");
            __builder.AddAttribute(15, "Link", "Adm/ApplicationRole/ViewStd/0");
            __builder.AddAttribute(16, "TransEntity", "Adm");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n         ");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(18);
            __builder.AddAttribute(19, "PageName", "ApplicationUserViewStd");
            __builder.AddAttribute(20, "Link", "Adm/ApplicationUser/ViewStd/0");
            __builder.AddAttribute(21, "TransEntity", "Adm");
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n         ");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(23);
            __builder.AddAttribute(24, "PageName", "GenderViewStd");
            __builder.AddAttribute(25, "Link", "Dir/Gender/ViewStd/0");
            __builder.AddAttribute(26, "TransEntity", "Dir");
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n         ");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(28);
            __builder.AddAttribute(29, "PageName", "CountryViewStd");
            __builder.AddAttribute(30, "Link", "Dir/Country/ViewStd/0");
            __builder.AddAttribute(31, "TransEntity", "Dir");
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n         ");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrLi>(33);
            __builder.AddAttribute(34, "PageName", "IndividualViewStd");
            __builder.AddAttribute(35, "Link", "IndOrg/Individual/ViewStd/0");
            __builder.AddAttribute(36, "TransEntity", "Individual");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\MainMenu.razor"
        
protected override void OnInitialized()
{
    AppData.BaseUrlUri=NavManager.Uri.ToString(); 
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavMeths NavMeths { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
#pragma warning restore 1591
