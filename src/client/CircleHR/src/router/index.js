import { createRouter, createWebHistory } from "vue-router";
import Home from "../pages/HomePage.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  linkActiveClass: "active",
  routes: [
    {
      path: "/",
      name: "home",
      component: Home,
    },
    {
      path: "/login",
      name: "Login",
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import("../pages/Login.vue"),
    },
    {
      path: "/register",
      name: "Register",
      component: () => import("../pages/Register.vue"),
    },
  ],
});

export default router;
