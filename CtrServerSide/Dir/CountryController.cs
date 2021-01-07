using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Dir;
using Woorj.Data.WrComponents;

namespace Woorj.CtrServerSide.Dir
{
    
    public class CountryController
    {
       public List<ColumnDefinition> columns;
        private readonly ApplicationDbContext _db;

        public CountryController(ApplicationDbContext db)
        {
            _db=db;
        }



     public void Initialized()
        {
        if (columns == null)
        {
            columns = new List<ColumnDefinition>();
            columns.AddRange(
                new ColumnDefinition[] {

                    new ColumnDefinition { DataField = "Code"},
                    new ColumnDefinition { DataField = "Name"},
                    new ColumnDefinition { DataField = "FullName" },
                    new ColumnDefinition { DataField = "English"},
                    new ColumnDefinition { DataField = "Alpha2"},
                    new ColumnDefinition { DataField = "Alpha3"},
                    new ColumnDefinition { DataField = "CreatedDate"}

                    }
            );
            }
        }
        
        public List<Country> Get(){
          var list_Country=_db.Country.ToList();
          return list_Country;
        }

        public List<Country> GetById(int pId){
        List<Country> list;

        if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
          list=_db.Country.ToList();
        }else
        {                
          list=_db.Country.Where(s=>s.Id==pId).ToList();
        }
        return list;        
        }

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

       
        public Country GetById_FirstOrDefault(int id){
        Country Country= _db.Country.FirstOrDefault(s=> s.Id==id);
        return Country;
        }

     
       public List<Country> GetSearchByField(string searchTxt){
        var list = _db.Country.Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt) 
                                      || i.FullName.Contains(searchTxt)
                                      || i.Alpha2.Contains(searchTxt)
                                      || i.Alpha3.Contains(searchTxt)
                                      || i.English.Contains(searchTxt)
                                      || i.Iso.Contains(searchTxt)                              
                                  ).ToList();
        return list;
       }


            public string Create(Country pObj){
              _db.Country.Add(pObj);
              _db.SaveChanges();
              return "Save Successfully";

        }

           public string Update(Country pObj){
              _db.Country.Update(pObj);
              _db.SaveChanges();
              return "Edited Successfully";

        }

    
            public string Delete(Country pObj){
              _db.Remove(pObj); 
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

   
   


    }
}