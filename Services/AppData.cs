using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Woorj.Services
{
    public class AppData
    {
        public AppData()
        {
          
        }

    #region General
      //---------------------------------------------------------------------
        public static int rowNumMid { get; set; }=30;
        //---------------------------------------------------------------------

        public string BaseUrlUri { get; set; } = "";
        public string ActivePageName { get; set; } = "";
        public static string ActiveUser { get; set; } = "";
        public static string BrowserIterfaceLang { get; set; }="";
        public static string ActiveUserLang { get; set; }="";

        //---------------------------------------------------------------------
        public int flg_ChoosedRow { get; set; } = 0;
        public int ChoosedRowId { get; set; } = 0;

        public string ChoosedEntityName { get; set; } = "";
        public int ChoosedEntityId { get; set; } = 0;
        public string ChoosedEntityFK { get; set; } = "";
        public int UpdatedFK_Id { get; set; } = 0;


        public string designSite{get;set;}="css/site.css";

        
        public bool readonlyMain1 {get;set;}=true;
        public bool readonlyMain2 {get;set;}=true;
        public bool readonlyOther {get;set;}=true;

        #endregion General
    
    #region Dir    
        public string GenderIdSlcd { get; set; }
        public string GenderCode { get; set; }        
        public string Country_IdSelect { get; set; }="0";
        public string Gender_IdSelect { get; set; }="0";
      
    #endregion Dir

    #region Adm

        public string UserRoleEditRoleIdSlcd { get; set; }
        public string UserRoleEditRoleCode { get; set; }
        public string ApplicationRoleIdSlcd { get; set; }
        public string ApplicationRoleCode { get; set; }

        public string ApplicationUserIdSlcd { get; set; }
        public string ApplicationUserCode { get; set; }

    #endregion Adm
    
    #region IndOrg 
        
        public string Individual_IdSelect { get; set; }="0";
        public string IndividualLink { get; set; } = "/IndOrg/IndividualViewStd/0";
    
    #endregion IndOrg




    }
}
