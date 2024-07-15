using BettingApp.Entities;
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
            return await _context.Sports.ToListAsync();
        }

        public async Task<IEnumerable<League>> GetLeaguesAsync(int sportId)
        {
            return await _context.Leagues.Where(l => l.SportId == sportId).ToListAsync();
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
    }
}
