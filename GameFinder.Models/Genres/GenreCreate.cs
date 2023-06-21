using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameFinder.Models.Genres
{
    public class GenreCreate
    {
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        public string Description {get; set;}       
    }
}