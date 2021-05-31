using Contacts.Data;
using Contacts.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services
{
    public class ContactService : App
    {


        public ContactService()
        {

        }

        public async Task<int> SaveContactAsync(Contact contact)
        {
            var id = await App.Database.SaveContactAsync(contact);
            return id;
        }

        public async Task<int> DeleteContactAsync(Contact contact)
        {
            var id = await App.Database.DeleteContactAsync(contact);
            return id;
        }


        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await App.Database.GetContactsAsync();
        }

    }
}
