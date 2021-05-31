using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPI.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string ContactingType { get; set; }
    }
}
