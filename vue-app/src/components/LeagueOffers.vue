<template>
  <div class="league-offers">
    <div class="league-header" @click="toggleLeague">
      <h2>{{ league.name }}</h2>
    </div>
    <div v-if="isOpen" class="matches">
      <div v-for="match in matches" :key="match.id" class="match">
        <div class="match-header">
          <span>{{ match.homeTeam }} vs {{ match.awayTeam }}</span>
          <span>{{ new Date(match.startTime).toLocaleString() }}</span>
        </div>
        <div class="odds">
          <div v-for="offer in match.offers" :key="offer.id" class="odd">
            {{ offer.betType.name }}: {{ offer.odd }}
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    league: Object,
    matches: Array
  },
  data() {
    return {
      isOpen: false
    };
  },
  methods: {
    toggleLeague() {
      this.isOpen = !this.isOpen;
    }
  }
};
</script>

<style scoped>
.league-offers {
  margin-bottom: 20px;
}

.league-header {
  cursor: pointer;
  padding: 10px;
  background-color: #f8f9fa;
  border: 1px solid #dee2e6;
  border-radius: 5px;
}

.league-header:hover {
  background-color: #e9ecef;
}

.matches {
  padding: 10px;
  border: 1px solid #dee2e6;
  border-radius: 5px;
  background-color: #fff;
}

.match {
  margin-bottom: 15px;
}

.match-header {
  font-weight: bold;
  margin-bottom: 10px;
}

.odds {
  display: flex;
  justify-content: space-between;
}

.odd {
  flex: 1;
  text-align: center;
  padding: 5px;
  border: 1px solid #dee2e6;
  border-radius: 5px;
  background-color: #f8f9fa;
}

.odd:not(:last-child) {
  margin-right: 10px;
}
</style>