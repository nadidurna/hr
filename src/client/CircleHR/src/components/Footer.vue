<template>
  <footer class="sticky-footer bg-white">
    <div class="container my-auto">
      <div class="copyright">
        <Calendar />
      </div>
      <div class="copyright">Copyright &copy; Boost Blue Team 2022</div>
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
  flex-shrink: 0;
}
.copyright {
  line-height: 1;
  font-size: 0.8rem;
}

body.sidebar-toggled footer.sticky-footer {
  width: 100%;
}
</style>
