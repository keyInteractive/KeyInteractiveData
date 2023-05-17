using System.ComponentModel.DataAnnotations;

namespace KiApiModels.DTO;

public class ValidateUserOtpDTO
{
    /// <summary>
    /// Username
    /// </summary>
    [Required]
    public int ID { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [Required,]
    public byte[] OTP { get; set; }

    /// <summary>
    /// User login Data Transfer Object
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    public ValidateUserOtpDTO(int id, byte[] otp)
    {
        ID = id;
        OTP = otp;
    }
}
