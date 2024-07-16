using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO.Requests
{
    public class TicketRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public ICollection<TicketBet> TicketBets { get; set; } = new List<TicketBet>();

        public Ticket ToTicket()
        {
            return new Ticket() { Id = Id, UserId = UserId, Date = Date, TicketBets = TicketBets };
        }
    }
}
