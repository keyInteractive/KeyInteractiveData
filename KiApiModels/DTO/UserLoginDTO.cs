using System.ComponentModel.DataAnnotations;

namespace KiApiModels.DTO;

public class UserLoginDTO
{
    /// <summary>
    /// Username o email per fare il login
    /// </summary>
    [Required]
    public string LoginCredentials { get; set; } = string.Empty;

    /// <summary>
    /// La password criptata
    /// </summary>
    [Required,]
    public byte[] Password { get; set; }

    /// <summary>
    /// User login Data Transfer Object
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    public UserLoginDTO(string loginCredentials, byte[] password)
    {
        LoginCredentials = loginCredentials;
        Password = password;
    }
}
