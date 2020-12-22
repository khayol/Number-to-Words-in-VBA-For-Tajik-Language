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
    public ServClass(NavigationManager navigationManager , AppData appData, IJSRuntime iJSRuntime)
    {
        NavManager=navigationManager;
        _AppData=appData;
        JSRuntime=iJSRuntime;
    }

    public void CRUD(string pOperType, string pNavLink, string pRecId)
    {      
        //  CRUD => C=CREATE, R=READ,= U=UPDATE, D=DELETE

        if (pOperType.ToUpper()!="C" && (string.IsNullOrEmpty(pRecId) || int.Parse(pRecId)==0))       
        {
            JSRuntime.InvokeVoidAsync("msgbox",GlobVarStat.rowNotChoosed_msg);
        }
        else if (pOperType.ToUpper()=="C"  && !string.IsNullOrEmpty(pNavLink))
        {
           NavManager.NavigateTo(pNavLink);
        } 
        else if (pOperType.ToUpper()=="R" && !string.IsNullOrEmpty(pNavLink) && (!string.IsNullOrEmpty(pRecId) || int.Parse(pRecId)!=0))
        {
            _AppData.readonlyMain1=true;
            _AppData.readonlyMain2=true;
            _AppData.readonlyOther=true;
            NavManager.NavigateTo(pNavLink + pRecId);
        }else if (pOperType.ToUpper()=="U" && !string.IsNullOrEmpty(pNavLink) && (!string.IsNullOrEmpty(pRecId)  || int.Parse(pRecId)!=0))
        {
            _AppData.readonlyMain1=true;
            _AppData.readonlyMain2=true;
            _AppData.readonlyOther=false; 
            NavManager.NavigateTo(pNavLink + pRecId);
        }else if (pOperType.ToUpper()=="D" && !string.IsNullOrEmpty(pNavLink) && (!string.IsNullOrEmpty(pRecId)  || int.Parse(pRecId)!=0))
        {
            _AppData.readonlyMain1=true;
            _AppData.readonlyMain2=true;
            _AppData.readonlyOther=true; 
            NavManager.NavigateTo(pNavLink + pRecId);
        } 
     
    }
    }
}