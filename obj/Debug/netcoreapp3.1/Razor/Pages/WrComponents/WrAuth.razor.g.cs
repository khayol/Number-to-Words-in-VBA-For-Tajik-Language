#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9048c4db9f11cd38cacf20ab3bab25c0d6d49cbc"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.WrComponents
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
#line 13 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
    public partial class WrAuth : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
    if (Authorize)
   {   

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
                               admSer.GetRolesList(@PageName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
                 if (MainContent != null)
                {
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
                 MainContent

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
                            
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(6, "\r\n            ");
            }
            ));
            __builder.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((authContext) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n                 ");
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrPageNotFound>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, " \r\n");
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
   }else
   {
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
        if (MainContent != null)
            {
              

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, 
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
               MainContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
                          
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
             
   } 

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrAuth.razor"
    
    [Parameter] public bool Authorize { get; set; }=true;
    [Parameter] public string PageName { get; set; }
    [Parameter] public RenderFragment MainContent { get; set; }

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
