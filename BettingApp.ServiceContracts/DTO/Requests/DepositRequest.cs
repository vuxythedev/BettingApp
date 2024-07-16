using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.ServiceContracts.DTO.Requests
{
    public record DepositRequest(int userId, decimal Amount);
}
