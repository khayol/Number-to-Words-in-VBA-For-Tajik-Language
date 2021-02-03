using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Woorj.Data;
using Woorj.Services;

namespace Woorj.Services
{
    public static  class GlobVarStat
    {

    
        
        //-----------------------------------------------------------------------
        #region   DATA_AND_PRIMERY_INFO
        public static string connectionString { get; set; }=@"Server=HO-KHAYOL-LP\SQLEXPRESS;Database=Woorj555304B42405CA2E5BD2454CC54DF6;User Id=sa; password=Fmfb#2017";
        public static string connectionString1 { get; set; }=@"Server=CFT-SUPPORT\SQLEXPRESS;Database=Woorj555304B42405CA2E5BD2454CC54DF6;User Id=sa; password=Fmfb#2017";
        public static string dataArrExist { get; set; }="{***}"; 
        public static string dataArrEmpty { get; set; }="{...}";
        public static string nullval { get; set; }="nullval";
        public static string defCrutcher { get; set; }="EN";
         public static string defTranslDic { get; set; }="General";

        #endregion   DATA_AND_PRIMERY_INFO
        //---------------------------------------------------------------------
        #region   DATE_TIME
        public static string date_1900 { get; set; }="01-01-1900";
        public static string date_0001 { get; set; }="01-01-0001";
        //-----------------
        public static string date_sys_srv { get; set; }="getdate()";
        // public static string date_astronomic_srv { get; set; }="I Should Get it from server";
        // public static string date_sys_cli { get; set; }="May be like that: DateTime.Now.ToString()";
        //  public static string date_astrinomic_cli { get; set; }="I Should Get it from someware";
        #endregion   DATE_TIME
        //---------------------------------------------------------------------
        #region   DESIGN_SECTION
        public static string linkStyle { get; set; }="font-style: italic; color:#0000BA; ";
        public static string staticDataStyle { get; set; }="font-style: normal; color:black;";
        public static string tdMainStyle { get; set; }=@"white-space: nowrap;  
                                                          overflow: hidden; 
                                                          text-overflow: ellipsis;";
         #endregion   DESIGN_SECTION
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
    }
}