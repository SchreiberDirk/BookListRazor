using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]       // legt den Id- Wert automatisch fest
        public int Id { get; set; }
        [Required]  // macht Name zum pflichtfeld (not Null)
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
