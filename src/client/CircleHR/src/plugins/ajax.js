import axios from "axios";

export default {
  install: (app) => {
    const instance = axios.create({
      baseURL: "https://localhost:15000",
    });
    const addHeader = () => {
      let config = {
        headers: {},
      };
      const token = store.state.session.token;
      if (token) {
        config.headers["Authorization"] = "Bearer " + token;
      }
      return config;
    };

    let ajax = {
      get: function (url) {
        return instance.get(url, addHeader());
      },
      post: function (url) {
        return instance.post(url, addHeader());
      },
      delete: function (url) {
        return instance.delete(url, addHeader());
      },
      put: function (url) {
        return instance.put(url, addHeader());
      },
    };
    app.config.globalProperties.$ajax = ajax;
  },
};
