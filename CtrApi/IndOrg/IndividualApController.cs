using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Woorj.Data.IndOrg;
using Microsoft.AspNetCore.Authorization;
using Woorj.Data;

namespace Woorj.CtrApi.IndOrg
{

    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualApController: ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public IndividualApController(ApplicationDbContext context)
        {
            _db = context;
        }

        // GET: api/Individual https://localhost:5001/api/IndividualAp/GetIndividual
        [HttpGet("GetIndividual")]
        public async Task<ActionResult<IEnumerable<Individual>>> GetIndividual()
        {
            return await _db.Individual.ToListAsync();
        }

        // GET: api/Individual/5  https://localhost:5001/api/IndividualAp/GetIndividual/4
        [HttpGet("GetIndividual/{id}")]
       // [MapToApiVersion("1.0")]        
        public async Task<ActionResult<Individual>> GetIndividual(int id)
        {
            var Individual = await _db.Individual
                                            .Where(ind => ind.Id == id)
                                            .FirstOrDefaultAsync();

            if (Individual == null)
            {
                return NotFound();
            }

            return Individual;
        }

        // GET: api/Individual/5      https://localhost:5001/api/IndividualAp/GetIndividualDetailsEager/4
        [HttpGet("GetIndividualDetailsEager/{IndividualId}")]
        public async Task<ActionResult<Individual>> GetIndividualDetailsEager(string IndividualId)
        {
            //Eager Loading
             var Individual = await _db.Individual
                                            .Include(ind => ind.Contact)
                                           // .ThenInclude(Contact => Contact.Type) // For Example if  we need the Contact typle  
                                           .Where(ind => ind.Id ==int.Parse(IndividualId))
                                           .FirstOrDefaultAsync();
            if (Individual == null)
            {
                return NotFound();
            }

            return Individual;
        }

     // GET: api/Individual/5      https://localhost:5001/api/IndividualAp/GetIndividualDetailsExp/4
        [HttpGet("GetIndividualDetailsExp/{IndividualId}")]
        public async Task<ActionResult<Individual>> GetIndividualDetailsExp(string IndividualId)
        {
            //Explicit Loading
          
            var Individual = await _db.Individual.SingleAsync(ind => ind.Id == Convert.ToInt32(IndividualId));

            _db.Entry(Individual)
                    .Collection(ind => ind.Contact)
                    .Query()
                     //.Where(usr => usr.Name.Contains("93"))
                    .Load();
             
            if (Individual == null)
            {
                return NotFound();
            }

            return Individual;
        }

        // GET: api/Individual/5
        [HttpPost("PostIndividualDetails/")]
        public async Task<ActionResult<Individual>> PostIndividualDetails()
        {
            var Individual = new Individual();
            Individual.FirstName = "Harper";
            Individual.SecondName = "Brothers";
            Individual.LastName = "Jakovich";
           
            Contact contact1 = new Contact();
            contact1.Name= "11111";
            contact1.Description = "Home Phone";

            Contact contact2 = new Contact();
            contact2.Name= "22222";
            contact2.Description = "Mobile Phone";
        

            Individual.Contact.Add(contact1);
            Individual.Contact.Add(contact2);

            _db.Individual.Add(Individual);
            _db.SaveChanges();
           
                    var Individual_View = await _db.Individual
                                           .Include(ind => ind.Contact)
                                           .Where(ind => ind.Id ==Individual.Id)
                                           .FirstOrDefaultAsync();            

            if (Individual_View == null)
            {
                return NotFound();
            }

            return Individual_View;
        }
                

        // PUT: api/Individual/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdateIndividual/{id}")]
        public async Task<IActionResult> PutIndividual(int id, Individual Individual)
        {
            if (id != Individual.Id)
            {
                return BadRequest();
            }

            _db.Entry(Individual).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndividualExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Individual
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateIndividual")]
        public async Task<ActionResult<Individual>> PostIndividual(Individual Individual)
        {
            _db.Individual.Add(Individual);
            await _db.SaveChangesAsync();

            return await Task.FromResult(Individual); //CreatedAtAction("GetIndividual", new { id = Individual.PubId }, Individual);
        }

        // DELETE: api/Individual/5
        [HttpDelete("DeleteIndividual/{id}")]
        public async Task<ActionResult<Individual>> DeleteIndividual(int id)
        {
            var Individual = await _db.Individual.FindAsync(id);
            if (Individual == null)
            {
                return NotFound();
            }

            _db.Individual.Remove(Individual);
            await _db.SaveChangesAsync();

            return Individual;
        }

        private bool IndividualExists(int id)
        {
            return _db.Individual.Any(i => i.Id == id);
        }
    }
}