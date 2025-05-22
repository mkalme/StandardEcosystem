using System;

namespace CustomDialogs {
    public class Base64StringPasswordGenerator : IPasswordGenerator {
        public bool SetLength => false;
        public string Format => "Base64 String";

        public string Generate(int length) {
            return Convert.ToBase64String(PasswordGenerator.GenerateBytes(length));
        }
    }
}
