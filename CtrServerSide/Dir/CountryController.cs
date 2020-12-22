using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Dir;

namespace Woorj.CtrServerSide.Dir
{
    public class CountryController
    {
        private readonly ApplicationDbContext _db;

        public CountryController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // Get all Country
        public List<Country> GetCountry(){
          var list_Country=_db.Country.ToList();
          return list_Country;
        }

        // Get Country by ID
        public Country GetCountryById(int id){
          Country Country= _db.Country.FirstOrDefault(s=> s.Id==id);
          return Country;
        
        }
       // Get Country by ID
         public List<Country> GetCountryById2(int pId){
            List<Country> list_Country;

            if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
             list_Country=_db.Country.ToList();
            }else
            {                
             list_Country=_db.Country.Where(s=>s.Id==pId) .ToList();
            }
          return list_Country;
        }
        public string GetCountryCodeById(int id){
          string code= _db.Country.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert Country
        public string Create(Country obj_Country){
              _db.Country.Add(obj_Country);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit Country
        public string UpdateCountry(Country obj_Country){
              _db.Country.Update(obj_Country);
              _db.SaveChanges();
              return "Edited Successfully";

        }

          // Delete Country
        public string DeleteCountry(Country obj_Country){
              _db.Remove(obj_Country); // _db.Country.Remove(obj_Country); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,int pId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "Country";
            IList<Country> CountryList = _db.Country.Where(s=>s.Id==pId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = CountryList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = CountryList[i].Id;
                    worksheet.Cells[row, 2].Value = CountryList[i].Code;
                    worksheet.Cells[row, 3].Value = CountryList[i].Name;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<Country>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get Country by ByFiled
        public List<Country> GetCountryByFiled(string searchTxt, int pId){
        var list_Country = _db.Country
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)) && 
                                      i.Id==pId                                      
                                  ).ToList();
        return list_Country;
       }  
   


    }
}