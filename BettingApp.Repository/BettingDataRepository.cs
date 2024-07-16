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

        public async Task<bool> DepositAsync(int userId, decimal amount, int transactionId)
        {
            var wallet = await GetWalletByUserIdAsync(userId);

            if (wallet == null)
            {
                return false;
            }

            wallet.Balance += amount;
            wallet?.Transactions?.Add(new Transaction
            {   Id = transactionId,        
                Amount = amount,
                Date = DateTime.UtcNow,
                Type = TransactionEnum.Deposit,
                WalletId = wallet.Id
            });

             await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> CreateTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
           return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Ticket>> GetUserTicketsAsync(int userId)
        {
            return await _context.Tickets
            .Include(t => t.TicketBets)
            .Where(t => t.UserId == userId)
            .ToListAsync();
        }

        public async Task<bool> UpdateWalllet(Wallet updateWallet)
        {
            var wallet = await _context.Wallets.FirstOrDefaultAsync(w => w.UserId == updateWallet.UserId);
            if (wallet == null)
            {
                return false;
            }

            wallet.Balance += updateWallet.Balance;
            if (wallet.Balance < 0)
            {
                wallet.Balance -= updateWallet.Balance; // Revert the transaction if balance is insufficient
                return false;
            }

            _context.Wallets.Update(wallet);
            await _context.SaveChangesAsync();
            return true;
       }
   
    }
}
