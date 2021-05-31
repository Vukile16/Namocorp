using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Contacts.Models;

namespace Contacts.Data
{
    public class ContactDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ContactDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contact>().Wait();
        }

        public Task<List<Contact>> GetContactsAsync()
        {
            return _database.Table<Contact>().ToListAsync();
        }

        public Task<Contact> GetContactAsync(int id)
        {
            return _database.Table<Contact>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveContactAsync(Contact Contact)
        {
            if (Contact.ID != 0)
            {
                return _database.UpdateAsync(Contact);
            }
            else
            {
                return _database.InsertAsync(Contact);
            }
        }

        public Task<int> DeleteContactAsync(Contact Contact)
        {
            return _database.DeleteAsync(Contact);
        }
       
    }
}
