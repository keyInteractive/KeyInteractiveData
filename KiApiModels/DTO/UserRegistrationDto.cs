using KiApiModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace KiApiModels.DTO;

/// <summary>
/// User registration Data Transfer Object
/// </summary>
public class UserRegistrationDto : IValidatableObject
{
    /// <summary>
    /// Nome
    /// </summary>
    [Required]
    [MinLength(2)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Cognome
    /// </summary>
    [Required]
    [MinLength(2)]
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// Nome utente
    /// </summary>
    [Required]
    [MinLength(2)]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Data di nascita
    /// </summary>
    [Required, DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

    /// <summary>
    /// Indirizzo email dell'utente
    /// </summary>
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Il prefisso del telefono
    /// </summary>
    [Required]
    public string PhonePrefix { get; set; } = string.Empty;

    /// <summary>
    /// Telefono
    /// </summary>
    [Required, Phone]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Indirizzo
    /// </summary>
    [Required]
    public string Adress { get; set; } = string.Empty;


    /// <summary>
    /// Citta
    /// </summary>
    [Required]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Provincia
    /// </summary>
    [Required]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Stato
    /// </summary>
    [Required]
    public EState State { get; set; }

    /// <summary>
    /// Codice postale
    /// </summary>
    [Required]
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    /// Password
    /// </summary>
    //[Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters"), PasswordPropertyText]
    [Required, StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Controllo password
    /// </summary>
    [Required, Compare("Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; } = string.Empty;

    /// <summary>
    /// La tipologia di utente
    /// </summary>
    [Required]
    public ETipoUtente UserType { get; set; } = ETipoUtente.Utente;

    /// <summary>
    /// Contiene il codice del cliente - Solo valido se l'utente è un cliente
    /// </summary>
    public string CustomerCode { get; set; } = string.Empty;





    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Name == Surname) yield return new ValidationResult("Name and Surname should not be the same!", new[] { "Name" });

        if (DateOfBirth > DateTime.Now.AddYears(-1)) yield return new ValidationResult("Are you shure about youre birth date? You are kind of young..", new[] { "DateOfBirth" });

        if (DateOfBirth == new DateTime(0001, 01, 01)) yield return new ValidationResult("Are you shure about youre birth date? You are kind of old..", new[] { "DateOfBirth" });

        if(UserType == ETipoUtente.Cliente && string.IsNullOrWhiteSpace(CustomerCode)) yield return new ValidationResult("You need to specify the Client code", new[] { "CodiceCliente" });
    }

  
}
