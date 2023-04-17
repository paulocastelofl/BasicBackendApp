using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CasteloChurch.Infra.CrossCutting
{
    public class EncryptDecrypt
    {
        private static byte[] _chave = Encoding.UTF8.GetBytes("key_password_strong");
        private static byte[] _iv = Encoding.UTF8.GetBytes("2314345645678765");

        public string EncryptString(string plainText)
        {
            //SHA256 mySHA256 = SHA256Managed.Create();
            using var hashMD5 = new MD5CryptoServiceProvider();
            var keyHash = hashMD5.ComputeHash(_chave);
            var keyHashString = Convert.ToHexString(keyHash);
            byte[] key = Encoding.UTF8.GetBytes(keyHashString.ToLower()); //keyHash;

            // Instantiate a new Aes object to perform string symmetric encryption
            AesCryptoServiceProvider encryptor = new AesCryptoServiceProvider();

            encryptor.Mode = CipherMode.CBC;
            encryptor.KeySize = 256;
            encryptor.BlockSize = 128;
            encryptor.Padding = PaddingMode.PKCS7;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = _iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Convert the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Return the encrypted data as a string
            return cipherText;// DecryptString(cipherText);
        }

        public string DecryptString(string cipherText)//, byte[] key, byte[] iv)
        {
            try
            {
                // Create sha256 hash
                //SHA256 mySHA256 = SHA256Managed.Create();
                using var hashMD5 = new MD5CryptoServiceProvider();
                var keyHash = hashMD5.ComputeHash(_chave);
                var keyHashString = Convert.ToHexString(keyHash);
                byte[] key = Encoding.UTF8.GetBytes(keyHashString.ToLower()); //keyHash;

                // Instantiate a new Aes object to perform string symmetric encryption
                AesCryptoServiceProvider encryptor = new AesCryptoServiceProvider();

                encryptor.Mode = CipherMode.CBC;
                encryptor.KeySize = 256;
                encryptor.BlockSize = 128;
                encryptor.Padding = PaddingMode.PKCS7;

                // Set key and IV
                encryptor.Key = key;
                encryptor.IV = _iv;

                // Instantiate a new MemoryStream object to contain the encrypted bytes
                MemoryStream memoryStream = new MemoryStream();

                // Instantiate a new encryptor from our Aes object
                ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

                // Instantiate a new CryptoStream object to process the data and write it to the 
                // memory stream
                CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

                // Will contain decrypted plaintext
                string plainText = string.Empty;

                try
                {
                    // Convert the ciphertext string into a byte array
                    byte[] cipherBytes = Convert.FromBase64String(cipherText);

                    // Decrypt the input ciphertext string
                    cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                    // Complete the decryption process
                    cryptoStream.FlushFinalBlock();

                    // Convert the decrypted data from a MemoryStream to a byte array
                    byte[] plainBytes = memoryStream.ToArray();

                    // Convert the decrypted byte array to string
                    plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
                }
                finally
                {
                    // Close both the MemoryStream and the CryptoStream
                    memoryStream.Close();
                    cryptoStream.Close();
                }

                // Return the decrypted data as a string
                return plainText;
            }
            catch
            {
                return cipherText;
            }

        }
    }
}
