namespace KiApiModels.Classes;

/// <summary>
/// Classe di risposta ad una richiesta di login positiva
/// </summary>
public class UserLoginResponse
{
    /// <summary>
    /// Se il login ha avuto o meno successo
    /// </summary>
    public bool LoginSuccess { get; set; }

    /// <summary>
    /// Se il codice OTP è statao verificato
    /// </summary>
    public bool OTPVerified { get; set; }

    /// <summary>
    /// Se l'email è stata verificata
    /// </summary>
    public bool EmailVerified { get; set; }

    /// <summary>
    /// L'ID dell'utente che ha effettuato il login
    /// </summary>
    public int UserID { get; set; }

    /// <summary>
    /// Il toke creato al login
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// L'utente che ha effettuato il login
    /// </summary>
    public User ActiveUser { get; set; }
}
