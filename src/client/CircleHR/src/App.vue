<template>
  <div id="wrapper">
    <Sidebar />
    <div id="content-wrapper">
      <Header />
      <div class="container-fluid"></div>
      <div class="content"></div>
      <footer class="sticky-footer bg-white"><Footer /></footer>
    </div>
  </div>
</template>

<script>
import { RouterLink, RouterView } from "vue-router";
import Footer from "./components/Footer.vue";
import Header from "./components/Header.vue";
import Sidebar from "./components/Sidebar.vue";

export default {
  name: "Admin",
  components: {
    Footer,
    Header,
    Sidebar,
  },
};
</script>
