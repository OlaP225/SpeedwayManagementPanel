using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Speedway.Api.Data;
using Speedway.Api.Interfaces;
using Speedway.Api.Models;
using Speedway.Api.DTOs.Team;
using Microsoft.EntityFrameworkCore;

namespace Speedway.Api.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDBContext _context;
        public TeamRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Team>> GetAllAsync()
        {
            return await _context.Team.ToListAsync();
        }

        public async Task<Team?> GetByIdAsync(int id)
        {
            return await _context.Team.FindAsync(id);
        }
        
        public async Task<Team> CreateAsync(Team teamModel)
        {
            await _context.Team.AddAsync(teamModel);
            await _context.SaveChangesAsync();
            return teamModel;
        }

        public async Task<Team?> UpdateAsync(int id, UpdateTeamRequestDTO updateTeamDTO)
        {
            var existingTeam = await _context.Team.FindAsync(id);
            if (existingTeam == null)
            {
                return null;
            }
            existingTeam.Name = updateTeamDTO.Name;
            await _context.SaveChangesAsync();
            return existingTeam;
        }

        public async Task<Team?> DeleteAsync(int id)
        {
            var teamModel = await _context.Team.FindAsync(id);
            if (teamModel == null)
            {
                return null;
            }
            
            _context.Team.Remove(teamModel);
            await _context.SaveChangesAsync();
            return teamModel;
            
        }
    }
}