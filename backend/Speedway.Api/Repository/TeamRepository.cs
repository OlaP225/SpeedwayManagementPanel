using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Speedway.Api.Data;
using Speedway.Api.Interfaces;
using Speedway.Api.Models;
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
        public Task<List<Team>> GetAllAsync()
        {
            return _context.Team.ToListAsync();
        }
    }
}