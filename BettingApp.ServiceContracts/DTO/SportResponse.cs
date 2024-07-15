using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO
{
    public class SportResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;    
    }

    public static class SportExtensions
    {
        public static SportResponse ToSportResponse(this Sport sport)
        {
            return new SportResponse
            {
                Id = sport.Id,
                Name = sport.Name         
            };
        }
    }
}
