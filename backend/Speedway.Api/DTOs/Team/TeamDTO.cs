using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.DTOs.Team
{
    public class TeamDTO
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty; 
        //public List<Player> Players { get; set; } = new List<Player>(); // PK
    }
}