using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.WrComponents;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Woorj.Pages.IndOrg;
using Woorj.Data;
using Woorj.Data.Adm;
using System.Threading.Tasks;

namespace Woorj.Services
{

    public interface IAdmService
    {
        string GetRolesList(string pObject);
        Task<string> GetRolesListAsync(string pObject);
    }
    public class AdmService : IAdmService
    {
      protected readonly ApplicationDbContext _db;

      public AdmService(ApplicationDbContext db)
        {
            _db=db;
        }
        public  async Task<string> GetRolesListAsync(string pObject)
        {
            var res="";
     
            var roles= await (from r in   _db.ApplicationRole
                  join rar in _db.RoleAccessRight
                  on r.Id equals rar.ApplicationRoleId
                  join ar in _db.AccessRight
                  on rar.AccessRightId equals ar.Id
                  where  (ar.Name.ToUpper().Trim()==pObject.ToUpper().Trim())  // || (r.Name != "XXXX") 
                    
                  select new { 
                               Id = r.Id, 
                               Name = r.Name, 
                               Description =r.Description,
                               ObjName=ar.Name
                              }
                  ).ToListAsync();

                  
            if (roles==null)
            {
                res="LOGIN";
            }else if (roles.Count()==1)
            {
              foreach (var item in roles)
              {
                res=res+""+ item.Name.ToString();
              }
            
            }else if (roles.Count()>1)
            {
                foreach (var item in roles)
              {
                res=res+","+ item.Name.ToString();
              }
               res=res.Remove(0, 1);
            }

             res=res.Trim();
            return res;

        }

    
        public  string GetRolesList(string pObject)
        {
            var res="";
     
            var roles=  (from r in   _db.ApplicationRole
                  join rar in _db.RoleAccessRight
                  on r.Id equals rar.ApplicationRoleId
                  join ar in _db.AccessRight
                  on rar.AccessRightId equals ar.Id
                  where  (ar.Name.ToUpper().Trim()==pObject.ToUpper().Trim())  // || (r.Name != "XXXX") 
                    
                  select new { 
                               Id = r.Id, 
                               Name = r.Name, 
                               Description =r.Description,
                               ObjName=ar.Name
                              }
                  ).ToList();

                  
            if (roles==null || roles.Count()==0  )
            {
                res="LOGIN";
            }else if (roles.Count()==1)
            {
              foreach (var item in roles)
              {
                res=res+""+ item.Name.ToString();
              }
            
            }else if (roles.Count()>1)
            {
                foreach (var item in roles)
              {
                res=res+","+ item.Name.ToString();
              }
               res=res.Remove(0, 1);
            }

             res=res.Trim();
                //Console.WriteLine("----------------");
               // Console.WriteLine("activeRoles= "+res);
         
            return res;

        }

    
}
 
}