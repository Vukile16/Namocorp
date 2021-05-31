using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NamoWEBAPI.Models;
using NamoWEBAPI.ViewModels;

namespace NamoWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly NamoDBContext _context;

        public ContactsController(NamoDBContext context)
        {
            _context = context;
        }


        // GET: api/Contacts/Get35Contacts
        [Route("Get35Contacts")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> Get35Contacts()
        {
            List<Contact> contacts = await _context.Contacts.ToListAsync();
            List<Contact> contactsOver35 = new();

            foreach (var item in contacts)
            {
                var today = DateTime.Today;

                var age = today.Year - item.BirthDate.Value.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (item.BirthDate.Value.Date > today.AddYears(-age))
                {
                    age--;
                }

                if (age > 35)
                {
                    contactsOver35.Add(item);
                }
            }

            return contactsOver35;
        }

        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        //// GET: api/Contacts/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Contact>> GetContact(int id)
        //{
        //    var contact = await _context.Contacts.FindAsync(id);

        //    if (contact == null)
        //    {
        //        return NotFound();
        //    }

        //    return contact;
        //}



        //// GET: api/Contacts/5
        [HttpGet("{id}")]
        public IQueryable<ContactVM> GetContact(int id)
        {

            var contact = from cc in _context.Contacts
                          join cd in _context.ContactDetails on cc.ContactId equals cd.ContactId
                          join ct in _context.ContactTypes on cd.ContactTypeId equals ct.ContactTypeId
                          where cc.ContactId == id
                          select new ContactVM
                          {
                              ContactId = cc.ContactId,
                              FirstName = cc.FirstName,
                              Surname = cc.Surname,
                              BirthDate = cc.BirthDate,
                              UpdatedDate = cc.UpdatedDate,
                              ContactDetail = cd,
                              ContactType = ct
                          };

            if (contact == null)
            {
                return null;
            }

            return contact;
        }

        // PUT: api/Contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (id != contact.ContactId)
            {
                return BadRequest();
            }
            contact.UpdatedDate = DateTime.Now;
            _context.Entry(contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
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

        // POST: api/Contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContact", new { id = contact.ContactId }, contact);
        }

        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            try
            {
                var contact = await _context.Contacts.FindAsync(id);
                var contactDetail = await _context.ContactDetails.Where(x => x.ContactId == id).FirstOrDefaultAsync();
                if (contact == null)
                {
                    return NotFound();
                }
                _context.ContactDetails.Remove(contactDetail);
                await _context.SaveChangesAsync();

                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.ContactId == id);
        }
    }
}
