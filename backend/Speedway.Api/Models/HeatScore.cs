using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.Models
{
    public class HeatScore
    {
        public int Id { get; set; } = 0;
        public int HeatId { get; set; } = 0; 
        public Heat Heat { get; set; } = null!;
        public int PlayerId { get; set; } = 0;
        public Player Player { get; set; } = null!;
        public int Points { get; set; } = 0;
    }
}