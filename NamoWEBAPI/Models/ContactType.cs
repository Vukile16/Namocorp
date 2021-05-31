
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPI.Models
{
    public class ContactType
    {

        [Key]
        public int ContactTypeId { get; set; }

        public string Type { get; set; }
    }
}
