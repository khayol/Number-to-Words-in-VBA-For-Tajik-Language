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
       
    private static ICoreService coreService { get;set; }   

          
		private static string ConnStr="";
		private static	SqlConnection conn;
       
        static GlobVarStat()
        {
        ConnStr=GlobVarStat.connectionString;		
	 	      conn = new SqlConnection(ConnStr);
          defCrutcher= AppData.BrowserIterfaceLang;

         // rowNotChoosed_msg=coreService.GetGlobVar("rowNotChoosed_msg")?.ToUpper() ?? "nullval" ; // "sdsd";
         // dataArrExist=Get("dataArrExist","dataArrExist")?.ToString() ?? dataArrExist; // Working well if the result is not null
        }
 
   public static string Get(string pKeyWord, string pDefaultResult)
    {
      Object returnValue;	
      conn.Open();
      SqlCommand cmd = new SqlCommand();
        cmd.CommandText = " select DefaultVal from [dbo].[GlobalVariable] where Upper(KeyWord)=Upper(@pKeyWord)";  
        cmd.Connection = conn;	          
            
          cmd.Parameters.Add("@pKeyWord", SqlDbType.NVarChar);
          cmd.Parameters["@pKeyWord"].Value =  pKeyWord.ToUpper();

        returnValue = cmd.ExecuteScalar();
        if (string.IsNullOrEmpty(returnValue.ToString())){
        returnValue=pDefaultResult;
        }
      conn.Close();
      return Convert.ToString(returnValue);
	    }
              
        //-----------------------------------------------------------------------
        #region   DATA_AND_PRIMERY_INFO
        public static string connectionString { get; set; }=@"Server=HO-HAYOL-LPT\SQLEXPRESS;Database=Woorj555304B42405CA2E5BD2454CC54DF6;User Id=sa; password=Fmfb#2017";
        public static string dataArrExist { get; set; }="{***}"; //Get2("dataArrExist","{***123}"); //Get("dataArrExist","{***}")?.ToString() ?? "sd";//"{***}";
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
        public static string date_astronomic_srv { get; set; }="I Should Get it from server";
        public static string date_sys_cli { get; set; }="May be like that: DateTime.Now.ToString()";
        public static string date_astrinomic_cli { get; set; }="I Should Get it from someware";
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
        #region  MESSAGE_SECTION
        //public static string dontMatch_msg { get; set; }="Column definitions don't match the provided data.";
        //public static string sortMult_msg { get; set; }="Sorting on multiple columns are not supported.";
        //public static string dataItmNotProvided_msg { get; set; }="DataItems is not provided.";
        //public static string rowNotChoosed_msg { get; set; }="Please, choose the record before running this command";
        #endregion MESSAGE_SECTION
        //---------------------------------------------------------------------
    }
}