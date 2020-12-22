using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.GeneralComponents;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Woorj.Pages.IndOrg;
using Woorj.Services;
using Woorj.Data;
using Woorj.Data.IndOrg;

namespace Woorj.CtrServerSide.IndOrg
{
    public class IndividualController
    {
        private readonly ApplicationDbContext _db;

        public List<ColumnDefinition> columns;


        public IndividualController(ApplicationDbContext db)
        {
            _db=db;
        }

  
   private ICustomTranslator CustomTranslator { get; }    
    public string GetValue()
    {
       string translation = CustomTranslator.GetTranslation("FullNameEN","ru","Individual");
      return  translation;
    }

        public void HelloWorld()
        {
          Console.WriteLine("Hello World");
        }

        public void OnInitialized()
        {
        if (columns == null)
        {
            columns = new List<ColumnDefinition>();
            columns.AddRange(
                new ColumnDefinition[] {

                    new ColumnDefinition { DataField = "Id", Caption="Id" },
                    new ColumnDefinition { DataField = "Code", Caption="Code"},
          
                    new ColumnDefinition { DataField = "FullName", Caption="fullnAmE" , SortDirection = SortDirection.Asc },
                  
                    new ColumnDefinition { DataField = "FullNameEN", Caption="FullNameEN" },
                    
                    new ColumnDefinition { DataField = "BirthDay", Caption="BirthDay", Format = "dd.MM.yyyy", DataType = DataType.Date },

                    new ColumnDefinition { DataField = "TaxCode", Caption="TaxCode" },
                    new ColumnDefinition { DataField = "PassSerial", Caption="PassSerial" },
                    new ColumnDefinition { DataField = "PassCode", Caption="PassCode" },
                    new ColumnDefinition { DataField = "DocDate", Caption="DocDate", Format = "dd-MM-yyyy", DataType = DataType.Date },
                    new ColumnDefinition { DataField = "DocDateEnd", Caption="DocDateEnd", Format = "dd.MM.yyyy", DataType = DataType.Date },
                    new ColumnDefinition { DataField = "PassOrg", Caption="PassOrg" },
                    new ColumnDefinition { DataField = "Address", Caption="Address"},
              
            new ColumnDefinition { DataField = "Contact", Caption="Contact" ,DataType=DataType.Collection , LinkAddress="IndOrg/ContactViewStd/" },
            new ColumnDefinition { DataField = "Gender", Caption="Gender" , DataType=DataType.RelatedData, SelectedField="Name",SelectedFieldKey="GenderId"  , LinkAddress="Dir/GenderViewStd/" },
            new ColumnDefinition { DataField = "Country", Caption="BirthPlace" , DataType=DataType.RelatedData, SelectedField="Name",SelectedFieldKey="BirthPlace_CountryId"  , LinkAddress="Dir/CountryViewStd/" },
            
                    new ColumnDefinition { DataField = "CreatedDate", Caption="CreatedDate",Format = "dd.MM.yyyy hh:mm:ss", DataType = DataType.Date  },
           /* */
                        //new ColumnDefinition { DataField = "Salary", Caption="Annual Salary", DataType = DataType.Currency, Alignment = Alignment.Right, Format="c", SortDirection = SortDirection.Desc },


                    }
            );
            }
        }
           
        // Get all Individual
        public List<Individual> Get(){
          var list=_db.Individual.Include(s=>s.Gender).ToList();
          return list;
        }

        public List<Individual> GetById(int pId){
           List<Individual> list;

            if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
             list=_db.Individual.ToList();
            }else
            {                
             list=_db.Individual.Where(s=>s.Id==pId).ToList();
            }
          return list;        
        }

        // Get Individual by ID  GetById_FirstOrDefault
        public Individual GetById_FirstOrDefault(int id){
          Individual Individual= _db.Individual.Include(s=>s.Gender).FirstOrDefault(s=> s.Id==id);
          return Individual;
        
        }
        // Get Individual by ByFiled GetSearchByField
        public List<Individual> GetSearchByField(string searchTxt){
        var list = _db.Individual.Include(s=>s.Gender)
                                 .Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.FirstName.Contains(searchTxt) 
                                      || i.SecondName.Contains(searchTxt)
                                      || i.LastName.Contains(searchTxt)
                                      || i.FirstNameEN.Contains(searchTxt)
                                      || i.SecondNameEN.Contains(searchTxt)
                                      || i.LastNameEN.Contains(searchTxt)
                                      || i.Address.Contains(searchTxt)
                                      || i.Gender.Name.Contains(searchTxt)
                                    //|| i.BirthDay.ToString().Contains(searchTxt)
                                      //|| i.CreatedDate.ToString().Contains(searchTxt)
                                      //|| i.PassCode.ToString().Contains(searchTxt)
                                  ).ToList();
        return list;
       }

        // Insert Individual
        public string Create(Individual obj_Individual){
              _db.Individual.Add(obj_Individual);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit Individual
        public string Update(Individual obj_Individual){
              _db.Individual.Update(obj_Individual);
              _db.SaveChanges();
              return "Edited Successfully";

        }

        public void UpdateSome_FK_Key(int pChoosedEntityId,string pChoosedEntityFK, int pIdSelected){
           if (pChoosedEntityFK.ToUpper()=="BirthPlace_CountryId".ToUpper()){
           var Individual = _db.Individual.First(a => a.Id == pChoosedEntityId);
          Individual.BirthPlace_CountryId = pIdSelected;
         }
            _db.SaveChanges();
        }

          // Delete Individual
        public string Delete(Individual obj_Individual){
              _db.Remove(obj_Individual); // _db.Individual.Remove(obj_Individual); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "Individual";
            IList<Individual> individualList = _db.Individual.ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = individualList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "First Name";
                worksheet.Cells[1, 4].Value = "Second Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = individualList[i].Id;
                    worksheet.Cells[row, 2].Value = individualList[i].Code;
                    worksheet.Cells[row, 3].Value = individualList[i].FirstName;
                    worksheet.Cells[row, 4].Value = individualList[i].SecondName;
                    i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<Individual>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }


 



    }
}