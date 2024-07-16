<template>
  <div id="app">
    <div class="sidebar">
      <SportsMenu />
    </div>
    <div class="main-content">
      <router-view />
      <div class="right-sidebar">
        <WalletBalance />
        <BetSlip />
      </div>
    </div>
  </div>
</template>

<script>
import SportsMenu from './components/SportsMenu.vue';
import BetSlip from './components/BetSlip.vue';
import WalletBalance from './components/WalletBalance.vue';


export default {
  name: 'App',
  components: {
    SportsMenu,
    BetSlip,
    WalletBalance
  }
};
</script>

<style>
#app {
  display: flex;
}

.sidebar {
  width: 20%;
}

.main-content {
    display: flex;
  width: 90%;
  
}

.right-sidebar {
  display: flex;
  flex-direction: column;
  width: 300px;
  margin-left: auto;
}

.wallet-balance, .bet-slip {
  margin-bottom: 20px;
}

</style>