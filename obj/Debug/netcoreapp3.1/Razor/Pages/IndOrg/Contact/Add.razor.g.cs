#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2b0c762b528f55f598d862c50d98d9abefdea5"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg.Contact
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Contact/Add/{IndividualId}")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "ContactAdd");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "    \r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
                      _objContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
                                                   CreateContact

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "  \r\n        ");
                    __builder3.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "  \r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(13);
                    __builder3.AddAttribute(14, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(16);
                        __builder4.AddAttribute(17, "Category", "EditForm");
                        __builder4.AddAttribute(18, "TypeInput", "button");
                        __builder4.AddAttribute(19, "Txt", "Cancel");
                        __builder4.AddAttribute(20, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
                                                                                          Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(21, "\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(22);
                        __builder4.AddAttribute(23, "Category", "EditForm");
                        __builder4.AddAttribute(24, "TypeInput", "submit");
                        __builder4.AddAttribute(25, "Txt", "Save");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(28);
                    __builder3.AddAttribute(29, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(30, "\r\n\r\n                ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(31);
                        __builder4.AddAttribute(32, "FieldCaption", "Name");
                        __builder4.AddAttribute(33, "TransEntity", "General");
                        __builder4.AddAttribute(34, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
                                                             _objContact.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _objContact.Name = __value, _objContact.Name))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(36, "\r\n\r\n                ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(37);
                        __builder4.AddAttribute(38, "FieldCaption", "Description");
                        __builder4.AddAttribute(39, "TransEntity", "General");
                        __builder4.AddAttribute(40, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
                                                             _objContact.Description

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _objContact.Description = __value, _objContact.Description))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n        \r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, " \r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Contact\Add.razor"
      

    [Parameter] public string IndividualId { get; set; }
    readonly Contact _objContact= new Contact();
     protected override void OnInitialized()
    {
       _objContact.IndividualId=int.Parse(IndividualId);
    }

    private void CreateContact()
    { 
        MainController.Create(_objContact);
          AppData.GoBrwsNavigation(-1);
    }
    void Cancel(){
         AppData.GoBrwsNavigation(-1);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactController MainController { get; set; }
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
