using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speedway.Api.Models
{
    public class Player
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
    //    public decimal Average { get; set; } = 0;
        public int? TeamId { get; set; } = 0; // FK
        public Team? Team { get; set; } // Navigation property
    }

}
