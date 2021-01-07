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
    public class GenderController
    {
          public List<ColumnDefinition> columns;
        private readonly ApplicationDbContext _db;

        public GenderController(ApplicationDbContext db)
        {
            _db=db;
        }

        public void Initialized()
        {
            if (columns == null)
            {
                columns = new List<ColumnDefinition>();
                columns.AddRange(
                    new ColumnDefinition[] 
                      {
                      new ColumnDefinition { DataField = "Code"},
                      new ColumnDefinition { DataField = "Name"}
                      }
                                );
            }
        }
        
        public List<Gender> Get(){
          var list_Gender=_db.Gender.ToList();
          return list_Gender;
        }

        public List<Gender> GetById(int pId){
        List<Gender> list;

        if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
          list=_db.Gender.ToList();
        }else
        {                
          list=_db.Gender.Where(s=>s.Id==pId).ToList();
        }
        return list;        
        }
  
        public Gender GetById_FirstOrDefault(int id){
        Gender Gender= _db.Gender.FirstOrDefault(s=> s.Id==id);
        return Gender;
        }

     
       public List<Gender> GetSearchByField(string searchTxt){
        var list = _db.Gender.Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)                                                                    
                                  ).ToList();
        return list;
       }

         public string Create(Gender pObj){
              _db.Gender.Add(pObj);
              _db.SaveChanges();
              return "Save Successfully";

        }


        public string Update(Gender pObj){
              _db.Gender.Update(pObj);
              _db.SaveChanges();
              return "Edited Successfully";

        }

    
            public string Delete(Gender pObj){
              _db.Remove(pObj); 
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