using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Speedway.Api.DTOs.Team;
using Speedway.Api.Models;

namespace Speedway.Api.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllAsync();
        Task<Team?> GetByIdAsync(int id);
        Task<Team> CreateAsync(Team teamModel);
        Task<Team?> UpdateAsync(int id, UpdateTeamRequestDTO teamDTO);
        Task<Team?> DeleteAsync(int id);
    }
}