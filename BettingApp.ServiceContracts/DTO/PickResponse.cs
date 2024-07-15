using BettingApp.Entities;
using BettingApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO
{
    public class PickResponse
    {
        public int Id { get; set; }       
        public MatchResponse?  Match{ get; set; }        
        public BetTypeResponse? BetType { get; set; }
        public decimal? Odd { get; set; }
        public bool IsTopOffer { get; set; }
        public bool IsSuspended { get; set; }
        public PickStatusEnum Status { get; set; }
    }

    public static class PickExtensions
    {
        public static PickResponse ToPickResponse(this Pick pick)
        {
            return new PickResponse
            {
                Id = pick.Id,
                Match = pick.Match?.ToMatchResponse(),
                BetType = pick.BetType?.ToBetTypeResponse(),
                Odd = pick.Odd,
                IsTopOffer = pick.IsTopOffer,
                IsSuspended = pick.IsSuspended,
                Status = pick.Status            
            };
        }
    }
}
