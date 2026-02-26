using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> GetAll()
        {
            var teams = await _context.Team.ToListAsync();
            var teamsDTO = teams.Select(t => t.ToTeamDTO());
            return Ok(teamsDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var team = await _context.Team.FindAsync(id);
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
        public async Task<IActionResult> Create([FromBody] CreateTeamRequestDTO createTeamDTO)
        {
            var teamModel = createTeamDTO.ToTeamFromCreateDTO();
            await _context.Team.AddAsync(teamModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = teamModel.Id }, teamModel.ToTeamDTO());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task <IActionResult> Update([FromRoute] int id, [FromBody] UpdateTeamRequestDTO updateTeamDTO)
        {
            var teamModel = await _context.Team.FindAsync(id);
            if (teamModel == null)
            {
                return NotFound();
            }
            
            teamModel.Name = updateTeamDTO.Name;
            await _context.SaveChangesAsync();
            return Ok(teamModel.ToTeamDTO());
        }

        [HttpDelete]
        [Route("{id}")] //same as [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var teamModel = await _context.Team.FindAsync(id);
            if (teamModel == null)
            {
                return NotFound();
            }
            else
            {
                _context.Team.Remove(teamModel);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }

    



}
