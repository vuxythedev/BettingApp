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
            var matches = await _bettingDataRepository.GetMatchesAsync(matchRequest.sportId); // :TODO .ToMatch()
            return matches.Select(m => m.ToMatchResponse()).ToList();
        }

        public async Task<IEnumerable<PickResponse>> GetPickOddsAsync(PickRequest pickRequest)
        {
            var picks = await _bettingDataRepository.GetPickOddsAsync(pickRequest.sportId, pickRequest.leagueId, pickRequest.isTopOffer); // :TODO .ToPick();
            return picks.Select(p => p.ToPickResponse()).ToList();
        }

        public async Task<WalletResponse?> GetWalletByUserIdAsync(WalletRequest walletRequest)
        {
            var wallet = await _bettingDataRepository.GetWalletByUserIdAsync(walletRequest.userId); // :TODO .ToWallet();
            return wallet?.ToWalletResponse();
        }
       
        public async Task<bool> DepositAsync(DepositRequest depositRequest)
        {
            int guidId = GuidToInt(Guid.NewGuid());
            return await _bettingDataRepository.DepositAsync(depositRequest.userId, depositRequest.amount, guidId); 
        }

        public async Task<bool> AddTicketAsync(TicketRequest ticketRequest)
        {
            return await _bettingDataRepository.CreateTicket(ticketRequest.ToTicket());
        }

        public async Task<bool> UpdateWalletBalance(UpdateWalletRequest updateWalletRequest)
        {
            return await _bettingDataRepository.UpdateWalllet(updateWalletRequest.ToWallet());
        }

        private int GuidToInt(Guid guid)
        {
            byte[] bytes = guid.ToByteArray();
            int intValue = BitConverter.ToInt32(bytes, 0);
            return intValue;
        }
    }
}
