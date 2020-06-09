using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class teacher
    {
        public int id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string teachername { get; set; }

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string course { get; set; }

    }
}