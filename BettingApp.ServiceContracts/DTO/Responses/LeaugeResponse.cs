using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO.Responses
{
    public class LeagueResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SportId { get; set; }
    }

    public static class LeagueExtensions
    {
        public static LeagueResponse ToLeagueResponse(this League league)
        {
            return new LeagueResponse
            {
                Id = league.Id,
                Name = league.Name,
                SportId = league.SportId,
            };
        }
    }
}
