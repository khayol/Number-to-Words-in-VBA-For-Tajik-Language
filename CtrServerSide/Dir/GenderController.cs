using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Dir;

namespace Woorj.CtrServerSide.Dir
{
    public class GenderController
    {
        private readonly ApplicationDbContext _db;

        public GenderController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // Get all Gender
        public List<Gender> GetGender(){
          var list_Gender=_db.Gender.ToList();
          return list_Gender;
        }

        // Get Gender by ID
        public Gender GetGenderById(int id){
          Gender Gender= _db.Gender.FirstOrDefault(s=> s.Id==id);
          return Gender;
        
        }
       // Get Gender by ID
         public List<Gender> GetGenderById2(int pId){
          //   var list_Gender=_db.Gender.Where(s=>s.Id==pId).ToList();
          // return list_Gender;

            List<Gender> list_Gender;

            if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
             list_Gender=_db.Gender.ToList();
            }else
            {                
             list_Gender=_db.Gender.Where(s=>s.Id==pId).ToList();
            }
          return list_Gender;
        }
        public string GetGenderCodeById(int id){
          string code= _db.Gender.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert Gender
        public string Create(Gender obj_Gender){
              _db.Gender.Add(obj_Gender);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit Gender
        public string UpdateGender(Gender obj_Gender){
              _db.Gender.Update(obj_Gender);
              _db.SaveChanges();
              return "Edited Successfully";

        }

          // Delete Gender
        public string DeleteGender(Gender obj_Gender){
              _db.Remove(obj_Gender); // _db.Gender.Remove(obj_Gender); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,int pId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "Gender";
            IList<Gender> GenderList = _db.Gender.Where(s=>s.Id==pId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = GenderList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = GenderList[i].Id;
                    worksheet.Cells[row, 2].Value = GenderList[i].Code;
                    worksheet.Cells[row, 3].Value = GenderList[i].Name;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<Gender>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get Gender by ByFiled
        public List<Gender> GetGenderByFiled(string searchTxt, int pId){
        var list_Gender = _db.Gender
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)) && 
                                      i.Id==pId                                      
                                  ).ToList();
        return list_Gender;
       }



    }
}