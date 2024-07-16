<template>
  <div class="offers-list">
    <div v-for="match in matches" :key="match.id" class="match">
      <div class="match-header">
        <span>{{ match.homeTeam }}</span>
        <span>vs</span>
        <span>{{ match.awayTeam }}</span>
      </div>
      <div class="match-details">
        <span>{{ new Date(match.startTime).toLocaleString() }}</span>
      </div>
      <div class="odds">
        <div
          v-for="offer in match.offers"
          :key="offer.id"
          :class="['odd', isBetInSlip(offer.id) ? 'selected' : '']"
          @click="toggleBet(offer)"
        >
          <label>{{ offer.betType.name }}</label>
          <span>{{ offer.odd }}</span>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';

export default {
  computed: {
    ...mapState({
      offers: state => state.offers,
      betSlip: state => state.betSlip
    }),
    matches() {
      return this.offers.reduce((matches, offer) => {
        let match = matches.find(m => m.id === offer.match.id);
        if (!match) {
          match = { ...offer.match, offers: [] };
          matches.push(match);
        }
        match.offers.push(offer);
        return matches;
      }, []);
    }
  },
  watch: {
    '$route.params': {
      handler(params) {
        this.fetchOffers({
          sportId: params.sportId,
          leagueId: params.leagueId
        });
      },
      immediate: true
    }
  },
  methods: {
    ...mapActions(['fetchOffers', 'addBetToSlip', 'removeBet']),
    toggleBet(offer) {
      if (this.isBetInSlip(offer.id)) {
        this.removeBet(offer.id);
      } else {
        this.addBetToSlip(offer);
      }
    },
    isBetInSlip(betId) {
      return this.betSlip.some(bet => bet.id === betId);
    }
  }
};
</script>

<style scoped>
.offers-list {
  padding: 20px;
}

.match {
  margin-bottom: 15px;
  border: 1px solid #dee2e6;
  border-radius: 5px;
  background-color: #fff;
  padding: 10px;
}

.match-header {
  display: flex;
  justify-content: center;
  font-weight: bold;
  padding: 10px;
  background-color: #f8f9fa;
  gap: 10px;
}

.match-details {
  font-size: 0.9em;
  color: #777;
  padding: 5px 0;
}

.odds {
  display: flex;
  flex-wrap: wrap;
  padding: 10px 0;
  gap: 10px;
}

.odd {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 10px;
  border: 1px solid #dee2e6;
  border-radius: 5px;
  background-color: #f8f9fa;
  width: 100px;
  text-align: center;
  cursor: pointer;
  gap:50px;
}

.odd.selected {
  background-color: #f5a142;
}

.odd label {
  font-size: 0.7em;
  color: black;
}

.odd span {
  font-size: 0.9em;
  font-weight: bold;
}
</style>