using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Speedway.Api.Models;

namespace Speedway.Api.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAllAsync();
    }
}