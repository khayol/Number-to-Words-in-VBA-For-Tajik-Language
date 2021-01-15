using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

namespace Woorj.Services
{
    public static class StatCls
    {
      
      	static	StatCls()
		{
	 	   ConnStr=GlobVarStat.connectionString;		
	 	   conn = new SqlConnection(ConnStr);
		}

		private static string ConnStr="";
		private static	SqlConnection conn;
      
      
        public static IEnumerable<T> MyExcept2<T>(this IEnumerable<T> orgList, IEnumerable<T> toRemove)
        {
        var list = orgList.OrderBy(x => x).ToList();
        foreach (var x in toRemove)
        {
        var inx = list.BinarySearch(x);
        if (inx >= 0) list.RemoveAt(inx);
        }
        return list;
        }

          [Inject]
          private static IHttpContextAccessor hca { get; set; } = default!;
          public static string GetUserName()
          {
            return  hca?.HttpContext?.User?.Identity.Name.ToString() ?? "NN1"  ?? "NN2" ?? "NN3";
          }


        public static string GetModelNameFromObject(object pObject){
           string res=pObject.GetType().ToString().Replace("]","").Split(".").Last();
            return res;
        }

        public static string GetPxFromString(string pString)
        {
              using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                    {
                        SizeF size = graphics.MeasureString(pString, new Font("Segoe UI", 11, FontStyle.Regular, GraphicsUnit.Point));
                        return size.ToString();
                    }
                        
        }
        public static bool IsContains(string pLine,string pSearchStr)
        {

            bool res= false;
            // Split authors separated by a comma followed by space  
            string[] LineList = pLine.Split(",");  
            foreach (string itm in LineList)
            {
                if(itm.Trim().ToUpper()==pSearchStr.Trim().ToUpper())
                {
                     res=true;
                     break;
                }else{
                     res=false;         
                }
            }   
       
            return res;

        }

    public static string GetTranslation(string pKeyWord, string pAuthUser, string pEntity)
    {
	Object returnValue;	
	conn.Open();
	SqlCommand cmd = new SqlCommand();
    cmd.CommandText = " select gen.GetTranslation(@pKeyWord,@pAuthUser,@pEntity) Translation ";  
	cmd.Connection = conn;
	            
        cmd.Parameters.Add("@pKeyWord", SqlDbType.NVarChar);
        cmd.Parameters["@pKeyWord"].Value = pKeyWord;
            
        cmd.Parameters.Add("@pAuthUser", SqlDbType.NVarChar);
        cmd.Parameters["@pAuthUser"].Value = pAuthUser;
            
        cmd.Parameters.Add("@pEntity", SqlDbType.NVarChar);
        cmd.Parameters["@pEntity"].Value = pEntity;

		returnValue = cmd.ExecuteScalar();
	conn.Close();
	return Convert.ToString(returnValue);
	}


    }
}