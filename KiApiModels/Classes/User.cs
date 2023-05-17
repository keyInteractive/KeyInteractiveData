using KiApiModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace KiApiModels.Classes;

public  class User
{
    /// <summary>
    /// ID dell'utente
    /// </summary>
    [Required]
    public int ID { get; set; }

    /// <summary>
    /// Nome
    /// </summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Cognome
    /// </summary>
    [Required]
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// Nome utente
    /// </summary>
    [Required]
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
    /// Ruolo dell'utente
    /// </summary>
    [Required]
    public EUserRole Role { get; set; }

    /// <summary>
    /// Id Dell'utente su stripe necessario per i pagamenti
    /// </summary>
    public string StripeID { get; set; }

    /// <summary>
    /// Tipologia dell'utente
    /// </summary>
    public ETipoUtente UserType { get; set; } = ETipoUtente.Utente;

    /// <summary>
    /// Contiene il codice del cliente - Solo valido se l'utente è un cliente
    /// </summary>
    public string CustomerCode { get; set; } = string.Empty;
}
