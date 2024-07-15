using BettingApp.ServiceContracts;
using BettingApp.ServiceContracts.DTO;

using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Controllers
{
    public class BetController : Controller 
    {
        private readonly IBettingService _bettingService;

        public BetController(IBettingService bettingService) // TODO: validate route !!!
        {
            _bettingService = bettingService;
        }
   
        [HttpGet("/")]
        public async Task<ActionResult<IEnumerable<SportResponse>>> GetSports()
        {
            var sports = await _bettingService.GetSportsAsync();
            return Ok(sports);
        }

        [HttpGet("{sportId = 1}/leagues")]
        public async Task<ActionResult<IEnumerable<LeagueResponse>>> GetLeagues([FromRoute] int sportId)
        {
            var leagues = await _bettingService.GetLeaguesAsync(new LeagueRequest(sportId));
            return Ok(leagues);
        }

        [HttpGet("{sportId = 1}/matches")]
        public async Task<ActionResult<IEnumerable<MatchResponse>>> GetMatches([FromRoute] int sportId)
        {
            var matches = await _bettingService.GetMatchesAsync(new MatchRequest(sportId));

            return Ok(matches);
        }

        [HttpGet("{sportId}/{leagueId}/{isTopOffer}/odds")] 
        public async Task<ActionResult<IEnumerable<PickResponse>>> GetOddsBySportAndLeague([FromRoute] int sportId,
            [FromRoute] int leagueId, [FromRoute] bool isTopOffer)
        {
            var odds = await _bettingService.GetPickOddsAsync(new PickRequest(sportId,leagueId,isTopOffer));
            return Ok(odds);
        }

    }
}
