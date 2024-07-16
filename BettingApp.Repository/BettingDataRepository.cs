using BettingApp.Entities;
using BettingApp.Entities.Enums;
using BettingApp.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Repository
{
    public class BettingDataRepository : IBettingDataRepository
    {
        private readonly BettingDbContext _context;
        public BettingDataRepository(BettingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sport>> GetSportsAsync()
        {
            var sports = _context.Sports
           .Include(s => s.Leagues)
           .ToListAsync();

            return await sports;
        }

        public async Task<IEnumerable<League>> GetLeaguesAsync()
        {
            return await _context.Leagues
                .Include(l => l.Sport)
                .ToListAsync();
        }

        public async Task<IEnumerable<Match>> GetMatchesAsync(int sportId)
        {
            var matches = await _context.Matches
             .Include(m => m.HomeTeam)
             .Include(m => m.AwayTeam)
             .Include(m => m.Sport)
             .Include(m => m.League)
             .Where(m => m.SportId == sportId)
             .ToListAsync();

            return matches;
        }

        public async Task<IEnumerable<Pick>> GetPickOddsAsync(int sportId, int leagueId, bool isTopOffer = false)
        {
            return await _context.Picks
             .Include(p => p.BetType)
             .Include(p => p.Match)
                 .ThenInclude(m => m.HomeTeam)
             .Include(p => p.Match)
                 .ThenInclude(m => m.AwayTeam)
            
             .Where(p => p.Match != null && p.Match.SportId == sportId && p.Match.LeagueId == leagueId && p.IsTopOffer == isTopOffer)
             .ToListAsync();
        }

        public async Task<Wallet?> GetWalletByUserIdAsync(int userId)
        {
            return await _context.Wallets
                .Include(w => w.Transactions)
                .FirstOrDefaultAsync(w => w.UserId == userId);
        }

        public async Task<bool> DepositAsync(int userId, decimal amount)
        {
            var wallet = await GetWalletByUserIdAsync(userId);

            if (wallet == null)
            {
                return false;
            }

            wallet.Balance += amount;
            wallet?.Transactions?.Add(new Transaction
            {
                Amount = amount,
                Date = DateTime.UtcNow,
                Type = TransactionEnum.Deposit,
                WalletId = wallet.Id
            });

             await _context.SaveChangesAsync();

            return true;

        }
    }
}
