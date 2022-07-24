<template>
  <div
    class="modal fade"
    id="newModal"
    tabindex="-1"
    role="document"
    aria-labelledby="newModalLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="newModalLabel">
            Yeni Şirket Ekleme Ekranı
          </h5>
          <button
            class="close"
            type="button"
            data-dismiss="modal"
            aria-label="Close"
          >
            <span aria-hidden="true">×</span>
          </button>
        </div>
        <div class="modal-body">
          <div v-if="hasError" class="alert alert-warning m-1">
            Veriler doğrulanamadı...
          </div>
          <div class="row">
            <div class="col">
              <div class="mb-1">
                <label for="companyName" class="form-label">Şirket Adı</label>
                <input
                  type="text"
                  class="form-control form-control-sm"
                  id="companyName"
                  v-model="companyName"
                />
              </div>
              <div class="mb-1">
                <label for="description" class="form-label">Açıklaması</label>
                <input
                  type="text"
                  class="form-control form-control-sm"
                  id="description"
                  v-model="description"
                />
              </div>
              <div class="mb-1">
                <label for="address" class="form-label">Adres</label>
                <input
                  type="text"
                  class="form-control form-control-sm"
                  id="address"
                  v-model="address"
                />
              </div>
              <div class="mb-1">
                <label for="phone" class="form-label">Telefon</label>
                <input
                  type="text"
                  class="form-control form-control-sm"
                  id="phone"
                  v-model="phone"
                />
              </div>
            </div>
          </div>
        </div>
        <div class="modal-footer">
          <button class="btn btn-secondary" type="button" data-dismiss="modal">
            Kapat
          </button>
          <a class="btn btn-primary" @click="save" type="button">Kaydet</a>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  emits: ["success"],
  data() {
    return {
      instance: null,
      companyName: null,
      description: null,
      address: null,
      phone: null,
      hasError: false,
    };
  },
  mounted() {
    this.instance = new bootstrap.Modal(document.getElementById("newModal"));
  },
  methods: {
    save() {
      this.hasError = false;
      let data = {
        CompanyName: this.companyName,
        Description: this.description,
        Address: this.address,
        Phone: this.phone,
      };
      this.$ajax
        .post("/api/management/admin/addCompany", data)
        .then((response) => {
          if (response) {
            this.instance.hide();
            this.clear();
            this.$emit("success");
          }
        })
        .catch(() => {
          if (error.response.status == 401) {
            this.$router.push("/login");
          } else {
            this.hasError = true;
          }
        });
    },
    open() {
      this.hasError = false;
      this.instance.show();
    },
    clear() {
      this.companyName = null;
      this.address = null;
      this.description = null;
      this.phone = null;
    },
  },
};
</script>
<style scoped></style>
