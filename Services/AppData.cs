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
        public static int rowNumMin { get; set; }=5;
        public static int rowNumMid { get; set; }=30;
        public static int rowNumMax { get; set; }=200;
        //---------------------------------------------------------------------
        public string appName { get; set; }="Woorj";
        public string orgName { get; set; }="TSB";
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
        public string ChoosedEntityBeckLink { get; set; } = "";
        public int UpdatedFK_Id { get; set; } = 0;


        public string designSite{get;set;}="css/site.css";
        public string designSiteBlue{get;set;}="css/site-blue.css";
        public string designSiteGray{get;set;}="css/site-gray.css";

        
        public bool readonlyMain1 {get;set;}=true;
        public bool readonlyMain2 {get;set;}=true;
        public bool readonlyOther {get;set;}=true;

        #endregion General
    
    #region Dir    
        public string GenderIdSlcd { get; set; }
        public string GenderCode { get; set; }
        public string GenderPageNum { get; set; } = "1";
        public string GenderLink { get; set; } = "/Dir/GenderViewStd/0";


        public string CountryIdSlcd { get; set; }
        public string CountryCode { get; set; }
        public string CountryPageNum { get; set; } = "1";
        public string CountryLink { get; set; } = "/Dir/CountryViewStd/0";

        public string UserRoleEditIdSlcd { get; set; }
        public string UserRoleEditCode { get; set; }
        public string UserRoleEditCode2 { get; set; }
        public string UserRoleEditPageNum { get; set; } = "1";
        public string UserRoleEditLink { get; set; } = "/Adm/UserRoleEdit/0";

 
   
    #endregion Dir

    #region Adm

 

        public string UserRoleEditRoleIdSlcd { get; set; }
        public string UserRoleEditRoleCode { get; set; }
        public string UserRoleEditRolePageNum { get; set; } = "1";
        public string UserRoleEditRoleLink { get; set; } = "/Adm/UserRoleEdit/0";

        public string ApplicationRoleIdSlcd { get; set; }
        public string ApplicationRoleCode { get; set; }
        public string ApplicationRolePageNum { get; set; } = "1";
        public string ApplicationRoleLink { get; set; } = "/Adm/ApplicationRoleViewStd/0";

        public string ApplicationUserIdSlcd { get; set; }
        public string ApplicationUserCode { get; set; }
        public string ApplicationUserPageNum { get; set; } = "1";
        public string ApplicationUserLink { get; set; } = "/Adm/ApplicationUserViewStd/0";

    #endregion Adm
    #region IndOrg
        public string ContactIdSlcd { get; set; }
        public string ContactCode { get; set; }
        public string ContactPageNum { get; set; } = "1";
        public string ContactLink { get; set; } = "/IndOrg/ContactViewStd/0";

        
        public string Individual_IdSelect { get; set; }="0";
        public string IndividualLink { get; set; } = "/IndOrg/IndividualViewStd/0";
    
    #endregion IndOrg




    }
}
