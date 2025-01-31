using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAddressBook.Domain.Entities
{
    public class BookRecord
    {
        public int? id { get; set; }

        [Required]
        public string fullName { get; set; }

        [Required]
        [Phone]
        public string phoneNumber { get; set; }
    }
}
