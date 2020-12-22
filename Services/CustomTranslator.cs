using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.GeneralComponents;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Woorj.Pages.IndOrg;
using Woorj.Data;
using Woorj.Data.Adm;

namespace Woorj.Services
{
    

     public interface ICustomTranslator
    {
        string GetTranslation(string pKeyWord, string pAuthUser, string pEntity);
        string GetIdByUserName(string pUserName);
        string GetTheBrowserIterfaceLang(string pAlpha2);
        string GetLangNameByAlpha2(string pAlpha2, string pFieldName);
        string GetActiveUserLang(string pUserName);

        void LangChange(ApplicationUser obj_ApplUser);
    }

    public class CustomTranslator : ICustomTranslator
    {
       
      protected readonly ApplicationDbContext _db;

      public CustomTranslator(ApplicationDbContext db)
        {
            _db=db;
        }
      public string GetIdByUserName(string pUserName)
      { 
         string res="";
         if (!string.IsNullOrWhiteSpace( pUserName)){
            res= _db.ApplicationUser.FirstOrDefault(s=> s.UserName==pUserName).Id.ToString();
         }else{
           res="";
         }
          return res; 
      }

      public  string GetTheBrowserIterfaceLang(string pAlpha2)
      {
        GlobVarStat.defCrutcher=pAlpha2;
        AppData.BrowserIterfaceLang=pAlpha2;
        return pAlpha2;
      }

      public string GetLangNameByAlpha2(string pAlpha2, string pFieldName)
      {
        string res="";
        if(pFieldName.ToUpper().Trim()=="NativeName".ToUpper()){
           res= _db.Language.FirstOrDefault(s=> s.Alpha2==pAlpha2).NativeName.ToString();
        }else if (pFieldName.ToUpper().Trim()=="Name".ToUpper()){
             res= _db.Language.FirstOrDefault(s=> s.Alpha2==pAlpha2).Name.ToString();
        }
        return res;
      }
      public string GetActiveUserLang(string pUserName)
      {
          string res=GlobVarStat.nullval;
          if (!string.IsNullOrWhiteSpace(pUserName)){
          var languageId= _db.ApplicationUser.FirstOrDefault(s=> s.UserName==pUserName)?.LanguageId ?? 0;
            if (languageId!=0){
             res=_db.Language.FirstOrDefault(u=>u.Id==languageId).NativeName.ToString();
            }else{
               res=GlobVarStat.nullval;
            }
          }else{
               res=GlobVarStat.nullval;
          }
          return res;
      }

      public void LangChange(ApplicationUser obj_ApplUser){         
            _db.ApplicationUser.Update(obj_ApplUser);
              _db.SaveChanges();
      }   

     public string GetTranslation(string pKeyWord, string pAuthUser, string pEntity){
          string trans="";
          int languageId=0;
         if (string.IsNullOrWhiteSpace(pAuthUser)){

              trans= _db.Localization.Include(s=>s.Language).FirstOrDefault(s=>
                                     s.KeyWord.ToUpper().Trim()==pKeyWord.ToUpper().Trim()
                                  && s.EntityName.ToUpper().Trim()==pEntity.ToUpper().Trim() 
                                  && s.Language.Alpha2.ToUpper().Trim()==GlobVarStat.defCrutcher.ToUpper().Trim() //AppData.BrowserIterfaceLang.ToString().Trim() //
                                   )?.Translation.ToString() ?? pKeyWord;   

              if(trans.Trim().ToUpper()==pKeyWord.Trim().ToUpper()) //If the KeyWord not found with Entity then search it on General translation also
              {
                    trans= _db.Localization.Include(s=>s.Language).FirstOrDefault(s=>
                                     s.KeyWord.ToUpper().Trim()==pKeyWord.ToUpper().Trim()
                                  && s.EntityName.ToUpper().Trim()== GlobVarStat.defTranslDic.ToUpper().Trim()
                                  && s.Language.Alpha2.ToUpper().Trim()==GlobVarStat.defCrutcher.ToUpper().Trim() //AppData.BrowserIterfaceLang.ToString().Trim() //
                                  )?.Translation.ToString() ?? pKeyWord;             
              }                

        } else if (!string.IsNullOrWhiteSpace(pAuthUser)){
              languageId= _db.ApplicationUser.FirstOrDefault(s=>
                                    s.UserName.ToUpper().Trim()==pAuthUser.ToUpper().Trim()
                                    )?.LanguageId ?? //(if the User Lang not set then use the Browser Language)
                                    _db.Language.FirstOrDefault(l=>l.Alpha2==AppData.BrowserIterfaceLang)?.Id ?? 0; 
                   

              trans= _db.Localization.FirstOrDefault(s=>
                                   s.KeyWord.ToUpper().Trim()==pKeyWord.ToUpper().Trim()
                                && s.EntityName.ToUpper().Trim()==pEntity.ToUpper().Trim() 
                                && s.LanguageId==languageId //pLan.ToUpper().Trim()
                             )?.Translation.ToString() ?? pKeyWord;  
              
              if(trans.Trim().ToUpper()==pKeyWord.Trim().ToUpper()) //If the KeyWord not found with Entity then search it on General translation also
              {
                    trans= _db.Localization.Include(s=>s.Language).FirstOrDefault(s=>
                                     s.KeyWord.ToUpper().Trim()==pKeyWord.ToUpper().Trim()
                                  && s.EntityName.ToUpper().Trim()==GlobVarStat.defTranslDic.ToUpper().Trim() 
                                  && s.LanguageId==languageId //pLan.ToUpper().Trim()
                                  )?.Translation.ToString() ?? pKeyWord;             
              }                                  


        } 
        
     
                
          return trans.Trim();
        }

    
}
 
}