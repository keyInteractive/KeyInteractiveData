using System.ComponentModel.DataAnnotations;

namespace KiApiModels.DTO;

public class UserChangeEmailDTO
{
    [Required]
    public int UserId { get; set; }

    [Required]
    [EmailAddress]
    public string EmailAdress { get; set; } = string.Empty;
}
