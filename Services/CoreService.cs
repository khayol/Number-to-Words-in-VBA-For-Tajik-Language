using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.GeneralComponents;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Woorj.Pages.IndOrg;
using Woorj.Data;
using Woorj.Data.Adm;

namespace Woorj.Services
{
    
     public interface ICoreService
    {
        string GetGlobVar(string pKeyWork);

    }
    public class CoreService : ICoreService
    {
      protected readonly ApplicationDbContext _db;

      public CoreService(ApplicationDbContext db)
        {
            _db=db;
        }
 
        public  string GetGlobVar( string pKeyWork)
        {
           string res="nullval";
           res= _db.GlobalVariable.FirstOrDefault(gv=>gv.KeyWord.ToUpper().Trim()==pKeyWork.ToUpper().Trim()).DefaultVal?.ToString() ?? "nullval";
           return res;
        }


    
}
 
}