// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 11 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Toolbelt.Blazor.HeadElement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Data.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Adm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.Dir;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.CtrServerSide.IndOrg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.WrComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\A_NewProjects\01\Woorj\_Imports.razor"
using Woorj.Pages.TESTS.L22;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrEditView4.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class WrEditView4<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrEditView4.razor"
         


    
#region  Declare_Region

  private bool readonlyMain1 {get;set;}=false;
    private bool readonlyMain2 {get;set;}=false;
    private bool readonlyOther {get;set;}=false; 


    [Parameter]
    public string CurrentID { get; set; }
    [Parameter]
    public string BaseUrlUri { get; set; }
    [Parameter]
    public string ColumnsToExcludeCSV { get; set; }

    [Parameter]
    public string UniqIdOfRecord { get; set; }

    [Parameter]
    public string PageNameTitle { get; set; }
    [Parameter]
    public int CurrentPage { get; set; } = 1;

    private string ErrorMessage;
    [Parameter]
    public RenderFragment ControlMenu { get; set; }

    [Parameter]
    public RenderFragment ControlQuickAccess { get; set; }

       [Parameter]
    public PagingConfig Paging { get; set; } = new PagingConfig();

    [Parameter]
    public RenderFragment CustomPager { get; set; }

    [Parameter]
    public RenderFragment PageName { get; set; }

    [Parameter]
    public List<TItem> DataItems { get; set; }

    [Parameter]
    public List<ColumnDefinition> Columns { get; set; }

    [Parameter]
    public EventCallback<string> SelectedRow { get; set; } 
    
#endregion  Declare_Region

        protected override void OnInitialized()
     {


        readonlyMain1=AppData.readonlyMain1;
        readonlyMain2=AppData.readonlyMain2;
        readonlyOther=AppData.readonlyOther;

    }

 
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
     
    }

  

    #region Html_Markup_Cleanup

     private string AlignmentClass(ColumnDefinition column)
    {
        string alignmentClass = string.Empty;

        switch (column.Alignment)
        {
            case Alignment.Left:
                alignmentClass = "align-left";
                break;
            case Alignment.Center:
                alignmentClass = "align-center";
                break;
            case Alignment.Right:
                alignmentClass = "align-right";
                break;
            case Alignment.NotSet:
            default:
                alignmentClass = string.Empty;
                break;
        }

        return alignmentClass;
    }

    private string FontStyleHeader(ColumnDefinition column)
    {
        string fontStyle = string.Empty;
        string linkStyle=GlobVarStat.linkStyle; // dark Blue
        string staticDataStyle=GlobVarStat.staticDataStyle;

        switch (column.DataType)
        {
            
            case DataType.Collection: 
            case DataType.List:
            case DataType.LinkLine: 
            case DataType.RelatedData: 
                fontStyle = linkStyle; 
                break;
            case DataType.NotSet: 
                fontStyle =staticDataStyle;
                break;
            default:
                fontStyle =staticDataStyle;
                break;
        }

        return fontStyle;
    }

    private string FormatItemValue(TItem item, ColumnDefinition column, string pIdOfRecord)
    {
        #nullable enable
                string? value = string.Empty;
        #nullable restore
        if ((!string.IsNullOrWhiteSpace(column.Format) && column.DataType != DataType.NotSet) || column.DataType == DataType.List || column.DataType == DataType.Collection || column.DataType == DataType.RelatedData)
        {
            switch (column.DataType)
            {
                case DataType.Date:
                case DataType.DateTime:
                      value = typeof(TItem).GetProperty(column.DataField).GetValue(item)?.ToString() ?? GlobVarStat.nullval;
                    //value = DateTime.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()).ToString(column.Format);
                    //value=DateTime.Parse(value).ToString("dd-MM-yyyy");
                    //value=DateTime.ParseExact(value,"dd-MM-yyyy", CultureInfo.CreateSpecificCulture("fr-FR")).ToString();
                   if (value == GlobVarStat.date_1900 || value == GlobVarStat.date_0001)
                    {
                    value = GlobVarStat.nullval; //"nullval";
                    }
                    break;
                case DataType.Boolean:
                    value = bool.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()).ToString();
                    break;
                case DataType.Currency:
                    value = Math.Round(double.Parse(typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString()), 2).ToString("c");
                    break;
                case DataType.RelatedData:
               
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrEditView4.razor"
                   

                // value = typeof(TItem).GetProperty(column.DataField).GetValue(item)?.ToString() ?? GlobVarStat.nullval;
                //string x = typeof(TItem).GetProperty(column.DataField).GetValue(item).ToString();
                
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 295 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrEditView4.razor"
                   
                 
                    string SelectedFieldKey = typeof(TItem).GetProperty(column.SelectedFieldKey).GetValue(item)?.ToString() ?? GlobVarStat.nullval;
                    value= GnrSrv.GetReleatedData(column.DataField, column.SelectedField, SelectedFieldKey);                     
                    break;
                case DataType.Collection:
                case DataType.List:
                  value= GnrSrv.ExistDataORNotFlag(column.DataField, typeof(TItem).Name+"Id", pIdOfRecord); 
                   break;
                default:
                    break;
            }
        }
        else
        {
            value = typeof(TItem).GetProperty(column.DataField).GetValue(item)?.ToString() ?? GlobVarStat.nullval;
              
              if (GnrSrv.IsValidDateTime(value)){
              value=DateTime.Parse(value).ToString("dd-MM-yyyy");
              }

            if (value == GlobVarStat.date_1900 || value == GlobVarStat.date_0001)
            {
                value = GlobVarStat.nullval; //"nullval";
            }

            switch (column.DataType)
            {
               case DataType.Collection:
                case DataType.List:
                    value =GlobVarStat.dataArrEmpty; //"{...}";
                    break;
                case DataType.RelatedData:
                  value =  typeof(TItem).GetProperty(column.DataField).GetValue(item)?.ToString() ?? GlobVarStat.nullval; //"RelatedData_Null";//
                    break;    
                default:
                    break;
            }

        }

        return value;
    }

    #endregion Html_Markup_Cleanup

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GnrSrv GnrSrv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdmService admSer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoreService serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomTranslator trs { get; set; }
    }
}
#pragma warning restore 1591
