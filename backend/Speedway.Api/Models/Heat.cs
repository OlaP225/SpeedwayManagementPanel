using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.Models
{
    public class Heat
    {
        public int Id { get; set; }

        // players
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int Player3Id { get; set; }
        public int Player4Id { get; set; }
        public Player PlayerPos1 { get; set; } = null!; 
        public Player PlayerPos2 { get; set; } = null!; 
        public Player PlayerPos3 { get; set; } = null!; 
        public Player PlayerPos4 { get; set; } = null!; 

        // match refernce
        public int MatchId { get; set; } = 0; // FK
        public Match Match { get; set; } = null!; // Navigation property
    }
}
//