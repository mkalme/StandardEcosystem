using System;

namespace CustomDialogs {
    public static class IntExtensions {
        public static int Clamp(this int value, int min, int max) {
            return value < min ? min : value > max ? max : value;
        }
    }
}
