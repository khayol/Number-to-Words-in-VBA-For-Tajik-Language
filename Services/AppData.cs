﻿using System;
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
       
        public static string ActiveUser { get; set; } = "";
        public static string BrowserIterfaceLang { get; set; }="";
        public static string ActiveUserLang { get; set; }="";

        //---------------------------------------------------------------------
        public int flg_ChoosedRow { get; set; } = 0;
        public int ChoosedRowId { get; set; } = 0;

        public string ChoosedEntityName { get; set; } = "";
        public int ChoosedEntityId { get; set; } = 0;
        public string ChoosedEntityFK { get; set; } = ""; 

        public string designSite{get;set;}="css/site.css";
     
        #endregion General
    
    #region Dir    
        public string Country_IdSelect { get; set; }="0";
        public string Gender_IdSelect { get; set; }="0";
        public string Contact_IdSelect { get; set; }="0";
      
    #endregion Dir

    #region Adm
       public string ApplicationRole_IdSelect { get; set; }="0";
       public string ApplicationUser_IdSelect { get; set; }="0";

       public string UserRoleEditRoleIdSlcd { get; set; }
       public string UserRoleEditRoleCode { get; set; }

    #endregion Adm

    #region IndOrg 
        
        public string Individual_IdSelect { get; set; }="0";
    
    
    #endregion IndOrg

         /*

        */

    /* // Other Old Fields
        public string HomePageUrl { get; set; } = "https://localhost:5001/";
        public string MainMenuUrl { get; set; } = "/MainMenu";
        public string BaseUrlUri { get; set; } = "";
        public string ActivePageName { get; set; } = "";
        public int UpdatedFK_Id { get; set; } = 0;
            public string IndividualLink { get; set; } = "/IndOrg/Individual/ViewStd/0";
        */

   


    }
}
