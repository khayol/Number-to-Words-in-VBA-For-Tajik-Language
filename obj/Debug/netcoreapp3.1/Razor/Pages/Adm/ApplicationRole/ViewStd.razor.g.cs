#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c77e1ad6b7d254d923d9feafb8cb2dbc3eca1e"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Adm.ApplicationRole
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationRole/ViewStd/{Id}")]
    public partial class ViewStd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ApplicationRoleViewStd");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "   \r\n    ");
                __Blazor.Woorj.Pages.Adm.ApplicationRole.ViewStd.TypeInference.CreateWrDataGrid_0(__builder2, 4, 5, 
#nullable restore
#line 6 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                             _list

#line default
#line hidden
#nullable disable
                , 6, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                               SelectedRowMeth

#line default
#line hidden
#nullable disable
                ), 7, 
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                            MainController.clmDef_RoleStd

#line default
#line hidden
#nullable disable
                , 8, "Id", 9, "Id", 10, "ApplicationRoleViewStd::Adm", 11, "/MainMenu", 12, 
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                            new PagingConfig
                            {
                                Enabled = true,
                                CustomPager = false,
                                PageSize = @AppData.rowNumMid
                            }

#line default
#line hidden
#nullable disable
                , 13, (__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(15);
                    __builder3.AddAttribute(16, "Design", "a");
                    __builder3.AddAttribute(17, "Type", "C");
                    __builder3.AddAttribute(18, "Link", "/Adm/ApplicationRole/Add");
                    __builder3.AddAttribute(19, "Txt", "Add");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(21);
                    __builder3.AddAttribute(22, "Design", "a");
                    __builder3.AddAttribute(23, "Type", "R");
                    __builder3.AddAttribute(24, "Link", "/Adm/ApplicationRole/View/");
                    __builder3.AddAttribute(25, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                     SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "Txt", "View");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(28);
                    __builder3.AddAttribute(29, "Design", "a");
                    __builder3.AddAttribute(30, "Type", "U");
                    __builder3.AddAttribute(31, "Link", "/Adm/ApplicationRole/Edit/");
                    __builder3.AddAttribute(32, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                     SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Txt", "Edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(35);
                    __builder3.AddAttribute(36, "Design", "a");
                    __builder3.AddAttribute(37, "Type", "D");
                    __builder3.AddAttribute(38, "Link", "/Adm/ApplicationRole/Delete/");
                    __builder3.AddAttribute(39, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                     SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Txt", "Delete");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                }
                , 42, (__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSrchDGrid>(44);
                    __builder3.AddAttribute(45, "OnSearchTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                              SearchTxt

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(47);
                    __builder3.AddAttribute(48, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(50);
                    __builder3.AddAttribute(51, "Category", "RunCmd");
                    __builder3.AddAttribute(52, "Design", "btn");
                    __builder3.AddAttribute(53, "Ico", "fa fa-angle-double-down");
                    __builder3.AddAttribute(54, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                   CleanSearchBox

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(55, "TxtToolTip", "ShowMoreRecords");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(57);
                    __builder3.AddAttribute(58, "Category", "RunCmd");
                    __builder3.AddAttribute(59, "Design", "btn");
                    __builder3.AddAttribute(60, "Ico", "fa fa-hand-pointer-o");
                    __builder3.AddAttribute(61, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                FindSelectedRec

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(62, "TxtToolTip", "Choose");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(64);
                    __builder3.AddAttribute(65, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(67);
                    __builder3.AddAttribute(68, "Design", "btn");
                    __builder3.AddAttribute(69, "Type", "C");
                    __builder3.AddAttribute(70, "Ico", "fa fa-plus");
                    __builder3.AddAttribute(71, "Link", "/Adm/ApplicationRole/Add");
                    __builder3.AddAttribute(72, "TxtToolTip", "Add");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(74);
                    __builder3.AddAttribute(75, "Design", "btn");
                    __builder3.AddAttribute(76, "Type", "R");
                    __builder3.AddAttribute(77, "Ico", "fa fa-file");
                    __builder3.AddAttribute(78, "Link", "/Adm/ApplicationRole/View/");
                    __builder3.AddAttribute(79, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                         SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "TxtToolTip", "View");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(82);
                    __builder3.AddAttribute(83, "Design", "btn");
                    __builder3.AddAttribute(84, "Type", "U");
                    __builder3.AddAttribute(85, "Ico", "fa fa-pencil");
                    __builder3.AddAttribute(86, "Link", "/Adm/ApplicationRole/Edit/");
                    __builder3.AddAttribute(87, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                         SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "TxtToolTip", "Edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(90);
                    __builder3.AddAttribute(91, "Design", "btn");
                    __builder3.AddAttribute(92, "Type", "D");
                    __builder3.AddAttribute(93, "Ico", "fa fa-trash");
                    __builder3.AddAttribute(94, "Link", "/Adm/ApplicationRole/Delete/");
                    __builder3.AddAttribute(95, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                         SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "TxtToolTip", "Delete");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrSpace>(98);
                    __builder3.AddAttribute(99, "Length", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                            2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(101);
                    __builder3.AddAttribute(102, "Category", "RunCmd");
                    __builder3.AddAttribute(103, "Design", "btn");
                    __builder3.AddAttribute(104, "Ico", "fa fa-filter");
                    __builder3.AddAttribute(105, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                        FilterData

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(106, "TxtToolTip", "Filter");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(108);
                    __builder3.AddAttribute(109, "Category", "RunCmd");
                    __builder3.AddAttribute(110, "Design", "btn");
                    __builder3.AddAttribute(111, "Ico", "fa fa-file-excel-o");
                    __builder3.AddAttribute(112, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                              ExportToExcel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(113, "TxtToolTip", "ExportToExcel");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\r\n            ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrOper>(115);
                    __builder3.AddAttribute(116, "Design", "btn");
                    __builder3.AddAttribute(117, "Type", "U");
                    __builder3.AddAttribute(118, "Ico", "fa fa-hand-paper-o");
                    __builder3.AddAttribute(119, "Link", "/Adm/ApplicationRole/EditRoles/");
                    __builder3.AddAttribute(120, "LinkId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                                                                                                                   SelectedId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(121, "TxtToolTip", "EditUserRoles");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(122, "\r\n\r\n        ");
                }
                , 123, (__value) => {
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
                      _grid = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(124, "\r\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationRole\ViewStd.razor"
        


 #region     Declare
    [Parameter] public string Id { get; set; }
    private WrDataGrid<ApplicationRole> _grid;
    private List<ApplicationRole> _list;

      [Parameter] public string SelectedId { get; set;}="0";    
 
 #endregion  Declare

 #region    BlazorMethods

    protected override void OnInitialized()
    {
        MainController.Init_RoleViewStd();
        _list = MainController.GetById(Id).ToList();  
    }

#endregion BlazorMethods

#region    Event

    private void SearchTxt(ChangeEventArgs changeEventArgs)
    {
      string  searchValue = changeEventArgs.Value.ToString();
        _list = MainController.GetSearchByField(searchValue);
        _grid.GoToFirstPage();
    }
    private void SelectedRowMeth(string pSelectedRow)
    {
        SelectedId = pSelectedRow;
    }

    private void FindSelectedRec()
    {
        _grid.GoToFirstPage();
        _list = MainController.GetById(SelectedId);
    }

    private void CleanSearchBox()
    {
        _grid.GoToFirstPage();
        _list = MainController.GetSearchByField("");
        SelectedId = "0";
    }

    private void ExportToExcel()
    {
       // MainController.GenerateExcel(JSRuntime);
    }

    private void FilterData()
    {
        JSRuntime.InvokeVoidAsync("msgbox", "FilterData");
    }
 #endregion Event


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationRoleController MainController { get; set; }
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
namespace __Blazor.Woorj.Pages.Adm.ApplicationRole.ViewStd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateWrDataGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg1, int __seq2, global::System.Collections.Generic.List<global::Woorj.Data.WrComponents.ColumnDefinition> __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::Woorj.Data.WrComponents.PagingConfig __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::System.Action<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>> __arg10)
        {
        __builder.OpenComponent<global::Woorj.Pages.WrComponents.WrDataGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "DataItems", __arg0);
        __builder.AddAttribute(__seq1, "SelectedRow", __arg1);
        __builder.AddAttribute(__seq2, "Columns", __arg2);
        __builder.AddAttribute(__seq3, "UniqIdOfRecord", __arg3);
        __builder.AddAttribute(__seq4, "ColumnsToExcludeCSV", __arg4);
        __builder.AddAttribute(__seq5, "PageNameTitle", __arg5);
        __builder.AddAttribute(__seq6, "BackLink", __arg6);
        __builder.AddAttribute(__seq7, "Paging", __arg7);
        __builder.AddAttribute(__seq8, "ControlMenu", __arg8);
        __builder.AddAttribute(__seq9, "ControlQuickAccess", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::Woorj.Pages.WrComponents.WrDataGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
