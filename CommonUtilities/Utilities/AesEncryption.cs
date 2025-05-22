using System;
using System.IO;
using System.Security.Cryptography;

namespace CommonUtilities {
    public static class AesEncryption {
        public static void Encrypt(Stream input, Stream output, byte[] key) {
            using (Aes aesAlg = Aes.Create()) {
                aesAlg.Key = key;
                aesAlg.GenerateIV();

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (CryptoStream stEncryptor = new CryptoStream(output, encryptor, CryptoStreamMode.Write, true)) {
                    output.Write(aesAlg.IV, 0, 16);

                    input.CopyTo(stEncryptor);
                    stEncryptor.FlushFinalBlock();
                }
            }
        }
        public static void Decrypt(Stream input, Stream output, byte[] key) {
            using (Aes aesAlg = Aes.Create()) {
                aesAlg.Key = key;

                byte[] iv = new byte[16];
                input.Read(iv, 0, iv.Length);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (CryptoStream stDecryptor = new CryptoStream(input, decryptor, CryptoStreamMode.Read, true)) {
                    stDecryptor.CopyTo(output);
                    stDecryptor.Flush();
                }
            }
        }
    }
}
