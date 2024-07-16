<template>
  <div id="app">
    <div class="sidebar">
      <SportsMenu />
    </div>
    <div class="main-content">
      <router-view />
    </div>
    <BetSlip />
  </div>
</template>

<script>
import SportsMenu from './components/SportsMenu.vue';
import BetSlip from './components/BetSlip.vue';

export default {
  name: 'App',
  components: {
    SportsMenu,
    BetSlip
  }
};
</script>

<style>
#app {
  display: flex;
}

.sidebar {
  width: 250px;
}

.main-content {
  flex: 1;
  padding: 20px;
}
</style>