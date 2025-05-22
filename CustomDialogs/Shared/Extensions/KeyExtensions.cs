using System;
using System.Collections.Generic;

namespace CustomDialogs {
    public static class KeyExtensions {
        public static Func<string, bool> KeyValidator { get; } = key => {
            if (key.Length != 32) {
                CustomDialog.ShowError("Error", "The key doesn't have valid length.");
                return false;
            }

            return ValidateText(key);
        };

        public static string ValidCharacters { get; } = " !#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

        public static bool KeyEquals(this byte[] key, byte[] other) {
            if (key.Length != other.Length) return false;

            for (int i = 0; i < key.Length; i++) {
                if (key[i] != other[i]) return false;
            }

            return true;
        }
        public static bool ValidateText(this string text) {
            HashSet<char> set = new HashSet<char>(text);
            set.UnionWith(new HashSet<char>(ValidCharacters));

            if (set.Count > ValidCharacters.Length) {
                CustomDialog.ShowError("Invalid characters",
                    $"Password contains invalid characters. Only the following characters are allowed: \n{KeyExtensions.ValidCharacters}");
                return false;
            }

            return true;
        }
    }
}
