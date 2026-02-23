using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Npgsql.Replication;
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
        public static Team ToTeamFromCreateDTO(this CreateTeamRequestDTO createTeamRequestDTO)
        {
            return new Team
            {
                Name = createTeamRequestDTO.Name
            };
        }






        }
    
}