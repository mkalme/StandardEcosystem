using System;
using System.Linq;

namespace CustomDialogs {
    public class KeyGenerator : IPasswordGenerator {
        public bool SetLength => true;
        public string Format => "ASCII Format";

        public string Generate(int length) {
            byte[] bytes = PasswordGenerator.GenerateBytes(25);

            char[] output = new string(' ', 32).ToArray();

            int index = 0;
            for (int i = 0; i < 25; i++) {
                output[index] = CreateChar(bytes[i]);

                index++;
                if ((i + 1) % 3 == 0 && i != 23) index++;
            }

            return new string(output);
        }

        private static char CreateChar(byte value) {
            value %= 36;

            if (value < 10) return (char)('0' + value);
            return (char)('A' + (value - 10));
        }
    }
}
