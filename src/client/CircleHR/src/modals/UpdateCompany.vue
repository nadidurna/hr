<template>
  <div
    class="modal fade"
    id="updateModal"
    tabindex="-1"
    role="document"
    aria-labelledby="updateModallLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="updateModalLabel">
            Yeni Tedarikçi Ekleme Ekranı
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
                <label for="Id" class="form-label">Şirket Id</label>
                <input
                  type="text"
                  class="form-control form-control-sm"
                  id="id"
                  v-model="selectedId"
                  disabled="true"
                />
              </div>
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
      selectedId: null,
    };
  },
  mounted() {
    this.instance = new bootstrap.Modal(document.getElementById("updateModal"));
  },
  methods: {
    save() {
      this.hasError = false;
      let data = {
        Id: this.selectedId,
        CompanyName: this.companyName,
        Description: this.description,
        Address: this.address,
        Phone: this.phone,
      };
      this.$ajax
        .put("/api/management/admin/update", data)
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
    open(id) {
      this.selectedId = id;
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
