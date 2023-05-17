using System.ComponentModel.DataAnnotations;

namespace KiApiModels.DTO;

public class UserChangePhoneDTO
{
    [Required]
    public int UserId { get; set; }

    [Required]
    public string PhonePrefix { get; set; } = string.Empty;

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }
}
