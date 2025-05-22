using System;
using System.Security.Cryptography;

namespace CustomDialogs {
    public static class PasswordGenerator {
        public static byte[] GenerateBytes(int length) {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider()) {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);

                return tokenBuffer;
            }
        }
    }
}
