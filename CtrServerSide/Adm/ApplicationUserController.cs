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
    public class ApplicationUserController
    {
        private readonly ApplicationDbContext _db;
  
        public List<ColumnDefinition> columns;

        public ApplicationUserController(ApplicationDbContext db)
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

              new ColumnDefinition { DataField = "Code" , MinWidth="70", MaxWidth="70"  },
              new ColumnDefinition { DataField = "UserName", MinWidth="300", MaxWidth="300" },
              new ColumnDefinition { DataField = "FullName", MinWidth="300", MaxWidth="300"},
              new ColumnDefinition { DataField = "CreatedDate", MinWidth="300", MaxWidth="300"},

                }
        );
        }
        }
        
        
        public List<ApplicationUser> GetApplicationUser(){
          var list_ApplicationUser=_db.ApplicationUser.ToList();
          return list_ApplicationUser;
        }

        
        public ApplicationUser GetApplicationUserById(string id){
          ApplicationUser ApplicationUser= _db.ApplicationUser.FirstOrDefault(s=> s.Id==id);
           

          return ApplicationUser;
        
        }
       
          public List<ApplicationUser> GetById(string pId){
        List<ApplicationUser> list;

        if (pId=="0" || string.IsNullOrEmpty(pId)){
          list=_db.ApplicationUser.ToList();
        }else
        {                
          list=_db.ApplicationUser.Where(s=>s.Id==pId).ToList();
        }
        return list;        
        }


            public ApplicationUser GetById_FirstOrDefault(string id){
        ApplicationUser ApplicationUser= _db.ApplicationUser.FirstOrDefault(s=> s.Id==id);
        return ApplicationUser;
        }

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

      
        public string Create(ApplicationUser pObj){
              _db.ApplicationUser.Add(pObj);
              _db.SaveChanges();
              return "Save Successfully";

        }

   
        public string UpdateApplicationUser(ApplicationUser pObj){
              _db.ApplicationUser.Update(pObj);
              _db.SaveChanges();
              return "Edited Successfully";

        }


             public string Update(ApplicationUser pObj){
              _db.ApplicationUser.Update(pObj);
              _db.SaveChanges();
              return "Edited Successfully";

        }

   
        public string Delete(ApplicationUser pObj){
              _db.Remove(pObj); // _db.ApplicationUser.Remove(pObj); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

        
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

          public List<ApplicationUser> GetSearchByField(string searchTxt){
        var list = _db.ApplicationUser.Where(i=>
                                       i.Code.ToString().Contains(searchTxt)
                                      || i.UserName.Contains(searchTxt) 
                                      || i.NormalizedUserName.Contains(searchTxt)
                                      || i.Email.Contains(searchTxt)
                                      || i.FirstName.Contains(searchTxt)
                                      || i.SecondName.Contains(searchTxt)
                                      || i.LastName.Contains(searchTxt)                              
                                  ).ToList();
        return list;
       }



    }
}