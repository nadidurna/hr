import axios from "axios";

export default {
  install: (app) => {
    const instance = axios.create({
      baseURL: "https://localhost:7000",
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
        return instance.get(url); //, addHeader(); sonra eklenecek
      },
      post: function (url, data) {
        return instance.post(url, data); //, addHeader()
      },
      delete: function (url) {
        return instance.delete(url); //addHeader()
      },
      put: function (url, data) {
        return instance.put(url, data); //, addHeader()
      },
    };
    app.config.globalProperties.$ajax = ajax;
  },
};
