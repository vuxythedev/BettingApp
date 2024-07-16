using BettingApp.ServiceContracts;
using BettingApp.ServiceContracts.DTO.Requests;
using BettingApp.ServiceContracts.DTO.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Controllers
{
    public class BetController : Controller 
    {
        private readonly IBettingService _bettingService;

        public BetController(IBettingService bettingService) // TODO: validate route !!!
        {
            _bettingService = bettingService;
        }
   
        [HttpGet("/sports")]
        public async Task<ActionResult<IEnumerable<SportResponse>>> GetSports()
        {
            var sports = await _bettingService.GetSportsAsync();
            return Ok(sports);
        }

        [HttpGet("/leagues")]
        public async Task<ActionResult<IEnumerable<LeagueResponse>>> GetLeagues()
        {
            var leagues = await _bettingService.GetLeaguesAsync();
            return Ok(leagues);
        }

        [HttpGet("{sportId = 1}/matches")]
        public async Task<ActionResult<IEnumerable<MatchResponse>>> GetMatches([FromRoute] int sportId)
        {
            var matches = await _bettingService.GetMatchesAsync(new MatchRequest(sportId));

            return Ok(matches);
        }

        [HttpGet("/offers/{sportId}/{leagueId}/{isTopOffer}")] 
        public async Task<ActionResult<IEnumerable<PickResponse>>> GetOddsBySportAndLeague([FromRoute] int sportId,
            [FromRoute] int leagueId, [FromRoute] bool isTopOffer)
        {
            var odds = await _bettingService.GetPickOddsAsync(new PickRequest(sportId,leagueId,isTopOffer));
            return Ok(odds);
        }

        [HttpGet("get-wallet")]
        public async Task<IActionResult> GetWallet(int userId)
        {
            var wallet = await _bettingService.GetWalletByUserIdAsync(new WalletRequest(userId));
            
            if (wallet == null)
            {
                return NotFound("Wallet not found");
            }

            return Ok(wallet);
        }

        [HttpPost("deposit")]
        public async Task<IActionResult> DepositAsync([FromBody] DepositRequest request)
        {
          
            if(request.amount <= 0)
            {
                return BadRequest("Deposit amount must be greater than 0.");
            }

            var wallet = await _bettingService.DepositAsync(request);

            if (wallet == false)
            {
                return NotFound("Wallet not found");
            }

            return Ok(wallet);
        }
    }
}
