#pragma checksum "E:\NewProjects\01\Woorj\Pages\IndOrg\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4932d4a18712d2dccbb3a81f86e97054748e750c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Woorj.Pages.IndOrg
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.WrComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Delete/{CurrentId}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\NewProjects\01\Woorj\Pages\IndOrg\Delete.razor"
      
   [Parameter]
   public string CurrentId {get;set;}
    Individual objEmp= new Individual();

    protected override async Task OnInitializedAsync()
    {
    objEmp= await Task.Run(()=>objIndividualController.GetIndividualById(Convert.ToInt32(CurrentId)));        
    }
    
    protected void DeleteIndividual(){

        objIndividualController.DeleteIndividual(objEmp);
        NavigationManager.NavigateTo("/IndOrg/ViewStd");
    }
    void Cancel(){
        NavigationManager.NavigateTo("/IndOrg/ViewStd");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IndividualController objIndividualController { get; set; }
    }
}
#pragma warning restore 1591
