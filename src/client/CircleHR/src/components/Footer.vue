<template>
  <footer class="sticky-footer bg-white">
    <div class="container col-3"></div>
    <div class="container col-3">
      Copyright &copy; Boost Blue Team {{ new Date().getFullYear() }}
    </div>
    <div class="container col-3" id="icons">
      <!-- Facebook -->
      <i class="fab fa-facebook-f"></i>

      <!-- Twitter -->
      <i class="fab fa-twitter"></i>

      <!-- Instagram -->
      <i class="fab fa-instagram"></i>

      <!-- Linkedin -->
      <i class="fab fa-linkedin-in"></i>

      <!-- Youtube -->
      <i class="fab fa-youtube"></i>

      <!-- Github -->
      <i class="fab fa-github"></i>

      <!-- Whatsapp -->
      <i class="fab fa-whatsapp"></i>
    </div>
  </footer>
</template>
<script>
import Calendar from "../pages/Calendar.vue";
export default {
  components: { Calendar },
};
</script>
<style>
footer.sticky-footer {
  padding: 2rem 0;
  display: flex;
  position: fixed;
  bottom: 0px;
  width: 100%;
  height: 50px;
  padding: 15px;
  background-color: aqua;
  color: rgba(0, 0, 0, 0.568);
}

.copyright {
  width: 4500px;
  line-height: 1;
  font-size: 0.8rem;
  color: black;
}

body.sidebar-toggled footer.sticky-footer {
  width: 100%;
}

#icons {
  display: inline-flex;
  text-align: center;
  justify-content: space-around;
}
</style>
