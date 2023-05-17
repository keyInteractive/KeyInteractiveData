using System.Security.Cryptography;

namespace KiApiModels.Services.EncryptionService;

public interface IKiEncryptionService
{
    /// <summary>
    /// Esegue la criptazione di una string
    /// </summary>
    /// <param name="plainString">Stringa da criptare</param>
    /// <returns> Byte[] criptati della stringa passat</returns>
    byte[] Encrypt(string plainString);

    /// <summary>
    /// Decripta una stringa criptata
    /// </summary>
    /// <param name="encrypetdByte">Valore criptato da decriptare</param>
    /// <returns>la stringa dell oggetto criptato</returns>
    string? Decrypt(byte[] encrypetdByte);

}
