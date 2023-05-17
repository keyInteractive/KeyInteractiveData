using KeyInteractiveApiResponses;

namespace KiApiModels.Classes;

public class UserRegistrationResponse
{
    /// <summary>
    /// Il toke creato alla registrazione
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// L'utente che ha effettuato la registrazione
    /// </summary>
    public User ActiveUser { get; set; }
}
