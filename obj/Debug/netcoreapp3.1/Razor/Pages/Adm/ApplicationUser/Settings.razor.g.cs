#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d3cd03c14d12974e32be1fb8cc4f8b0a926bc7"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.Adm.ApplicationUser
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adm/ApplicationUser/Settings/{CurrentID}")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ApplicationUserSettings");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(3);
                __builder2.AddAttribute(4, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(5, "input");
                    __builder3.AddAttribute(6, "type", "button");
                    __builder3.AddAttribute(7, "class", "btn btn bnt-style-general");
                    __builder3.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "value", 
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                                            trs.GetTranslation("Cancel",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(10, "\r\n          ");
                    __builder3.OpenElement(11, "input");
                    __builder3.AddAttribute(12, "type", "button");
                    __builder3.AddAttribute(13, "class", "btn bnt-style-general");
                    __builder3.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                        Save

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "value", 
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                                      trs.GetTranslation("Save",@AppData.ActiveUser,"General")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n    ");
                __builder2.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(17);
                __builder2.AddAttribute(18, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "form-group");
                    __builder3.OpenElement(21, "label");
                    __builder3.AddAttribute(22, "for", "Language");
                    __builder3.AddAttribute(23, "class", "control-lable");
                    __builder3.AddContent(24, 
#nullable restore
#line 18 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                          trs.GetTranslation("UserLangage",@AppData.ActiveUser?.ToString() ?? "","Adm")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n                          ");
                    __builder3.OpenElement(26, "select");
                    __builder3.AddAttribute(27, "class", "form-control selectpicker");
                    __builder3.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                             objMain.LanguageId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMain.LanguageId = __value, objMain.LanguageId));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.OpenElement(30, "option");
                    __builder3.AddContent(31, "--select--");
                    __builder3.CloseElement();
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                             foreach (var item in LanguageList)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(32, "option");
                    __builder3.AddAttribute(33, "value", 
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(34, 
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(35, " (");
                    __builder3.AddContent(36, 
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                  item.NativeName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(37, ")");
                    __builder3.CloseElement();
#nullable restore
#line 23 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
                                                                                            // Blazor needs to know what values it binds to!
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "E:\A_NewProjects\01\Woorj\Pages\Adm\ApplicationUser\Settings.razor"
      

    [Parameter] public string CurrentID { get; set; }
    ApplicationUser objMain = new ApplicationUser();
    public List<Language> LanguageList;
        
     protected override void OnInitialized()
    {
        objMain =  MainController.GetApplicationUserById(CurrentID);
        LanguageList =  LanguageController.GetLangActive();
     }

    protected void Save()
    {
       MainController.UpdateApplicationUser(objMain);    
        GoBrwsNavigation(-2); 
    }
    void Cancel()
    {
         GoBrwsNavigation(-2);   
    }
     public  void GoBrwsNavigation(int pVal)
    {
        JSRuntime.InvokeAsync<object>("brws.historyGo", pVal);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LanguageController LanguageController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserController MainController { get; set; }
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
