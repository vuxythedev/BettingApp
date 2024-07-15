using BettingApp.Entities;
using BettingApp.ServiceContracts.DTO;

namespace BettingApp.ServiceContracts
{
    public interface IBettingService
    {
        Task<IEnumerable<SportResponse>> GetSportsAsync();
        Task<IEnumerable<LeagueResponse>> GetLeaguesAsync(LeagueRequest leagueRequest);
        Task<IEnumerable<MatchResponse>> GetMatchesAsync(MatchRequest matchRequest);
        Task<IEnumerable<PickResponse>> GetPickOddsAsync(PickRequest pickRequest);
    }
}
