#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "472ea120c62b7cd299e6eb1d604ef6c4b0a86afd"
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
    public partial class WrOper : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
  if(Category.ToUpper().Trim()=="CRUD".ToUpper())
 {
         if(!string.IsNullOrEmpty(@SubPage)){
          Link=@Link.Trim().ToString()+@SubPage.Trim().ToString();  
          }
    
    if(Design.ToUpper().Trim()=="a".ToUpper())
    {
      Cls="menu-itms";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                   args => CRUD(@Type,@Link,@LinkId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "value", 
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                               Val

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
             Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, 
#nullable restore
#line 12 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                             trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
    }else if (Design.ToUpper().Trim()=="btn".ToUpper()) 
    {
       Cls="btn bnt-style-general";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                      Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                 args => CRUD(@Type,@Link,@LinkId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "data-toggle", "tooltip");
            __builder.AddAttribute(9, "title", 
#nullable restore
#line 17 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                        trs.GetTranslation(@TxtToolTip,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 18 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                    Ico.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "aria-hidden", "true");
            __builder.AddContent(13, 
#nullable restore
#line 18 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                       trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
    }
 }else if (Category.ToUpper().Trim()=="RunCmd".ToUpper())
 {
    if(Design.ToUpper().Trim()=="a".ToUpper())
    {
      Cls="menu-itms";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                 OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                          Val

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
             Cls

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, 
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
    }else if (Design.ToUpper().Trim()=="btn".ToUpper()) 
    {
       Cls="btn bnt-style-general";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", 
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                      Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                               OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "data-toggle", "tooltip");
            __builder.AddAttribute(23, "title", 
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                        trs.GetTranslation(@TxtToolTip,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", 
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                    Ico.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "aria-hidden", "true");
            __builder.AddContent(27, 
#nullable restore
#line 33 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                       trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
    }

    
 }else if (Category.ToUpper().Trim()=="EditForm".ToUpper())
 {
           Cls="btn bnt-style-general";
           
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
            if (@EditOrView==true)
           {
               

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                if( ReadonlyOther==false )
               {
                  CancelOrBeckTxt="Cancel";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                TypeInput.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                             Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                      OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                                                trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 48 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
               
               }else if ( ReadonlyOther==true ){
               CancelOrBeckTxt="Back";

                   if(@TypeInput=="submit"){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "hidden");
            __builder.AddAttribute(35, "class", 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                 Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                          OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "value", 
#nullable restore
#line 53 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                                    trs.GetTranslation(@CancelOrBeckTxt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                   }else if(@TypeInput=="button"){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", 
#nullable restore
#line 55 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                   TypeInput.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "class", 
#nullable restore
#line 55 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                         OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "value", 
#nullable restore
#line 55 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                                                   trs.GetTranslation(@CancelOrBeckTxt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                   
                   }

               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                          

            }else{
 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", 
#nullable restore
#line 63 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                          TypeInput.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "class", 
#nullable restore
#line 63 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                       Cls.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 63 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
                                                                                                          trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 64 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
             
      
       }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrOper.razor"
        
  
    [Parameter]  
    public string Design { get; set; }="";   
    [Parameter]  
    public string Cls { get; set; }="";
    [Parameter]  
    public string Ico { get; set; }=""; 

    [Parameter]  
    public bool EditOrView{ get; set; }=false; 

    [Parameter]  
    public bool ReadonlyOther { get; set; }=false; 

    [Parameter]  
    public string CancelOrBeckTxt { get; set; }=""; 


    [Parameter]  
    public string Category { get; set; }="CRUD"; 

    [Parameter]  
    public string Type { get; set; }="";  

    [Parameter]  
    public string TypeInput { get; set; }="";  
   
    [Parameter]  
    public string Link { get; set; } =""; 
    
   [Parameter]  
    public string SubPage { get; set; } =""; 
    
    [Parameter]  
    public string LinkId { get; set; }="";   

    [Parameter]
    public string TxtToolTip { get; set; }=""; 

    [Parameter]
    public string Txt { get; set; }=""; 

    [Parameter]
    public string EntityTrn { get; set; }="General"; 
    
    [Parameter]
    public string Val { get; set; }=""; 

      [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    private void CRUD(string pOperType, string pNavLink, string pRecId)
    {         
        ServClass servClass = new ServClass(NavManager,AppData,JSRuntime);
                  servClass.CRUD(pOperType,pNavLink, pRecId);
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
