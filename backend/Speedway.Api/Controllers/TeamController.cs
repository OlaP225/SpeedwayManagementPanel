using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Speedway.Api.Data;
using Speedway.Api.DTOs.Team;
using Speedway.Api.Mappers;
using Speedway.Api.Models;

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
            var teams = _context.Team.ToList()
            .Select(t => t.ToTeamDTO());
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
                return Ok(team.ToTeamDTO());
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateTeamRequestDTO createTeamDTO)
        {
            var teamModel = createTeamDTO.ToTeamFromCreateDTO();
            _context.Team.Add(teamModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = teamModel.Id }, teamModel.ToTeamDTO());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTeamRequestDTO updateTeamDTO)
        {
            var teamModel = _context.Team.Find(id);
            if (teamModel == null)
            {
                return NotFound();
            }
            
            teamModel.Name = updateTeamDTO.Name;
            _context.SaveChanges();
            return Ok(teamModel.ToTeamDTO());
        }



    }
}