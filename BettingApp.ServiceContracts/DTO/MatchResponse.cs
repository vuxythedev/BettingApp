using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO
{
    public class MatchResponse
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; } = null!;
        public string AwayTeam { get; set; } = null!;
        public string League { get; set; } = null!;
        public DateTime StartTime { get; set; }
    }

    public static class MatchExtensions
    {
        public static MatchResponse ToMatchResponse(this Match match)
        {
        
            return new MatchResponse
            {
                Id = match.Id,
                HomeTeam = match.HomeTeam != null ? match.HomeTeam.Name : string.Empty,
                AwayTeam = match.AwayTeam != null? match.AwayTeam.Name : string.Empty,
                League = match.League != null? match.League.Name : string.Empty,
                StartTime = match.StartTime
            };
        }

       
    }
}
