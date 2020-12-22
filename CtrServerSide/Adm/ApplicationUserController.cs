using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.Adm;

namespace Woorj.CtrServerSide.Adm
{
    public class ApplicationUserController
    {
        private readonly ApplicationDbContext _db;
  
        public ApplicationUserController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // Get all ApplicationUser
        public List<ApplicationUser> GetApplicationUser(){
          var list_ApplicationUser=_db.ApplicationUser.ToList();
          return list_ApplicationUser;
        }

        // Get ApplicationUser by ID
        public ApplicationUser GetApplicationUserById(string id){
          ApplicationUser ApplicationUser= _db.ApplicationUser.FirstOrDefault(s=> s.Id==id);
           

          return ApplicationUser;
        
        }
       // Get ApplicationUser by ID
         public List<ApplicationUser> GetApplicationUserById2(string pId){
             List<ApplicationUser> list_ApplicationUser;

            if ( pId=="0" || string.IsNullOrEmpty(pId.ToString())){     
             list_ApplicationUser=_db.ApplicationUser.ToList();
            }else
            {                
             list_ApplicationUser=_db.ApplicationUser.Where(s=>s.Id==pId) .ToList();
            }

          return list_ApplicationUser;
        } 
         // Get VGetUserRole by ID
         public List<VGetUserRole> GetUserRoleById(string pUserId){
             List<VGetUserRole> list_VGetUserRole;
                         
             list_VGetUserRole=_db.VGetUserRole.Where(s=>s.UserId==pUserId) .ToList();
          
          // Console.WriteLine("------------------------");

          // foreach (var array in list_VGetUserRole) {
          //  Console.WriteLine(array.UserName + "-- "+ array.RoleName);
          // }
      

          return list_VGetUserRole;
        }
        public string GetApplicationUserCodeById(string id){
          string code= _db.ApplicationUser.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert ApplicationUser
        public string Create(ApplicationUser obj_ApplicationUser){
              _db.ApplicationUser.Add(obj_ApplicationUser);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit ApplicationUser
        public string UpdateApplicationUser(ApplicationUser obj_ApplicationUser){
              _db.ApplicationUser.Update(obj_ApplicationUser);
              _db.SaveChanges();
              return "Edited Successfully";

        }

          // Delete ApplicationUser
        public string DeleteApplicationUser(ApplicationUser obj_ApplicationUser){
              _db.Remove(obj_ApplicationUser); // _db.ApplicationUser.Remove(obj_ApplicationUser); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,string pId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "ApplicationUser";
            IList<ApplicationUser> ApplicationUserList = _db.ApplicationUser.Where(s=>s.Id==pId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = ApplicationUserList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = ApplicationUserList[i].Id;
                    worksheet.Cells[row, 2].Value = ApplicationUserList[i].Code;
                    worksheet.Cells[row, 3].Value = ApplicationUserList[i].UserName;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<ApplicationUser>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get ApplicationUser by ByFiled
        public List<ApplicationUser> GetApplicationUserByFiled(string searchTxt, string pId){
        var list_ApplicationUser = _db.ApplicationUser
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.UserName.Contains(searchTxt)) && 
                                      i.Id==pId                                      
                                  ).ToList();
        return list_ApplicationUser;
       }



    }
}