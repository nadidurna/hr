<template>
  <div
    class="modal fade"
    id="deleteModal"
    tabindex="-1"
    aria-labelledby="deleteModalLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="deleteModalLabel">Danger Zone!</h5>
          <button
            class="close"
            type="button"
            data-dismiss="modal"
            aria-label="Close"
          >
            <span aria-hidden="true">×</span>
          </button>
        </div>
        <div class="modal-body">Silmek istediğinize emin misiniz ?</div>
        <div class="modal-footer">
          <button class="btn btn-secondary" type="button" data-dismiss="modal">
            Kapat
          </button>
          <button @click="confirm" type="button" class="btn btn-danger">
            Delete
          </button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  emits: ["yes"],
  name: "DeleteConfirm",
  data() {
    return {
      instance: null,
    };
  },
  mounted() {
    this.instance = new bootstrap.Modal(document.getElementById("deleteModal"));
  },
  methods: {
    confirm() {
      this.$emit("yes");
      this.instance.hide();
    },
    open() {
      this.instance.show();
    },
  },
};
</script>
<style scoped></style>
