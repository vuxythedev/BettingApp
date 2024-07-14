using BettingApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.Entities
{
    public class Pick 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MatchId { get; set; }
        public Match? Match { get; set; }
        [Required]
        public int BetTypeId { get; set; }
        public BetType? BetType { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Odd { get; set; } // can be null!
        public bool IsTopOffer { get; set; }
        public bool IsSuspended { get; set; }
        [Required]
        public PickStatusEnum Status { get; set; }
    }
}

