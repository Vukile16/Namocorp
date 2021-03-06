using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NamoWEBAPI.Models;

namespace NamoWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        private readonly NamoDBContext _context;

        public ContactDetailsController(NamoDBContext context)
        {
            _context = context;
        }

        // GET: api/ContactDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDetail>>> GetContactDetails()
        {
            return await _context.ContactDetails.Include(x => x.Contact).Include(y => y.ContactType).ToListAsync();
        }

        // GET: api/ContactDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDetail>> GetContactDetail(int id)
        {
            var contactDetail = await _context.ContactDetails.Include(x => x.Contact).Include(y => y.ContactType).FirstOrDefaultAsync(b => b.ContactDetailId == id);

            if (contactDetail == null)
            {
                return NotFound();
            }

            return contactDetail;
        }

        // PUT: api/ContactDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactDetail(int id, ContactDetail contactDetail)
        {
            if (id != contactDetail.ContactDetailId)
            {
                return BadRequest();
            }

            _context.Entry(contactDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactDetailExists(id))
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

        // POST: api/ContactDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactDetail>> PostContactDetail(ContactDetail contactDetail)
        {
            _context.ContactDetails.Add(contactDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactDetail", new { id = contactDetail.ContactDetailId }, contactDetail);
        }

        // DELETE: api/ContactDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactDetail(int id)
        {
            var contactDetail = await _context.ContactDetails.Where(x => x.ContactId == id).FirstOrDefaultAsync();
            if (contactDetail == null)
            {
                return NotFound();
            }

            _context.ContactDetails.Remove(contactDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactDetailExists(int id)
        {
            return _context.ContactDetails.Any(e => e.ContactDetailId == id);
        }
    }
}
