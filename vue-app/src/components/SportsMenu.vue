<template>
  <div class="sports-menu">
    <h2>Sports</h2>
    <ul class="sports-list">
      <li v-for="sport in sportsWithLeagues" :key="sport.id" class="sport-item">
        <div @click="toggleSport(sport.id)" class="sport-header">
          <img :src="getSportIcon(sport.name)" class="sport-icon" /> 
          <span>{{ sport.name }}</span>
        </div>
        <ul v-if="isSportOpen(sport.id)" class="leagues-list">
          <li v-for="league in sport.leagues" :key="league.id" class="league-item">
            <router-link
              :to="{ name: 'offer-list', params: { sportId: sport.id, leagueId: league.id } }"
              class="league-link"
              active-class="active"
            >
              {{ league.name }}
            </router-link>
          </li>
        </ul>
      </li>
    </ul>
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';

export default {
  data() {
    return {
      openSports: []
    };
  },
  computed: {
    ...mapState({
      sportsWithLeagues: state => {
        console.log('State sportsWithLeagues:', state.sportsWithLeagues);
        return state.sportsWithLeagues;
      }
    })
  },
  created() {
    this.fetchSportsWithLeagues();
  },
  methods: {
    ...mapActions(['fetchSportsWithLeagues']),
    toggleSport(sportId) {
      if (this.openSports.includes(sportId)) {
        this.openSports = this.openSports.filter(id => id !== sportId);
      } else {
        this.openSports.push(sportId);
      }
    },
    isSportOpen(sportId) {
      return this.openSports.includes(sportId);
    },
    getSportIcon(sportName) {
      const icons = {
        Soccer: require('@/assets/icons/football.png'),
         Basketball: require('@/assets/icons/basketball.png'),
        Tennis: require('@/assets/icons/tennis.png'),
        'Table Tennis': require('@/assets/icons/table-tennis.png'),
         Boxing: require('@/assets/icons/boxing.png')
      };
      return icons[sportName] || 'path/to/default-icon.png';
    }
  }
};
</script>

<style scoped>
.sports-menu {
  padding: 10px;
  width: 250px;
  background-color: #f8f9fa;
  border-right: 1px solid #dee2e6;
}

.sports-list {
  list-style: none;
  padding: 0;
  margin: 0;
}

.sport-item {
  margin-bottom: 10px;
}

.sport-header {
  display: flex;
  align-items: center;
  cursor: pointer;
  font-weight: bold;
  padding: 5px;
  border-radius: 5px;
  border: 1px solid #dee2e6;
  background-color: #fff;
}

.sport-header:hover {
  background-color: #e9ecef;
}

.sport-icon {
  width: 30px;
  height: 30px;
  margin-right: 10px;
}

.leagues-list {
  list-style: none;
  padding-left: 0;
  margin: 0;
}

.league-item {
  padding: 5px 10px;
  display: flex;
  align-items: center;
  cursor: pointer;
  font-weight: bold;
  color: #333;
  border-radius: 5px;
  border: 1px solid #dee2e6;
  margin-bottom: 5px;
  background-color: #fff;
}

.league-item:hover {
  background-color: #e9ecef;
}

.league-link {
  text-decoration: none;
  color: inherit;
  flex-grow: 1;
}

.active {
  font-weight: bold;
  color: #007bff;
  border-left: 2px solid #007bff;
  padding-left: 8px;
}
</style>