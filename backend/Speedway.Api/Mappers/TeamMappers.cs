using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Speedway.Api.DTOs.Team;
using Speedway.Api.Models;

namespace Speedway.Api.Mappers
{
    public static class TeamMappers
    {
        public static TeamDTO ToTeamDTO(this Team teamModel)
        {
            return new TeamDTO
            {
                Id = teamModel.Id,
                Name = teamModel.Name
            };
        }
    }
}