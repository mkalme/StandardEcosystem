using System;

namespace CustomDialogs {
    public class AsciiStringPasswordGenerator : IPasswordGenerator {
        public bool SetLength => false;
        public string Format => "ASCII Format";

        public string Generate(int length) {
            char[] output = new char[length];

            int index = 0;
            while (index < length) {
                byte b = PasswordGenerator.GenerateBytes(1)[0];

                if (b < (256 / KeyExtensions.ValidCharacters.Length * KeyExtensions.ValidCharacters.Length)) {
                    output[index++] = KeyExtensions.ValidCharacters[b % KeyExtensions.ValidCharacters.Length];
                }
            }

            return new string(output);
        }
    }
}
