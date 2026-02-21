using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.Models
{
    public class Match
    {
        public int Id { get; set; } = 0;
        public int HomeTeamId { get; set; } = 0; // FK
        public Team? HomeTeam { get; set; } // Navigation property
        public int AwayTeamId { get; set; } = 0; // FK
        public Team? AwayTeam { get; set; } // Navigation property
        public DateTime MatchDate { get; set; } = DateTime.Now;
    }
}