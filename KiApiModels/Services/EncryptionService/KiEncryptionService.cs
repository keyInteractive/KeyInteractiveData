using System.Security.Cryptography;

namespace KiApiModels.Services.EncryptionService;

public class KiEncryptionService : IKiEncryptionService
{
    //32 byte
    private readonly byte[] _encryptionKey = System.Text.Encoding.UTF8.GetBytes("ViJdWTxUOet6lDMSObj3c4BjhDTeP3BV");

    //16 bite
    private readonly byte[] _IV = System.Text.Encoding.UTF8.GetBytes("ViJdWTxUOet6lDMS");

    /// <summary>
    /// Esegue la criptazione di una string
    /// </summary>
    /// <param name="plainString">Stringa da criptare</param>
    /// <returns> Byte[] criptati della stringa passat</returns>
    public byte[] Encrypt(string plainString)
    {
        byte[] encrypted;

        // Create an Aes object
        // with the specified key and IV.
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = _encryptionKey;
            aesAlg.IV = _IV;

            // Create an encryptor to perform the stream transform.
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(plainString);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        return encrypted;
    }

    /// <summary>
    /// Decripta una stringa criptata
    /// </summary>
    /// <param name="encrypetdByte">Valore criptato da decriptare</param>
    /// <returns>la stringa dell oggetto criptato</returns>
    public string? Decrypt(byte[] encrypetdByte)
    {
        // Declare the string used to hold
        // the decrypted text.
        string? plaintext = null;

        // Create an Aes object
        // with the specified key and IV.
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = _encryptionKey;
            aesAlg.IV = _IV;

            // Create a decryptor to perform the stream transform.
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(encrypetdByte))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {

                        // Read the decrypted bytes from the decrypting stream
                        // and place them in a string.
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        return plaintext;
    }
}
