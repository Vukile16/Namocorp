using NamoWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPI.ViewModels
{
    public class ContactVM
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual ContactDetail ContactDetail { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
