using BettingApp.Entities;
using BettingApp.ServiceContracts.DTO.Requests;
using BettingApp.ServiceContracts.DTO.Responses;

namespace BettingApp.ServiceContracts
{
    public interface IBettingService
    {
        Task<IEnumerable<SportResponse>> GetSportsAsync();
        Task<IEnumerable<LeagueResponse>> GetLeaguesAsync();
        Task<IEnumerable<MatchResponse>> GetMatchesAsync(MatchRequest matchRequest);
        Task<IEnumerable<PickResponse>> GetPickOddsAsync(PickRequest pickRequest);
        Task<WalletResponse?> GetWalletByUserIdAsync(WalletRequest walletRequest);
        Task<bool> Deposit(DepositRequest depositRequest);
    }
}
