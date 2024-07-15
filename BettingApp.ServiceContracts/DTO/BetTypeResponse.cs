using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO
{
    public class BetTypeResponse
    {     
        public int Id { get; set; }  
        public string Name { get; set; } = null!;     
        public string Description { get; set; } = null!;       
    }


    public static class BetTypeExtensions
    {
        public static BetTypeResponse ToBetTypeResponse(this BetType betType)
        {
            return new BetTypeResponse
            {
                Id = betType.Id,
                Name = betType.Name,
                Description = betType.Description,
            };
        }
    }
}
