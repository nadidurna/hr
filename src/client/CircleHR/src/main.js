import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import ajax from "./plugins/ajax.js";
import "./assets/main.css";

const app = createApp(App);

app.use(router);
app.use(ajax);
app.mount("#app");
