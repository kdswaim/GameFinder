using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.GameSystem
{
    // Idies are automatically created
    public class GameSystemCreate
    {
        [Required]
        [MaxLength(200)]  
        public string Name { get; set; }   

        [Required]
        [MaxLength(200)]  
        public string Description { get; set; }
    }
}