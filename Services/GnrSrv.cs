
using Woorj.Data;
using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;
using Woorj.Data.IndOrg;
using Woorj.CtrServerSide.IndOrg;

namespace Woorj.Services
{
    public class GnrSrv
    {
        private readonly ApplicationDbContext _db;

        public GnrSrv(ApplicationDbContext db)
        {
            _db=db;
        }
    

        public bool IsValidDateTime(string dateTime)
        {
        string[] formats = { "MM/dd/yyyy" };
        DateTime parsedDateTime;
        return DateTime.TryParseExact(dateTime, formats, new CultureInfo("en-US"),
                                DateTimeStyles.None, out parsedDateTime);
        }

     public string ExistDataORNotFlag(string pTableName, string pForeinKey,string pIdOfRecord)
       { 
        string result=GlobVarStat.dataArrEmpty;
            var command  = _db.Database.GetDbConnection().CreateCommand();

            var IdOfRecordParam = new SqlParameter("IdOfRecord", SqlDbType.Char);
            IdOfRecordParam.Value = pIdOfRecord;
            command.Parameters.Add(IdOfRecordParam);

            // command.CommandText = "SELECT Max(Id) From dbo."+pTableName+" where " +pForeinKey+" =@IdOfRecord";
            command.CommandText = "SELECT TOP 1 1  From dbo."+pTableName+" where " +pForeinKey+" =@IdOfRecord";

            _db.Database.OpenConnection();
            string existData = command.ExecuteScalar()?.ToString() ?? "";
            _db.Database.CloseConnection();

            if(!string.IsNullOrEmpty(existData)) 
            {
                result=GlobVarStat.dataArrExist; // "{***}";
            }else{
                result=GlobVarStat.dataArrEmpty;  //"{...}";
            }

        return result;
         
       }
       
       public string GetReleatedData(string pTableName, string pSeletedFiledName, string pIdOfRecord)
       { 
        string result=GlobVarStat.nullval;
           if (pIdOfRecord==GlobVarStat.nullval){
               result=GlobVarStat.nullval;
           }else {
            var command  = _db.Database.GetDbConnection().CreateCommand();

            var IdOfRecordParam = new SqlParameter("IdOfRecord", SqlDbType.Char);
            IdOfRecordParam.Value = pIdOfRecord;
            command.Parameters.Add(IdOfRecordParam);

            string queryTxt= "SELECT "+pSeletedFiledName+" From dbo."+pTableName+" where Id = @IdOfRecord";
           // Console.WriteLine(queryTxt);
            command.CommandText =queryTxt;               
             _db.Database.OpenConnection();
             string existData = command.ExecuteScalar().ToString();
             _db.Database.CloseConnection();

            if(!string.IsNullOrEmpty(existData)) 
            {
                result=existData;
            }else{
                result=GlobVarStat.nullval; 
            }
            
        }

        return result;
         
       }  

       
       public void UpdateReleatedDataMain(int pChoosedEntityId, string pChoosedEntityFK, int pIdSelected, string pChoosedEntityName)
       { 
            if (pChoosedEntityName.ToUpper()=="Individual".ToUpper())
            {
            IndividualController IndividualController= new IndividualController(_db);
            IndividualController.UpdateSome_FK_Key(pChoosedEntityId,pChoosedEntityFK,pIdSelected);
            }
                
       }

       
       
      /*
       public void UpdateReleatedData(string pChoosedEntityName, int pChoosedEntityId, 
                                      string pChoosedEntityFK, int pIdOfRecord)
       { 
            var command  = _db.Database.GetDbConnection().CreateCommand();
           
            var IdOfRecordParam = new SqlParameter("IdOfRecord", SqlDbType.Char);
            IdOfRecordParam.Value = pIdOfRecord;
            command.Parameters.Add(IdOfRecordParam);           
           
            var ChoosedEntityIdParam = new SqlParameter("pChoosedEntityId", SqlDbType.Char);
            ChoosedEntityIdParam.Value = pChoosedEntityId;
            command.Parameters.Add(ChoosedEntityIdParam);

            string queryTxt= "UPDATE dbo."+pChoosedEntityName+"  SET "+pChoosedEntityFK+"=@IdOfRecord where Id= @pChoosedEntityId";

            command.CommandText =queryTxt;               
            _db.Database.OpenConnection();
             command.ExecuteNonQuery();
            _db.Database.CloseConnection();
         
       }     
        
       public int UpdateDataAndGetReleatedId(string pChoosedEntityName, int pChoosedEntityId, 
                                      string pChoosedEntityFK, int pIdOfRecord)
       { 
            
            int result=0;
            var command  = _db.Database.GetDbConnection().CreateCommand();
           
            var IdOfRecordParam = new SqlParameter("IdOfRecord", SqlDbType.Char);
            IdOfRecordParam.Value = pIdOfRecord;
            command.Parameters.Add(IdOfRecordParam);           
           
            var ChoosedEntityIdParam = new SqlParameter("pChoosedEntityId", SqlDbType.Char);
            ChoosedEntityIdParam.Value = pChoosedEntityId;
            command.Parameters.Add(ChoosedEntityIdParam);

            string queryTxt= "UPDATE dbo."+pChoosedEntityName+"  SET "+pChoosedEntityFK+"=@IdOfRecord where Id= @pChoosedEntityId";

            command.CommandText =queryTxt;               
            _db.Database.OpenConnection();
             command.ExecuteNonQuery();
            _db.Database.CloseConnection();
            
            result=pIdOfRecord;
         
         return result;
       }
       */
    }
}