using BettingApp.Entities;
using BettingApp.ServiceContracts.DTO.Requests;
using BettingApp.ServiceContracts.DTO.Responses;

namespace BettingApp.ServiceContracts
{
    public interface IBettingService // TODO:Interface segregation
    {
        Task<IEnumerable<SportResponse>> GetSportsAsync();
        Task<IEnumerable<LeagueResponse>> GetLeaguesAsync();
        Task<IEnumerable<MatchResponse>> GetMatchesAsync(MatchRequest matchRequest);
        Task<IEnumerable<PickResponse>> GetPickOddsAsync(PickRequest pickRequest);
        Task<WalletResponse?> GetWalletByUserIdAsync(WalletRequest walletRequest);
        Task<bool> DepositAsync(DepositRequest depositRequest);
        Task<bool> AddTicketAsync(TicketRequest ticketRequest);
        Task<bool> UpdateWalletBalance(UpdateWalletRequest updateWalletRequest);
    }
}
