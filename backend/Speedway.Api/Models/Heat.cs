using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.Models
{
    public class Heat
    {
        public int Id { get; set; } = 0;

        // players
        public string Player1Id { get; set; } = string.Empty;
        public string Player2Id { get; set; } = string.Empty;
        public string Player3Id { get; set; } = string.Empty;
        public string Player4Id { get; set; } = string.Empty;
        public Player PlayerPos1 { get; set; } = null!; 
        public Player PlayerPos2 { get; set; } = null!; 
        public Player PlayerPos3 { get; set; } = null!; 
        public Player PlayerPos4 { get; set; } = null!; 

        // match refernce
        public int MatchId { get; set; } = 0; // FK
        public Match Match { get; set; } = null!; // Navigation property
    }
}