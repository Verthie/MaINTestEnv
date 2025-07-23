window.bootstrapInterop = {
  showModal: modalId => {
    const modalElement = document.querySelector(modalId);
    const modal = new bootstrap.Modal(modalElement);
    modal.show();
  },
};
