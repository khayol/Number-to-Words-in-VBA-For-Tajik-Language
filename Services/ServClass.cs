using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Woorj.Services;

namespace Woorj.Services
{
    public class ServClass
    {

    [Inject]
    public IJSRuntime JSRuntime { get; set; }   
    public NavigationManager NavManager;
    public AppData _AppData;

    private ICustomTranslator trs { get; set;}  
    public ServClass(NavigationManager navigationManager , AppData appData, IJSRuntime iJSRuntime)
    {
        NavManager=navigationManager;
        _AppData=appData;
        JSRuntime=iJSRuntime;
    }


    public void CRUD(string pOperType, string pNavLink, string pRecId)
    { 
        if (                            
                (
                    pOperType.ToUpper()!="C"  && (string.IsNullOrEmpty(pRecId) || pRecId=="0") 
                )
                && 
                (
                    pOperType.ToUpper()!="CU"  && (string.IsNullOrEmpty(pRecId) || pRecId=="0") 
                )                           
            )       
        {     
            JSRuntime.InvokeVoidAsync("msgbox",StatCls.GetTranslation("NotSelectedRecordMsg",@AppData.ActiveUser,"Msg"));
             Console.WriteLine("Exaption=> "+pNavLink + pRecId);
        }
        else if (pOperType.ToUpper()=="C"  && !string.IsNullOrEmpty(pNavLink) && (string.IsNullOrEmpty(pRecId) || pRecId=="0"))
        {
           NavManager.NavigateTo(pNavLink);
        } 
        else if (!string.IsNullOrEmpty(pNavLink) && (!string.IsNullOrEmpty(pRecId) || pRecId!="0"))
        {
           switch (pOperType.ToUpper())
            {
                case "R": case "U":  case "CU": case "D": case "N":
                    NavManager.NavigateTo(pNavLink + pRecId);
                    break;
            }    
               
        } 
     
    }

    }
}