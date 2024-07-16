using BettingApp.Entities;
using BettingApp.RepositoryContracts;
using BettingApp.ServiceContracts;
using BettingApp.ServiceContracts.DTO.Requests;
using BettingApp.ServiceContracts.DTO.Responses;

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

        public async Task<IEnumerable<LeagueResponse>> GetLeaguesAsync()
        {
            var leagues = await _bettingDataRepository.GetLeaguesAsync();
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

        public async Task<WalletResponse?> GetWalletByUserIdAsync(WalletRequest walletRequest)
        {
            var wallet = await _bettingDataRepository.GetWalletByUserIdAsync(walletRequest.userId);
            return wallet?.ToWalletResponse();
        }
       
        public async Task<bool> DepositAsync(DepositRequest depositRequest)
        {
            int guidId = GuidToInt(Guid.NewGuid());
            return await _bettingDataRepository.DepositAsync(depositRequest.userId, depositRequest.amount, guidId);
        }

        private int GuidToInt(Guid guid)
        {
            byte[] bytes = guid.ToByteArray();
            int intValue = BitConverter.ToInt32(bytes, 0); 
            return intValue;
        }
    }
}
