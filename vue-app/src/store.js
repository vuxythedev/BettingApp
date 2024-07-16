import { createStore } from 'vuex';

const store = createStore({
  state: {
    sportsWithLeagues: [],
    offers: [],
    betSlip: []
  },
  mutations: {
    setSportsWithLeagues(state, data) {
      state.sportsWithLeagues = data;
    },
    setOffers(state, offers) {
      state.offers = offers;
    },
    addBetToSlip(state, offer) {
      if (!state.betSlip.some(bet => bet.id === offer.id)) {
        state.betSlip.push(offer);
      }
    },
    removeBet(state, betId) {
      state.betSlip = state.betSlip.filter(bet => bet.id !== betId);
    }
  },
  actions: {
    async fetchSportsWithLeagues({ commit }) {
      try {
        const sportsResponse = await fetch('http://localhost:5020/sports');
        const sportsData = await sportsResponse.json();

        const leaguesResponse = await fetch('http://localhost:5020/leagues');
        const leaguesData = await leaguesResponse.json();

        const sportsWithLeagues = sportsData.map(sport => {
          return {
            ...sport,
            leagues: leaguesData.filter(league => league.sportId === sport.id)
          };
        });

        commit('setSportsWithLeagues', sportsWithLeagues);
      } catch (error) {
        console.error('Error fetching sports and leagues:', error);
      }
    },
    async fetchOffers({ commit }, { sportId, leagueId }) {
      try {
        const offersResponse = await fetch(`http://localhost:5020/offers/${sportId}/${leagueId}/false`);
        const offersData = await offersResponse.json();
        commit('setOffers', offersData);
      } catch (error) {
        console.error('Error fetching offers:', error);
      }
    },
    addBetToSlip({ commit }, offer) {
      commit('addBetToSlip', offer);
    },
    removeBet({ commit }, betId) {
      commit('removeBet', betId);
    }
  }
});

export default store;