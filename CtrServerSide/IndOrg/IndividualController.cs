using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.WrComponents;
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

        public void Initialized()
        {
        if (columns == null)
        {
            columns = new List<ColumnDefinition>();
            columns.AddRange(
                new ColumnDefinition[] {

                    new ColumnDefinition { DataField = "Id", SortDirection = SortDirection.Asc},          
                    new ColumnDefinition { DataField = "Code", Caption="Code", MinWidth="70", MaxWidth="70"  },
                    new ColumnDefinition { DataField = "FullName",  MinWidth="300", MaxWidth="300" },
                    new ColumnDefinition { DataField = "FullNameEN", MinWidth="300", MaxWidth="300"},
                    new ColumnDefinition { DataField = "BirthDay", Format = "dd.MM.yyyy", DataType = DataType.Date, MinWidth="180", MaxWidth="180" },
                    new ColumnDefinition { DataField = "TaxCode",  MinWidth="120", MaxWidth="120"  },
                    new ColumnDefinition { DataField = "PassSerial",  MinWidth="20", MaxWidth="20"   },
                    new ColumnDefinition { DataField = "PassCode",  MinWidth="80", MaxWidth="80"   },
                    new ColumnDefinition { DataField = "DocDate",  Format = "dd-MM-yyyy", DataType = DataType.Date, MinWidth="180", MaxWidth="180"   },
                    new ColumnDefinition { DataField = "DocDateEnd", Format = "dd.MM.yyyy", DataType = DataType.Date, MinWidth="180", MaxWidth="180"   },
                    new ColumnDefinition { DataField = "PassOrg",  MinWidth="300", MaxWidth="300"  },
                    new ColumnDefinition { DataField = "Address",  MinWidth="300", MaxWidth="300"  },
                    new ColumnDefinition { DataField = "CreatedDate", Format = "dd.MM.yyyy hh:mm:ss", DataType = DataType.Date , MinWidth="180", MaxWidth="180"   },
    
                    new ColumnDefinition { DataField = "Contact", DataType=DataType.Collection , LinkAddress="IndOrg/ContactViewStd/" , MinWidth="40", MaxWidth="40"  },
                    new ColumnDefinition { DataField = "Gender",  DataType=DataType.RelatedData, SelectedField="Name",SelectedFieldKey="GenderId"  , LinkAddress="Dir/GenderViewStd/", MinWidth="90", MaxWidth="90"   },
                    new ColumnDefinition { DataField = "Country", Caption= "BirthPlace", DataType=DataType.RelatedData, SelectedField="Name",SelectedFieldKey="BirthPlace_CountryId"  , LinkAddress="Dir/CountryViewStd/" , MinWidth="100", MaxWidth="100"   },
                    
                     //new ColumnDefinition { DataField = "Salary", Caption="Annual Salary", DataType = DataType.Currency, Alignment = Alignment.Right, Format="c", SortDirection = SortDirection.Desc },

                    }
            );
            }
        }
           
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

        public Individual GetById_FirstOrDefault(int id){
          Individual Individual= _db.Individual.Include(s=>s.Gender).FirstOrDefault(s=> s.Id==id);
          return Individual;        
        }
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
        public string Create(Individual pObj){
              _db.Individual.Add(pObj);
              _db.SaveChanges();
              return "Save Successfully";

        }
        public string Update(Individual pObj){
              _db.Individual.Update(pObj);
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

       public string Delete(Individual pObj){
              _db.Remove(pObj); // _db.Individual.Remove(pObj); 
              _db.SaveChanges();
              return "Delete Successfully";

        }


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