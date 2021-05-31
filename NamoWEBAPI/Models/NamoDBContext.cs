using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPI.Models
{
    public class NamoDBContext : DbContext
    {
        public NamoDBContext(DbContextOptions<NamoDBContext> options):base (options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
    }
}
