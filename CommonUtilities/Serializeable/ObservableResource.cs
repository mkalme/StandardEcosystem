using System;

namespace CommonUtilities {
    public abstract class ObservableResource {
        public event EventHandler OnContentsChanged;

        private bool _updateModeActivated = false;
        private bool _updateOccured = false;

        protected void RaiseOnContentsChanged() {
            if (_updateModeActivated) {
                _updateOccured = true;
            } else {
                OnContentsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void ApplyUpdateMode() {
            _updateModeActivated = true;
        }
        public void SuspendUpdateMode() {
            _updateModeActivated = false;

            if (_updateOccured) {
                _updateOccured = false;

                RaiseOnContentsChanged();
            }
        }
    }
}
