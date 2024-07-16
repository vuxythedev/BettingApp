using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.RepositoryContracts
{
    public interface IBettingDataRepository
    {
        Task<IEnumerable<Sport>> GetSportsAsync();
        Task<IEnumerable<League>> GetLeaguesAsync();
        Task<IEnumerable<Match>> GetMatchesAsync(int sportId);
        Task<IEnumerable<Pick>> GetPickOddsAsync(int sportId, int leagueId, bool isTopOffer = false);
        Task<Wallet?> GetWalletByUserIdAsync(int userId);
        Task<bool> DepositAsync(int userId, decimal amount, int transactionId);
    }
       
}
