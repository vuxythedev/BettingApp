using BettingApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO.Responses
{
    public class WalletResponse
    {     
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public int UserId { get; set; }
    
    }

    public static class WalletExtensions
    {
        public static WalletResponse ToWalletResponse(this Wallet wallet)
        {
            return new WalletResponse
            {
                Id = wallet.Id,
                Balance = wallet.Balance,
                UserId = wallet.UserId
            };
        }
    }
}
