window.bootstrapInterop = {
  showModal: modalId => {
    const modalElement = document.querySelector(modalId);
    const modal = new bootstrap.Modal(modalElement);
    modal.show();
  },
  enableTooltips: () => {
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
    [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl));
  },
};
