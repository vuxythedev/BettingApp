using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO
{
    public class TeamResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    public static class TeamExtensions
    {
        public static TeamResponse ToTeamResponse(this Team team)
        {
            return new TeamResponse
            {
                Id = team.Id,
                Name = team.Name        
            };
        }
    }
}
