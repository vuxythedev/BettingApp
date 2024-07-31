<template>
  <div class="wallet-balance">
    <h2>Wallet Balance</h2>
    <p>Current Balance: €{{ walletBalance.toFixed(2) }}</p>
    <div class="deposit">
      <input v-model.number="depositAmount" type="number" placeholder="Enter amount" />
      <button @click="deposit" class="wallet-button">💼</button>
    </div>
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';
import { v4 as uuidv4 } from 'uuid';

export default {
  data() {
    return {
      depositAmount: 0
    };
  },
  computed: {
    ...mapState({
      walletBalance: state => state.walletBalance || 0
    })
  },
  methods: {
    ...mapActions(['fetchWalletBalance', 'depositToWallet']),
    deposit() {
      if (this.depositAmount > 0) {
        const userId = 1; 
        const transactionGuid = uuidv4();
        console.log(transactionGuid);
        this.depositToWallet({ userId, amount: this.depositAmount, transactionGuid: transactionGuid }).then(() => {
          this.depositAmount = 0;
          this.fetchWalletBalance(userId);
        });
      } else {
        alert('Deposit amount must be greater than zero.');
      }
    }
  },
  mounted() {
    const userId = 1; 
    this.fetchWalletBalance(userId);
  }
}
</script>

<style scoped>
.wallet-balance {
  border: 1px solid #dee2e6;
  padding: 20px;
  margin-top: 10px;
  background-color: #f8f9fa;
  width:150px;
  position:fixed;
  right: 20%;
  top:20px;

}

.deposit {
  display: flex;
  align-items: center;
  gap: 10px;
}

.deposit input {
  padding: 5px;
  border: 1px solid #dee2e6;
  border-radius: 5px;
  width: 100px;
}

.deposit button {
  padding: 5px 10px;
  border: 1px solid #dee2e6;
  background-color: #ffbb00;
  cursor: pointer;
  border-radius: 5px;
}

.deposit button:hover {
  background-color: #0056b3;
  color: white;
}
</style>