using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Models
{
    public class RatingEdit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double score { get; set; }
        [Required]
        public int GameId { get; set; }
    }
}