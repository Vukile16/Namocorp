using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPP.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Updated Date")]
        public DateTime? UpdatedDate { get; set; }

        [DisplayName("Contacting Type")]
        public string ContactingType { get; set; }

        public virtual ContactDetail ContactDetail { get; set; }

        public virtual ContactType ContactType { get; set; }
    }
}
