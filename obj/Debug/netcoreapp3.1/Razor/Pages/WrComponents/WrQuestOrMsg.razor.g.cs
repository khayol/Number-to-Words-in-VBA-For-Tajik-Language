#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a04034d49b76932655dfb9c075610d8e5ad030"
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
    public partial class WrQuestOrMsg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
 if (SpaceLength==0 || SpaceLength==1 ||SpaceLength<=1 )
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "   ");
            __builder.AddMarkupContent(1, "<a>&nbsp</a>\r\n");
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"

}else if (SpaceLength>1)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
     for (int i = 1; i < SpaceLength; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<a>&nbsp</a>     \r\n");
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 14 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
 if(Center)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "center");
            __builder.AddMarkupContent(7, "\r\n    \r\n");
#nullable restore
#line 18 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
     if (TxtSize=="h4")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "h4");
            __builder.AddAttribute(10, "style", "color:" + " " + (
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(11, 
#nullable restore
#line 20 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h3")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "style", "color:" + " " + (
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(16, 
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h2")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.OpenElement(19, "h2");
            __builder.AddAttribute(20, "style", "color:" + " " + (
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(21, 
#nullable restore
#line 26 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h1")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.OpenElement(24, "h1");
            __builder.AddAttribute(25, "style", "color:" + " " + (
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(26, 
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 30 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 32 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"

}else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
     if (TxtSize=="h4")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "    ");
            __builder.OpenElement(31, "h4");
            __builder.AddAttribute(32, "style", "color:" + " " + (
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(33, 
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 38 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h3")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.OpenElement(36, "h3");
            __builder.AddAttribute(37, "style", "color:" + " " + (
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(38, 
#nullable restore
#line 40 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 41 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h2")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.OpenElement(41, "h2");
            __builder.AddAttribute(42, "style", "color:" + " " + (
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(43, 
#nullable restore
#line 43 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 44 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }else if (TxtSize=="h1")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "    ");
            __builder.OpenElement(46, "h1");
            __builder.AddAttribute(47, "style", "color:" + " " + (
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                       Color

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:" + (
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                BackgroundColor

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(48, 
#nullable restore
#line 46 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
                                                                   trs.GetTranslation(@Txt,@AppData.ActiveUser,@EntityTrn)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "E:\A_NewProjects\01\Woorj\Pages\WrComponents\WrQuestOrMsg.razor"
   
   
    [Parameter]  public int SpaceLength { get; set; }=0; 
    [Parameter]  public string TxtSize { get; set; }="h4"; 
    [Parameter]  public bool Center { get; set; }=false; 
    [Parameter]  public string Txt { get; set; }=""; 
    [Parameter]  public string Color { get; set; }=""; 
    [Parameter]  public string BackgroundColor { get; set; }="transparent"; 
    [Parameter] public string EntityTrn { get; set; }="General"; 

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
