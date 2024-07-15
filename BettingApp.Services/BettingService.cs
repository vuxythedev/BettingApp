using BettingApp.Entities;
using BettingApp.RepositoryContracts;
using BettingApp.ServiceContracts;
using BettingApp.ServiceContracts.DTO;

namespace BettingApp.Services
{
    public class BettingService : IBettingService
    {
        private readonly IBettingDataRepository _bettingDataRepository;

        public BettingService(IBettingDataRepository bettingDataRepository)
        {
            _bettingDataRepository = bettingDataRepository;
        }

        public async Task<IEnumerable<SportResponse>> GetSportsAsync()
        {
            var sports = await _bettingDataRepository.GetSportsAsync();
            return sports.Select(s => s.ToSportResponse()).ToList();
        }

        public async Task<IEnumerable<LeagueResponse>> GetLeaguesAsync(LeagueRequest leagueRequest)
        {
            var leagues = await _bettingDataRepository.GetLeaguesAsync(leagueRequest.sportId);
            return leagues.Select(l => l.ToLeagueResponse()).ToList();
        }

        public async Task<IEnumerable<MatchResponse>> GetMatchesAsync(MatchRequest matchRequest)
        {
            var matches = await _bettingDataRepository.GetMatchesAsync(matchRequest.sportId);
            return matches.Select(m => m.ToMatchResponse()).ToList();
        }

        public async Task<IEnumerable<PickResponse>> GetPickOddsAsync(PickRequest pickRequest)
        {
            var picks = await _bettingDataRepository.GetPickOddsAsync(pickRequest.sportId, pickRequest.leagueId, pickRequest.isTopOffer);
            return picks.Select(p => p.ToPickResponse()).ToList();
        }
    }
}
