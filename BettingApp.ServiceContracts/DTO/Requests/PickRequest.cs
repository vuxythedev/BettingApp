using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO.Requests
{
    public record PickRequest(int sportId, int leagueId, bool isTopOffer);
}
