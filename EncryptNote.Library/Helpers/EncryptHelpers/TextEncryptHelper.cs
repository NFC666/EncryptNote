using System.Security.Cryptography;
namespace EncryptNote.Library.Helpers.EncryptHelpers;

public static class TextEncryptHelper
{
    public static string Encrypt(string plainText, byte[] key, byte[] iv)
    { 
        byte[] cipherText;
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    cipherText = ms.ToArray();
                }
            }
        }
        return Convert.ToBase64String(cipherText);
    }
}