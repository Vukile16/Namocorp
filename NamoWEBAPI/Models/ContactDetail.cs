using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPI.Models
{
    public class ContactDetail
    {
        [Key]
        public int ContactDetailId { get; set; }

        public int? ContactId { get; set; }

        public string Description { get; set; }

        public int? ContactTypeId { get; set; }

        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }

        [ForeignKey("ContactTypeId")]
        public ContactType ContactType { get; set; }
    }
}
