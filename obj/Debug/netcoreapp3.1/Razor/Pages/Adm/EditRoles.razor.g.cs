#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ff78721fb65e57bcd6a594143f3a3507498f07"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Adm
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/EditRoles/{CurrentID}")]
    public partial class EditRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "fix-possition");
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(2);
            __builder.AddAttribute(3, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "input");
                __builder2.AddAttribute(5, "type", "button");
                __builder2.AddAttribute(6, "class", "btn bnt-style-general");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
                                                                                  UpdateRoles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "value", "Update");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n                    ");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "type", "button");
                __builder2.AddAttribute(12, "class", "btn btn bnt-style-general");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
                                                                                      Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "value", "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "label");
                __builder2.AddAttribute(17, "for", "Code");
                __builder2.AddAttribute(18, "class", "control-lable");
                __builder2.AddMarkupContent(19, "\r\n                        &nbsp;&nbsp; &nbsp;&nbsp;  ");
                __builder2.AddContent(20, 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
                                                    objRole.Code

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(21, "    ");
                __builder2.AddContent(22, 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
                                                                               objRole.NormalizedName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, " \r\n\r\n\t");
            __builder.OpenElement(24, "div");
            __builder.AddMarkupContent(25, @"<ul class=""myUL""><li><span class=""caret"">Beverages</span>
    <ul class="" ul-treev nested""><li>Water</li>
      <li>Coffee</li>
      <li><span class=""caret"">Tea</span>
        <ul class="" ul-treev nested""><li>Black Tea</li>
          <li>White Tea</li>
          <li><span class=""caret"">Green Tea</span>
            <ul class="" ul-treev nested""><li>Sencha</li>
              <li>Gyokuro</li>
              <li>Matcha</li>
              <li>Pi Lo Chun</li></ul></li></ul></li></ul></li></ul>
   ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "btn bnt-style-general");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
                                                   Test

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "tooltip");
            __builder.AddAttribute(30, "title", "Next Page");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "E:\A_NewProjects\01\Woorj\Pages\Adm\EditRoles.razor"
       

    #region  Declare
        [Parameter]
        public string CurrentID { get; set; }
        private string selectedRow { get; set; } = "";       
      //  private List<ApplicationRole> ApplicationRole_List; 
      //  private WrDataGrid<ApplicationRole> grid_DiffRoleList;      
        private ApplicationRole objRole = new ApplicationRole(); 
    #endregion  Declare
    
    #region  BlazorMethods
       protected override void OnInitialized()
        {
            SrvRole.Init_UserRoleEdit();
            objRole =  SrvRole.GetApplicationRoleById(CurrentID); // A 111
             // VGetUserRole_List = SrvUser.GetUserRoleById(CurrentID).ToList();
           // ApplicationRole_List=SrvRole.GetApplicationRole().ToList();
           // DiffRoleList   = ApplicationRole_List.Where(x => !VGetUserRole_List.Any(y => x.Id == y.RoleId)).ToList();
        } 

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("TreeView22");
    }
    #endregion  BlazorMethods

        private void SelectedRowMeth(string pSelectedRow)
        {
            selectedRow = pSelectedRow;
            AppData.UserRoleEditRoleIdSlcd = selectedRow;
            AppData.UserRoleEditRoleCode = SrvRole.GetApplicationRoleCodeById(selectedRow);
        }
        protected void Test()
        {
           JSRuntime.InvokeVoidAsync("TreeView22");
        }
        protected void UpdateRoles()
        {
          //  SrvUser.UpdateRoles(objUser);
            NavManager.NavigateTo("/Adm/ApplicationRoleViewStd/"+CurrentID);
        }
        void Cancel()
        {
            NavManager.NavigateTo("/Adm/ApplicationRoleViewStd/0");
        }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationRoleController SrvRole { get; set; }
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
