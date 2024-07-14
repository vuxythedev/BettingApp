using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.Entities
{
    public class TicketBet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; } = null!;
        [Required]
        public int MatchId { get; set; }
        [Required]
        public int BetTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Odd { get; set; }       
    }
}
