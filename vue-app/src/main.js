import { createApp } from 'vue'
import { createRouter, createWebHistory } from 'vue-router';
import App from './App.vue'
import HomeView from './components/HomeView.vue';
import OfferList from './components/OffersList.vue';
import BetSlip from './components/BetSlip.vue';

import store from './store';

const routes = [
    { path: '/', component: HomeView },
    { path: '/sports/:sportId/leagues/:leagueId', name: 'offer-list', component: OfferList }
  ];

const router = createRouter({
  history: createWebHistory(),
  routes,
  BetSlip,
  linkActiveClass: 'active'
}); 

const app = createApp(App);

app.use(router);
app.use(store);
app.mount('#app');