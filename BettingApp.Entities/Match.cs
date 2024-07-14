using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.Entities
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; } = null!;
        [Required]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; } = null!;
        [Required]
        public int SportId { get; set; }
        public Sport Sport { get; set; } = null!;
        [Required]
        public int LeagueId { get; set; }
        public League League { get; set; } = null!;
        [Required]
        public DateTime StartTime { get; set; }
        public ICollection<Pick> Picks { get; set; } = new List<Pick>();
    }
}
