using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.GameSystem
{
    public class GameSystemCreate
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [MaxLength(200)]  
        public string Name { get; set; }   

        [Required]
        [MaxLength(200)]  
        public string Description { get; set; }
    }
}