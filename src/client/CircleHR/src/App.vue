<template>
  <div id="wrapper">
    <Sidebar />
    <div id="content-wrapper">
      <Header />
      <div class="container-fluid"></div>
      <div class="content"><RouterView /></div>
      <Footer />
    </div>
  </div>
</template>

<script>
import { RouterLink, RouterView } from "vue-router";
import Footer from "./components/Footer.vue";
import Header from "./components/Header.vue";
import Sidebar from "./components/Sidebar.vue";

export default {
  name: "App",
  components: {
    Footer,
    Header,
    Sidebar,
  },
};
</script>

<style>
.content {
  margin: 20px;
}
</style>
