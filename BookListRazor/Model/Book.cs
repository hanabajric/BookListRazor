using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key] // kreirat id automatski 
        public int Id { get; set; }

        [Required] // ne moze bez imena
        public string Name { get; set; }

        public string Author { get; set; }
    }
}
