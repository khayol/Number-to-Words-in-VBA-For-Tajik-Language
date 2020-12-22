using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Woorj.Data;
using Microsoft.AspNetCore.Authorization;
using Woorj.Data.Adm;
using Woorj.Services;

namespace Woorj.CtrApi.Adm
{

   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserApController: ControllerBase
    {

       private readonly ApplicationDbContext _db;
       public ApplicationUserApController(ApplicationDbContext context)
       {
                  _db = context;        
       }


          // GET: api/ApplicationUserAp/GetUser
        [HttpGet("GetUser")]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetUser()
        {
            //await Task.Delay(3000);
            return await _db.ApplicationUser.ToListAsync();
        }



         [HttpGet("GetUserCount")]    // GET: api/ApplicationUserAp/GetUserCount
        public async Task<ActionResult<ItemCount>> GetUserCount()
        {
            ItemCount itemCount = new ItemCount();

            itemCount.Count = _db.ApplicationUser.Count();
            return await Task.FromResult(itemCount);
        }


         // GET: api/ApplicationUserAp/GetApplicationUsersByPage/2
        [HttpGet("GetApplicationUsersByPage")]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetApplicationUsersByPage(int pageSize, int pageNumber)
        {
            //pageNumber * pageSize -> take 5
            //ItemList = Items.Skip(pageNumber * PageSize).Take(PageSize).ToList();
            
            List<ApplicationUser> ApplicationUserList = await _db.ApplicationUser.ToListAsync();
            ApplicationUserList = ApplicationUserList.Skip(pageNumber * pageSize).Take(pageSize).ToList();

            return await Task.FromResult(ApplicationUserList);
        }
        
    }
}