using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Speedway.Api.Data;

namespace Speedway.Api.Controllers
{
    [Route("api/team")]
    [ApiController]
    public class TeamController: ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public TeamController(ApplicationDBContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var teams = _context.Team.ToList();
            return Ok(teams);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var team = _context.Team.Find(id);
            if (team == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(team);
            }
        }



    }
}