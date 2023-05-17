using KiApiModels.Enums;
using static KiApiModels.DTO.UserRegistrationDto;
using System.ComponentModel.DataAnnotations;

namespace KiApiModels.Classes;

public class DbUser : User
{
    /// <summary>
    /// Hash della password
    /// </summary>
    public byte[] PasswordHash { get; set; } = new byte[32];

    /// <summary>
    /// Salt della password
    /// </summary>
    public byte[] PasswordSalt { get; set; } = new byte[32];

    //EMAIL VERIFICATION

    /// <summary>
    /// Token di verifica dell' indirizzo email
    /// </summary>
    public string? EmailVerificationToken { get; set; }

    /// <summary>
    /// Data fine validità token di verifica dell' indirizzo email
    /// </summary>
    public DateTime? EmailVerificationTokenExpires { get; set; }

    /// <summary>
    /// Data dell'avvenuta verifica dell' indirizzo email
    /// </summary>
    public DateTime? EmailVerifiedAt { get; set; }

    /// <summary>
    /// Se è avvenuta o meno la verifica dell' indirizzo email
    /// </summary>
    public bool EmailVerified { get; set; }

    //SMS VERIFICATION

    /// <summary>
    /// Token di verifica del numero di telefono
    /// </summary>
    public int? SmsVerificationToken { get; set; }

    /// <summary>
    /// Data fine validità token di verifica del numero di telefono
    /// </summary>
    public DateTime? SmsVerificationTokenExpires { get; set; }

    /// <summary>
    /// Data dell'avvenuta verifica del numero di telefono
    /// </summary>
    public DateTime? SmsVerifiedAt { get; set; }

    /// <summary>
    /// Se è avvenuta o meno la verifica dell numero di telefono
    /// </summary>
    public bool SmsVerified { get; set; }

    //PASSWORD RESET

    /// <summary>
    /// Token per il reset della password
    /// </summary>
    public string? PasswordResetToken { get; set; }

    /// <summary>
    /// Data di scadenza del toke di reset password
    /// </summary>
    public DateTime? ResetTokenExpires { get; set; }

    /// <summary>
    /// La data di creazione dell'utente
    /// </summary>
    public DateTime? CreationDate { get; set; }

    
}
