using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Woorj.Services
{
    public class AppData
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }  

        public AppData( IJSRuntime iJSRuntime)
        {
               JSRuntime=iJSRuntime;
        }

    #region General
        //---------------------------------------------------------------------
        public static int rowNumMid { get; set; }=30;
        //---------------------------------------------------------------------       
        public static string ActiveUser { get; set; } = "";
        public static string BrowserIterfaceLang { get; set; }="";
        public static string ActiveUserLang { get; set; }="";
        //---------------------------------------------------------------------
        public string ChoosedEntityName { get; set; } = "";
        public int ChoosedEntityId { get; set; } = 0;
        public string ChoosedEntityFK { get; set; } = ""; 
        //---------------------------------------------------------------------     
        #endregion General
    
     public void GoBrwsNavigation(Object pVal)
    {
        JSRuntime.InvokeAsync<object>("brws.historyGo", pVal);
    }

    


    }
}
