#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e58c7e867d93f8c87ce87afdc25fae48a4d8e28a"
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
#line 27 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\_Imports.razor"
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
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
 if (RoleList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.Woorj.Pages.Adm.ApplicationRoleViewStd.TypeInference.CreateWrDataGrid_0(__builder, 1, 2, 
#nullable restore
#line 15 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                             RoleList

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                            SrvRole.clmDef_RoleStd

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                               SelectedRowMeth

#line default
#line hidden
#nullable disable
            ), 5, "Id", 6, "Id,Name", 7, 
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                  trs.GetTranslation("ApplicationRoleViewStd",@AppData.ActiveUser,"Adm")

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                            new PagingConfig
                            {
                                Enabled = true,
                                CustomPager = false,
                                PageSize = @AppData.rowNumMid
                            }

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenElement(10, "a");
                __builder2.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                           args => AddNew("/Adm/ApplicationRoleAdd")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "value", "Add");
                __builder2.AddAttribute(13, "class", "menu-itms");
                __builder2.AddContent(14, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                           args => ViewOrEdit("/Adm/ApplicationRoleEdit/", selectedRow,"Edit")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "class", "menu-itms");
                __builder2.AddContent(19, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                           args => Delete("/Adm/ApplicationRoleDelete/", selectedRow)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "class", "menu-itms");
                __builder2.AddContent(24, "Delete");
                __builder2.CloseElement();
            }
            , 25, (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n            &nbsp &nbsp\r\n            ");
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrSrchDGrid>(27);
                __builder2.AddAttribute(28, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                               Role_SrchTxt

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "class", "btn bnt-style-general");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => FindSelectedRec()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "data-toggle", "tooltip");
                __builder2.AddAttribute(34, "title", "Search");
                __builder2.AddMarkupContent(35, "<span class=\"fa fa-search\" aria-hidden=\"true\" id=\"search-input\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "class", "btn bnt-style-general");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => CleanSearchBox()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "data-toggle", "tooltip");
                __builder2.AddAttribute(41, "title", "Clean search box");
                __builder2.AddMarkupContent(42, "<span class=\"fa fa-chevron-left\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            &nbsp &nbsp\r\n            ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "btn bnt-style-general");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => NavManager.NavigateTo(AppData.BaseUrlUri)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "data-toggle", "tooltip");
                __builder2.AddAttribute(48, "title", "Beck");
                __builder2.AddMarkupContent(49, "<span class=\"fa fa-backward\" aria-hidden=\"true\"></span> Beck");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "class", "btn bnt-style-general");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => AddNew("/Adm/ApplicationRoleAdd")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "data-toggle", "tooltip");
                __builder2.AddAttribute(55, "title", "Add");
                __builder2.AddMarkupContent(56, "<span class=\"fa fa-plus\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "class", "btn bnt-style-general");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => ViewOrEdit("/Adm/ApplicationRoleEdit/", selectedRow,"View")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "data-toggle", "tooltip");
                __builder2.AddAttribute(62, "title", "View");
                __builder2.AddMarkupContent(63, "<span class=\"fa fa-file\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "class", "btn bnt-style-general");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => ViewOrEdit("/Adm/ApplicationRoleEdit/", selectedRow,"Edit")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "data-toggle", "tooltip");
                __builder2.AddAttribute(69, "title", "Edit");
                __builder2.AddMarkupContent(70, "<span class=\"fa fa-pencil\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "class", "btn bnt-style-general");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => Delete("/Adm/ApplicationRoleDelete/", selectedRow)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "data-toggle", "tooltip");
                __builder2.AddAttribute(76, "title", "Delete");
                __builder2.AddMarkupContent(77, "<span class=\"fa fa-trash\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "class", "btn bnt-style-general");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => FilterData()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "data-toggle", "tooltip");
                __builder2.AddAttribute(83, "title", "Filter");
                __builder2.AddMarkupContent(84, "<span class=\"fa fa-filter\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.OpenElement(86, "button");
                __builder2.AddAttribute(87, "class", "btn bnt-style-general");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => ExportToExcel()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "data-toggle", "tooltip");
                __builder2.AddAttribute(90, "title", "Export to Excel");
                __builder2.AddMarkupContent(91, "<span class=\"fa fa-file-excel-o\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "button");
                __builder2.AddAttribute(94, "class", "btn bnt-style-general");
                __builder2.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                                                              args => ViewOrEdit("/Adm/EditRoles/", selectedRow,"EditRoles")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "data-toggle", "tooltip");
                __builder2.AddAttribute(97, "title", "EditRoles");
                __builder2.AddMarkupContent(98, "<span class=\"fa fa-hand-paper-o\" aria-hidden=\"true\"></span>");
                __builder2.CloseElement();
            }
            , 99, (__value) => {
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
                      grid = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 52 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRoleViewStd.razor"
            

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
namespace __Blazor.Woorj.Pages.Adm.ApplicationRoleViewStd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateWrDataGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Woorj.Data.WrComponents.PagingConfig __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg9)
        {
        __builder.OpenComponent<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.AddAttribute(__seq2, "SelectedRow", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "PageNameTitle", __arg5);
        __builder.AddAttribute(__seq6, "Paging", __arg6);
        __builder.AddAttribute(__seq7, "ControlMenu", __arg7);
        __builder.AddAttribute(__seq8, "ControlQuickAccess", __arg8);
        __builder.AddComponentReferenceCapture(__seq9, (__value) => { __arg9((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
