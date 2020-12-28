// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Woorj.Pages.Adm
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "e:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationRoleViewStd/{Id}")]
    public partial class ApplicationRoleViewStd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "e:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
            

   #region     Declare_Region
    [Parameter]
    public string Id { get; set; }
    private string selectedRow { get; set; } = "";
    private int CurrentPage { get; set; } = 1;
    private List<ApplicationRole> RoleList;
    private WrDataGrid<ApplicationRole> grid;

   #endregion  Declare_Region
    
    #region    LifeСycle_Region

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SrvRole.Init_RoleViewStd();
            
            RoleList = SrvRole.GetApplicationRoleById2(Id).ToList();
            //  selectedRow = AppData.ApplicationRoleIdSlcd;
            AppData.ActivePageName="View-ApplicationRole";
        }
        protected override void OnAfterRender(bool firstRender)
        {
          base.OnAfterRender(firstRender);
        }

        protected override void OnParametersSet()
        {
          base.OnParametersSet();
        }
    #endregion LifeСycle_Region_Region

    #region    Event_Region

        private void Role_SrchTxt(ChangeEventArgs changeEventArgs)
        {
            string searchValue = changeEventArgs.Value.ToString();
            RoleList = SrvRole.GetApplicationRoleByFiled(searchValue);
            GoToFirstPage();
            GetCurrentPage();         
        }
        private void SelectedRowMeth(string pSelectedRow)
        {
            
            selectedRow = pSelectedRow;
            AppData.ApplicationRoleIdSlcd= selectedRow;
            AppData.ApplicationRoleCode = SrvRole.GetApplicationRoleCodeById(selectedRow);
                //   AppData.ApplicationRolePageNum = grid.CurrentPage.ToString();
        }
        protected void FindSelectedRec()
        {
            //JSRuntime.InvokeVoidAsync("msgbox","Test");
            string searchValue = AppData.ApplicationRoleCode;
            RoleList = SrvRole.GetApplicationRoleByFiled(searchValue,Id);
            GoToFirstPage();
            GetCurrentPage();        
        }
        protected void CleanSearchBox()
        {
            //JSRuntime.InvokeVoidAsync("msgbox","Test");
            string searchValue = AppData.ApplicationRoleCode = "";
            RoleList = SrvRole.GetApplicationRoleByFiled(searchValue,Id);
            GoToFirstPage();
            GetCurrentPage();
            selectedRow = "";        
        }
    
    
       
        private void GoToFirstPage()
        {
        grid.GoToFirstPage();
        CurrentPage=1;    
        }  
        private void GetCurrentPage()
        {
            CurrentPage= grid.GetCurrentPage();        
        }  
        private void ViewOrEditFlag(string pViewOrEdit)
        {
            if(pViewOrEdit.ToUpper()=="VIEW")
            {
                AppData.readonlyMain1=true;
                AppData.readonlyMain2=true;
                AppData.readonlyOther=true;
            }
            else if(pViewOrEdit.ToUpper()=="EDIT")
            {
                AppData.readonlyMain1=true;
                AppData.readonlyMain2=true;
                AppData.readonlyOther=false; 
            }
        }
        protected void NavigateTo(string pNavLink)
        {
            NavManager.NavigateTo(pNavLink);
        }
        protected void AddNew(string pNavLink)
        {
            ViewOrEditFlag("EDIT");
            NavManager.NavigateTo(pNavLink);
        }
        protected void ViewOrEdit(string pNavLink, string p_selectedRow, string pViewOrEdit)
        {
            ViewOrEditFlag(pViewOrEdit);

            if (string.IsNullOrEmpty(p_selectedRow)   || p_selectedRow=="0") //String.IsNullOrEmpty(p_selectedRow)
            {
                JSRuntime.InvokeVoidAsync("msgbox",StatCls.GetTranslation("NotSelectedRecordMsg",@AppData.ActiveUser,"Msg"));
            }
            else
            {
                NavManager.NavigateTo(pNavLink + p_selectedRow);
            }
        }
        protected void Delete(string pNavLink, string p_selectedRow)
        {
            if (string.IsNullOrEmpty(p_selectedRow)) //String.IsNullOrEmpty(p_selectedRow)
            {
                JSRuntime.InvokeVoidAsync("msgbox",StatCls.GetTranslation("NotSelectedRecordMsg",@AppData.ActiveUser,"Msg"));
            }
            else
            {
                NavManager.NavigateTo(pNavLink + p_selectedRow);
            }

        }
        protected void ExportToExcel()
        {
            // JSRuntime.InvokeVoidAsync("msgbox", "ExportToExcel");
            SrvRole.GenerateExcel(JSRuntime,Id);
        }
        protected void FilterData()
        {
            JSRuntime.InvokeVoidAsync("msgbox", "FilterData");
            // SrvRole.FilterData(JSRuntime);
        }

    #endregion Event_Region


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationRoleController SrvRole { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
#pragma warning restore 1591
