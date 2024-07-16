<template>
  <div class="league-container">
    <h2 class="title">{{ sportName }}</h2>
    <ul class="league-list">
      <li v-for="league in leagues" :key="league.id" class="league-item">
        <router-link :to="'/sports/' + sportId + '/leagues/' + league.id" class="league-link">
          {{ league.name }}
        </router-link>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  data() {
    return {
      leagues: [],
      sportName: '',
      sportId: this.$route.params.sportId
    };
  },
  methods: {
    async fetchLeagues() {
      try {
        const response = await fetch('http://localhost:5020/leagues?sportId=' + this.sportId);
        const data = await response.json();
        this.leagues = data;
      } catch (error) {
        console.error('Error fetching leagues:', error);
      }
    },
    async fetchSportName() {
      try {
        const response = await fetch('http://localhost:5020/sports/' + this.sportId);
        const data = await response.json();
        this.sportName = data.name;
      } catch (error) {
        console.error('Error fetching sport name:', error);
      }
    }
  },
  created() {
    this.fetchLeagues();
    this.fetchSportName();
  },
  watch: {
    '$route.params.sportId': 'fetchLeagues'
  }
};
</script>

<style scoped>
.league-container {
  padding: 20px;
}

.title {
  font-size: 1.5em;
  margin-bottom: 20px;
  color: #333;
}

.league-list {
  list-style: none;
  padding: 0;
  margin: 0;
}

.league-item {
  margin-bottom: 10px;
}

.league-link {
  text-decoration: none;
  color: #007bff;
  display: block;
  padding: 10px;
  border-radius: 5px;
}

.league-link:hover {
  background-color: #e9ecef;
  text-decoration: underline;
}
</style>