<template>
  <div class="heading" style="margin-bottom: 1rem; font-weight: bolder">
    <h3>Şirket Yönetim Paneli</h3>
  </div>
  <Transition>
    <div v-if="isSuccess" class="alert alert-success">İşlem Başarılı :)</div>
  </Transition>
  <Transition>
    <div v-if="isFailed" class="alert alert-danger">İşlem Başarısız :(</div>
  </Transition>
  <div>
    <button @click="newCompany" class="btn btn-info btn-sm mb-2">
      <i class="bi bi-plus"></i>
      Add New
    </button>
  </div>
  <div style="min-height: 500px !important">
    <div
      v-if="loading"
      style="min-height: 500px !important"
      class="d-flex justify-content-center align-items-center"
    >
      <div class="spinner-grow text-primary" role="status"></div>
      <!--spinner-->
    </div>
    <div v-else class="table-responsive">
      <table class="table table-striped" style="font-size: 0.8rem">
        <thead class="thead-dark">
          <tr>
            <th scope="col">Şirket Adı</th>
            <th scope="col">Durum</th>
            <th scope="col"></th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="c in companies" :key="c.id">
            <td>{{ c.companyName }}</td>
            <td>Active</td>
            <td>
              <button @click="updateCompany(c.id)">
                <i class="fas fa-pen ml-3" style="color: lightblue"></i>
              </button>
              <button @click="deleteCompany(c.id)">
                <i
                  class="fas fa-trash danger ml-3"
                  style="color: lightcoral"
                ></i>
              </button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
  <New ref="newModal" @success="newModalSuccess" />
  <DeleteConfirm ref="deleteModal" @yes="deleteOk" />
  <UpdateCompany ref="updateModal" @success="updateOk" />
</template>
<script>
import New from "./../modals/NewCompany.vue";
import DeleteConfirm from "./../modals/DeleteConfirm.vue";
import UpdateCompany from "./../modals/UpdateCompany.vue";
export default {
  data() {
    return {
      companies: [],
      loading: false,
      isSuccess: false,
      isFailed: false,
      selecetedId: null,
    };
  },
  components: {
    New,
    DeleteConfirm,
    UpdateCompany,
  },
  mounted() {
    this.isSuccess = true;
    this.load();
  },
  methods: {
    load() {
      this.isFailed = false;
      this.loading = true;
      this.isSuccess = false;
      setTimeout(() => {
        this.$ajax
          .get(`/api/management/admin/listCmp`)
          .then((response) => {
            this.companies = response.data;
            this.loading = false;
          })
          .catch((error) => {
            if (error.response.status == 401) {
              this.isFailed = true;
            }
          });
      }, 1000);
    },
    newCompany() {
      this.$refs.newModal.open();
    },
    newModalSuccess() {
      this.isSuccess = true;
      this.load();
      setTimeout(() => {
        this.isSuccess = false;
      }, 3000);
    },
    deleteCompany(id) {
      this.selecetedId = id;
      this.$refs.deleteModal.open();
    },
    deleteOk() {
      this.$ajax
        .delete(`/api/management/admin/delete/${this.selecetedId}`)
        .then((response) => {
          if (response) {
            this.isSuccess = true;
            this.load();
          }
        })
        .catch((error) => {
          if (error) {
            this.isFailed = true;
          }
        })
        .finally(() => {
          setTimeout(() => {
            this.isFailed = false;
            this.isSuccess = false;
          }, 3000);
        });
    },
    updateCompany(id) {
      this.$refs.updateModal.open(id);
    },
    updateOk() {
      this.isSuccess = true;
      this.load();
      setTimeout(() => {
        this.isSuccess = false;
      }, 3000);
    },
  },
};
</script>
<style scoped>
.table-responsive {
  display: block;
  width: 100%;
  overflow-x: auto;
  -webkit-overflow-scrolling: touch;
  cursor: pointer;
}
button {
  border: none !important;
  justify-items: center;
  align-content: center;
}
</style>
