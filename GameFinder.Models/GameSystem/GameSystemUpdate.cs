using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.GameSystem
{
    public class GameSystemUpdate
    {
        [Required]  
        public int Id { get; set; } 

        [Required]  
        public string Name { get; set; }   

        [Required]
        public string Description { get; set; }
    }
}