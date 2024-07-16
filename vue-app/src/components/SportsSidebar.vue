<template>
  <div class="sidebar">
    <SportsMenu />
  </div>
</template>

<script>
import SportsMenu from './SportsMenu.vue';

export default {
  components: {
    SportsMenu
  }
};
</script>

<style scoped>
.sidebar {
  width: 50px;
  background-color: #f8f9fa;
  border-right: 1px solid #dee2e6;
}
</style>