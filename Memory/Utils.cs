using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Security.Cryptography;

namespace Memory
{
    class Utils
    {
        
        public static Random rand = new Random();
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static List<T> ShuffleList<T>(List<T> items)
        {
            items = items.OrderBy(x => rand.Next()).ToList();
            return items;
        }

        /// <summary>
        /// convert een array naar een string door deze te serializen met de soapformatter
        /// </summary>
        /// <param name="ar">input array</param>
        /// <returns>een array in een string</returns>
        public static string ArrayToString(Array ar) //convert alle soorten arrays naar 1 string
        {
            using (MemoryStream ms = new MemoryStream())
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(ms, ar);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
        /// <summary>
        /// convert een array in een string terug naar een array
        /// </summary>
        /// <param name="s">input array in string</param>
        /// <returns>een array</returns>
        public static object StringToArray(string s)  //convert string terug naar array
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(s)))
            {
                SoapFormatter formatter = new SoapFormatter();
                return formatter.Deserialize(ms) as Array;
            }
        }


        //string encryption begint hier
       

        // This constant is used to determine the keysize of the encryption algorithm in bits.
        // We divide this by 8 within the code below to get the equivalent number of bytes.
        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        /// <summary>
        /// code van CraigTP
        /// https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
        /// encrypt een string met een wachtwoord. uit dit wachtwoord word een salt en een iv gehaald die worden geprepend in de encryptie. zodat zelfs met het zelfde wachtwoord de encryptie nooit het zelfde output heeft.
        /// </summary>
        /// <param name="plainText"> de string die je wilt encrypten</param>
        /// <param name="passPhrase"> het wachtwoord voor de encryptie</param>
        /// <returns>encrypted string</returns>
        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// code van CraigTP
        /// https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
        /// decrypt een geëncrypte string met een wachtwoord. haalt de salt en de iv eerst uit de encryption omdaarmee vervolgens de rest met het wachtwoord te decrypten.
        /// </summary>
        /// <param name="cipherText">input geencrypte string om te deencypten</param>
        /// <param name="passPhrase"> het wachtwoord</param>
        /// <returns>decrypted string</returns>
        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// code van CraigTP
        /// https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
        /// genereerd 256 cryptoveilge random bits voor gebruik in de encrypt methode
        /// </summary>
        /// <returns>256 bits</returns>
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
    


       