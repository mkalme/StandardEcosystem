using System;

namespace CustomDialogs {
    public readonly struct InputResult<TValue> {
        public TValue Value { get; }
        public bool DialogClosed { get; }

        public InputResult(TValue value, bool dialogClosed) {
            Value = value;
            DialogClosed = dialogClosed;
        }
    }
}
