using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Models
{
    public class RatingCreate
    {
        [Required]
        public double Score { get; set; }

        [Required]
        public int GameId { get; set; }
    }
}