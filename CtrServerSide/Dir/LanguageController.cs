using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Dir;

namespace Woorj.CtrServerSide.Dir
{
    public class LanguageController
    {
        private readonly ApplicationDbContext _db;

        public LanguageController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // Get all Language
        public List<Language> GetLanguage(){
          var list_Language=_db.Language.ToList();
          return list_Language;
        }

        // Get Language by ID
        public Language GetLanguageById(int id){
          Language Language= _db.Language.FirstOrDefault(s=> s.Id==id);
          return Language;        
        }
        public List<Language> GetLangActive(){

           var Language= _db.Language.Include(s=>s.Status).ThenInclude(t=>t.TypeList)
                          .Where(i=>
                                  i.Status.Name.ToUpper().Trim()== "Active".ToUpper().Trim()
                                  && i.Status.TypeList.Name.ToUpper().Trim()=="GeneralStatus".ToUpper().Trim() 
                                ).ToList();
          return Language;        
        }
       // Get Language by ID
         public List<Language> GetLanguageById2(int pId){
          //   var list_Language=_db.Language.Where(s=>s.Id==pId).ToList();
          // return list_Language;

            List<Language> list_Language;

            if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
             list_Language=_db.Language.ToList();
            }else
            {                
             list_Language=_db.Language.Where(s=>s.Id==pId).ToList();
            }
          return list_Language;
        }
        public string GetLanguageCodeById(int id){
          string code= _db.Language.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert Language
        public string Create(Language obj_Language){
              _db.Language.Add(obj_Language);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit Language
        public string UpdateLanguage(Language obj_Language){
              _db.Language.Update(obj_Language);
              _db.SaveChanges();
              return "Edited Successfully";

        }

          // Delete Language
        public string DeleteLanguage(Language obj_Language){
              _db.Remove(obj_Language); // _db.Language.Remove(obj_Language); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,int pId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "Language";
            IList<Language> LanguageList = _db.Language.Where(s=>s.Id==pId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = LanguageList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = LanguageList[i].Id;
                    worksheet.Cells[row, 2].Value = LanguageList[i].Code;
                    worksheet.Cells[row, 3].Value = LanguageList[i].Name;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<Language>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get Language by ByFiled
        public List<Language> GetLanguageByFiled(string searchTxt, int pId){
        var list_Language = _db.Language
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)) && 
                                      i.Id==pId                                      
                                  ).ToList();
        return list_Language;
       }



    }
}