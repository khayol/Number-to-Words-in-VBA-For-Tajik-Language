using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Adm;
using Woorj.Data.WrComponents;

namespace Woorj.CtrServerSide.Adm
{
  
    public class ApplicationRoleController
    {
      private readonly ApplicationDbContext _db;

      public List<ColumnDefinition> clmDef_RoleStd;
      public List<ColumnDefinition> clmDef_Role;
      public List<ColumnDefinition> clmDef_VGetUserRole;
    
      public ApplicationRoleController(ApplicationDbContext db)
      {
          _db=db;
      }

       public void Init_RoleViewStd(){
         if (clmDef_RoleStd == null)
        {
            clmDef_RoleStd = new List<ColumnDefinition>();
            clmDef_RoleStd.AddRange(
                new ColumnDefinition[] {
                    new ColumnDefinition { DataField = "Code", MinWidth="70", MaxWidth="70"  },
                    new ColumnDefinition { DataField = "Name", MinWidth="300", MaxWidth="300" },
                    new ColumnDefinition { DataField = "NormalizedName", MinWidth="300", MaxWidth="300" },
                    new ColumnDefinition { DataField = "Description", MinWidth="300", MaxWidth="300"  },
                    new ColumnDefinition { DataField = "CreatedDate", MinWidth="180", MaxWidth="180"  },                       
                    }
            );
        }

       }
       public void Init_UserRoleEdit(){

            if (clmDef_Role == null)
        {
            clmDef_Role = new List<ColumnDefinition>();
            clmDef_Role.AddRange(
                new ColumnDefinition[] {
                    new ColumnDefinition { DataField = "Code", Caption="Code", MinWidth="70", MaxWidth="70"   },
                    new ColumnDefinition { DataField = "Name", Caption="Name", MinWidth="400", MaxWidth="400"  },
                    new ColumnDefinition { DataField = "NormalizedName", Caption="NameOfRoles", MinWidth="400", MaxWidth="400"  },                       
                    }
            );
        }

        if (clmDef_VGetUserRole == null)
        {
            clmDef_VGetUserRole = new List<ColumnDefinition>();
            clmDef_VGetUserRole.AddRange(
                new ColumnDefinition[] {
                    new ColumnDefinition { DataField = "RoleCode", Caption="Code", MinWidth="70", MaxWidth="70"   },
                    new ColumnDefinition { DataField = "RoleName", Caption="RoleName" , MinWidth="400", MaxWidth="400" },
                    new ColumnDefinition { DataField = "NormalizedName", Caption="NameOfRoles", MinWidth="400", MaxWidth="400"  },
                    new ColumnDefinition { DataField = "Description", Caption="Description", MinWidth="400", MaxWidth="400"  },                       
                    }
            );
        }
      }
        public List<ApplicationRole> GetApplicationRole(){
          var list_ApplicationRole=_db.ApplicationRole.ToList();
          return list_ApplicationRole;
        }


       // ****Should Delete this
        public ApplicationRole GetApplicationRoleById(string id){
          ApplicationRole ApplicationRole= _db.ApplicationRole.FirstOrDefault(s=> s.Id==id);
          return ApplicationRole;
        
        }

        public ApplicationRole GetById_FirstOrDefault(string id){
        ApplicationRole ApplicationRole= _db.ApplicationRole.FirstOrDefault(s=> s.Id==id);
        return ApplicationRole;
        }
            

        public List<ApplicationRole> GetById(string pId){

        List<ApplicationRole> list;

        if (pId=="0" || string.IsNullOrEmpty(pId)){
          list=_db.ApplicationRole.ToList();
        }else
        {                
          list=_db.ApplicationRole.Where(s=>s.Id==pId).ToList();
        }
        return list;        
        }

         public List<ApplicationRole> GetApplicationRoleById2(string pId){
             List<ApplicationRole> list_ApplicationRole;

            if ( pId=="0" || string.IsNullOrEmpty(pId.ToString())){     
             list_ApplicationRole=_db.ApplicationRole.ToList();
            }else
            {                
             list_ApplicationRole=_db.ApplicationRole.Where(s=>s.Id==pId) .ToList();
            }

          return list_ApplicationRole;
        }
        
        public string GetApplicationRoleCodeById(string id){
          string code= _db.ApplicationRole.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert ApplicationRole
        public string Create(ApplicationRole pObj){
              _db.ApplicationRole.Add(pObj);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit ApplicationRole
        public string Update(ApplicationRole pObj){
              _db.ApplicationRole.Update(pObj);
              _db.SaveChanges();
              return "Edited Successfully";

        }

        public string Delete(ApplicationRole pObj){
              _db.Remove(pObj); // _db.ApplicationRole.Remove(pObj); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,string pId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "ApplicationRole";
            IList<ApplicationRole> ApplicationRoleList = _db.ApplicationRole.Where(s=>s.Id==pId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = ApplicationRoleList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = ApplicationRoleList[i].Id;
                    worksheet.Cells[row, 2].Value = ApplicationRoleList[i].Code;
                    worksheet.Cells[row, 3].Value = ApplicationRoleList[i].Name;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<ApplicationRole>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get ApplicationRole by ByFiled
        public List<ApplicationRole> GetApplicationRoleByFiled(string searchTxt, string pId){
        var list_ApplicationRole = _db.ApplicationRole
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)) && 
                                      i.Id==pId                                      
                                  ).ToList();
        return list_ApplicationRole;
       }
        // *** For Deleting  
        public List<ApplicationRole> GetApplicationRoleByFiled(string searchTxt){
        var list_ApplicationRole = _db.ApplicationRole
                              .Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt) 
                                      || i.NormalizedName.Contains(searchTxt)
                                      || i.Description.Contains(searchTxt)
                                      || i.CreatedDate.ToString().Contains(searchTxt)
                                                  ).ToList();
        return list_ApplicationRole;
       }


    public List<ApplicationRole> GetSearchByField(string searchTxt){
        var list = _db.ApplicationRole.Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt) 
                                      || i.NormalizedName.Contains(searchTxt)
                                      || i.Description.Contains(searchTxt)
                                     ).ToList();
        return list;
       }
     

        public List<VGetUserRole> GetVGetUserRoleByFiled(string searchTxt, string pUid){
        var list_VGetUserRole = _db.VGetUserRole
                              .Where(i=>
                                       i.UserId==pUid
                                      && ( i.RoleCode.ToString().Contains(searchTxt) 
                                      || i.RoleName.Contains(searchTxt)
                                      || i.NormalizedName.Contains(searchTxt)
                                      || i.Description.Contains(searchTxt)
                                      )                        
                                       ).ToList();
        return list_VGetUserRole;
       }

       //---------------------------------------------------

   
     



    }
}