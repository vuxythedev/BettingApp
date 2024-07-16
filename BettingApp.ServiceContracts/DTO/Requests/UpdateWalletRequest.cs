using BettingApp.Entities;


namespace BettingApp.ServiceContracts.DTO.Requests
{
    public class UpdateWalletRequest
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }

        public Wallet ToWallet()
        {
            return new Wallet() {  UserId = UserId, Balance = Amount };
        }
    }
}
