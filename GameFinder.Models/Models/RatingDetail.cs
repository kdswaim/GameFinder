using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Models
{
    public class RatingDetail
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public double Score { get; set; }
    }
}