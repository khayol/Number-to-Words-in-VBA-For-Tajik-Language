#pragma checksum "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801da65f7b4f8a798e07cb1b6dfeb8d025cc533a"
// <auto-generated/>
#pragma warning disable 1591
namespace Woorj.Pages.IndOrg.Individual
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/IndOrg/Individual/Delete/{CurrentId}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Woorj.Pages.WrComponents.WrAuth>(0);
            __builder.AddAttribute(1, "PageName", "IndividualDelete");
            __builder.AddAttribute(2, "MainContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "  \r\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                  _objMain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                            DeleteRow

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                                                         Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder3) => {
                    __builder3.AddMarkupContent(9, "  \r\n   \r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrPnlElm>(10);
                    __builder3.AddAttribute(11, "ControlQuickAccess", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(12, "\r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(13);
                        __builder4.AddAttribute(14, "Category", "EditForm");
                        __builder4.AddAttribute(15, "TypeInput", "button");
                        __builder4.AddAttribute(16, "Txt", "Cancel");
                        __builder4.AddAttribute(17, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                                                                           Cancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n             ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrOper>(19);
                        __builder4.AddAttribute(20, "Category", "EditForm");
                        __builder4.AddAttribute(21, "TypeInput", "submit");
                        __builder4.AddAttribute(22, "Txt", "Delete");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n\r\n    ");
                    __builder3.OpenComponent<Woorj.Pages.WrComponents.WrFormBody>(25);
                    __builder3.AddAttribute(26, "FormElements", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrQuestOrMsg>(28);
                        __builder4.AddAttribute(29, "Txt", "AreYouSureToDeteteRow");
                        __builder4.AddAttribute(30, "Color", "Black");
                        __builder4.AddAttribute(31, "BackgroundColor", "yellow");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n           \r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldInt>(33);
                        __builder4.AddAttribute(34, "TransEntity", "Individual");
                        __builder4.AddAttribute(35, "FieldCaption", "Code");
                        __builder4.AddAttribute(36, "Readonly", "true");
                        __builder4.AddAttribute(37, "Val", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                  _objMain.Code

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(39);
                        __builder4.AddAttribute(40, "Readonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "FieldCaption", "FirstName");
                        __builder4.AddAttribute(42, "TransEntity", "Individual");
                        __builder4.AddAttribute(43, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                                            _objMain.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _objMain.FirstName = __value, _objMain.FirstName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, " \r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(46);
                        __builder4.AddAttribute(47, "Readonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "FieldCaption", "SecondName");
                        __builder4.AddAttribute(49, "TransEntity", "Individual");
                        __builder4.AddAttribute(50, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                                            _objMain.SecondName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _objMain.SecondName = __value, _objMain.SecondName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(52, "\r\n\r\n            ");
                        __builder4.OpenComponent<Woorj.Pages.WrComponents.WrFieldStr>(53);
                        __builder4.AddAttribute(54, "Readonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                  true
            

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "FieldCaption", "LastName");
                        __builder4.AddAttribute(56, "TransEntity", "Individual");
                        __builder4.AddAttribute(57, "BindingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
                                                            _objMain.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "BindingValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _objMain.LastName = __value, _objMain.LastName))));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "    \r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "    \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\A_NewProjects\01\Woorj\Pages\IndOrg\Individual\Delete.razor"
      

    [Parameter] public string CurrentId { get; set; }
    Individual _objMain = new Individual();  

    protected override void OnInitialized()
    {
        _objMain = MainController.GetById_FirstOrDefault(Convert.ToInt32(CurrentId));
    }

    private void DeleteRow()
    {
        MainController.Delete(_objMain);
        NavManager.NavigateTo("/IndOrg/Individual/ViewStd/"+CurrentId);
    }
    void Cancel()
    {
        NavManager.NavigateTo("/IndOrg/Individual/ViewStd/"+CurrentId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IndividualController MainController { get; set; }
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
