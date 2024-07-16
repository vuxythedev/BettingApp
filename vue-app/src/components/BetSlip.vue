<template>
  <div class="bet-slip">
    <h2>Bet Slip</h2>
    <div v-for="bet in betSlip" :key="bet.id" class="bet-item">
      <div class="bet-details">
        <div class="bet-match">
          <span>{{ bet.match.homeTeam + ' - ' + bet.match.awayTeam }}</span>                 
        </div>
        <div class="bet-info">
          <span>{{ bet.betType.name }}: {{ bet.odd }}</span>
        </div>
      </div>
      <button @click="removeBet(bet.id)">X</button>
    </div>
    <div class="bet-summary">
      <div class="bet-total">  
         <span>€{{ totalToPay }}</span>         
        <span>Possible winnings: €{{ possibleWinnings }}</span>
      </div>
      <div class="bet-amount">
        <button v-for="amount in betAmounts" :key="amount" @click="setBetAmount(amount)">
          €{{ amount }}
        </button>
      </div>
      <input type="number" v-model="betAmount" placeholder="Bet Amount">
      <div class="bet-actions">
        <button @click="submitBet" class="submit-bet-button">Submit Bet</button>
        <button class="wallet-button">💼</button>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';

export default {
  data() {
    return {
      betAmounts: [10, 20, 25, 50, 100],
      betAmount: 2,
      userId:1

    };
  },
  computed: {
    ...mapState({
      betSlip: state => state.betSlip
    }),
    totalToPay() {
      return (this.betSlip.length * this.betAmount * 0.95).toFixed(2); 
    },
    possibleWinnings() {
      return (this.betSlip.reduce((total, bet) => total + (bet.odd * this.betAmount * 0.95), 0)).toFixed(2); 
    }
  },
  methods: {
    ...mapActions(['removeBet','fetchWalletBalance','addTicket']),
    setBetAmount(amount) {
      if (amount > 0) {
        this.betAmount = amount;
      } else {
        alert('Bet amount must be greater than zero.');
      }
    },
  async submitBet() {   
      if (this.betAmount <= 0 ||  this.betAmount > this.walletBalance) {
        alert('Invalid bet amount or insufficient funds');
        return;

      }

      const ticketRequest = {
        userId: this.userId,
        amount: this.totalToPay,
        date: new Date(),
        ticketBets: this.betSlip.map(bet => ({
          matchId: bet.match.id,
          betTypeId: bet.betType.id,
          odd: bet.odd
        }))
      };

      const success = await this.addTicket(ticketRequest);

      if (success) {
        alert("Bet submitted successfully!");
         
        await this.$store.dispatch('updateWalletBalance', {
        userId: this.userId,
        amount: -this.betAmount  
      });

        this.betSlip = [];
        this.fetchWalletBalance(this.userId);
      } else {
        alert("Failed to submit bet" + '' +this.ticketRequest);
      }     
    },
  }
};
</script>

<style scoped>
.bet-slip {
  border: 1px solid #dee2e6;
  padding: 10px;
  margin-top: 20px;
  background-color: #f8f9fa;
  width: 300px;
  position: fixed;
  right: 20px;
  top: 20px;
}

.bet-item {
  display: flex;
  justify-content: space-between;
  padding: 5px 0;
  border-bottom: 1px solid #dee2e6;
}

.bet-details {
  flex: 1;
}

.bet-match, .bet-info {
  display: flex;
  justify-content: space-between;
}

.bet-summary {
  margin-top: 20px;
}

.bet-total {
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
}

.bet-amount {
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
}

.bet-amount button {
  padding: 5px 10px;
  border: 1px solid #dee2e6;
  background-color: #fff;
  cursor: pointer;
}

.bet-amount button:hover {
  background-color: #e9ecef;
}

.bet-actions {
  display: flex;
  justify-content: space-between;
  margin-top: 20px;
}

.submit-bet-button {
  padding: 10px 20px;
  border: none;
  background-color: #007bff;
  color: white;
  cursor: pointer;
  border-radius: 5px;
}

.submit-bet-button:hover {
  background-color: #0056b3;
}

.wallet-button {
  padding: 10px;
  border: none;
  background-color: #ffc107;
  color: white;
  cursor: pointer;
  border-radius: 5px;
}

.wallet-button:hover {
  background-color: #e0a800;
}
</style>