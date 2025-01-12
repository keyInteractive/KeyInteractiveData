using KiApiModels.ApiResponses;
using KiApiModels.DTO;

namespace KiApiModels.ApiConsumer;

public interface IKiApiConsumer
{
    /// <summary>
    /// Registra un nuovo utente Key Interactive
    /// </summary>
    /// <param name="userRegistration">UserRegistrationDto type of</param>
    /// <returns>KiApiResponseData</returns>
    Task<APIRegistrationResponse> RegisterUser(UserRegistrationDto userRegistration);

    /// <summary>
    /// Chiamata per effettuare il login
    /// </summary>
    /// <param name="userLoginDTO">UserLoginDTO typeOf</param>
    /// <returns>KiApiResponseData -  se positivo data typeOf UserLoginResponse</returns>
    Task<APILoginResponse> LoginUser(UserLoginDTO userLoginDTO);

    /// <summary>
    /// Chiamata per validare un codice OTP
    /// </summary>
    /// <param name="validateUserDTO">ValidateUserOtpDTO typeOf</param>
    /// <returns>KiApiResponseData</returns>
    Task<KiApiResponseData> ValidateUserSmsOTP(ValidateUserOtpDTO validateUserDTO, string token);

    /// <summary>
    /// Chiamata per effettuare la validazione del token
    /// </summary>
    /// <param name="token">Il token da validare</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> ValidateUserEmailToken(string token);

    /// <summary>
    /// Chiamata per richiedere un nuovo invio di un codice OTP
    /// </summary>
    /// <param name="userId">ID utente per cui richiedere un nuovo codice</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> RequestNewOTP(int userId, string token);

    /// <summary>
    /// Chiamata per ottenere i dati (telefono e email) dell'utente con la mascheratura di sicurezza
    /// </summary>
    /// <param name="userId">Id dell'utente per cui ottenere i dati</param>
    /// <returns>APIAuthContactsHiddenResponse</returns>
    Task<APIAuthContactsHiddenResponse> GetUserAuthContactsHidden(int userId, string token);

    /// <summary>
    /// Chiamata per ottenere il cambio della password
    /// </summary>
    /// <param name="userCredentials">Email o username dell'utente per cui cambiare la password</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> PasswordForgot(string userCredentials, string token);

    /// <summary>
    /// Chaiamata per cambiare il numero di telefono di un utente
    /// </summary>
    /// <param name="phoneDTO">UserChangePhoneDTO typeOf</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> ChangeUserPhone(UserChangePhoneDTO phoneDTO, string token);

    /// <summary>
    /// Chiamata per richiedere un nuovo invio di Token
    /// </summary>
    /// <param name="userId">ID utente per cui richiedere un nuovo Token</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> RequestNewEmail(int userId, string token);

    /// <summary>
    /// Chiamata per modificare l'indirizzo email dell utente
    /// </summary>
    /// <param name="emailDTO">UserChangeEmailDTO typeOf</param>
    /// <returns>KiApiResponse</returns>
    Task<KiApiResponse> ChangeUserEmail(UserChangeEmailDTO emailDTO, string token);



    ////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Chiamata per ottenere un elenco di tutte le applicazioni KI
    /// </summary>
    /// <param name="token"></param>
    /// <returns>APIGetApplicationsResponse</returns>
    Task<APIGetApplicationsResponse> GetApplications(string token);

    /// <summary>
    /// Chiamata per ottenere un elenco di tutte le applicazioni KI e i dati di quelle possedute da un utente
    /// </summary>
    /// <param name="userId">Id dell'utente per cui eseguire il raffront</param>
    /// <param name="token"></param>
    /// <returns>APIUserApplicationsResponse</returns>
    Task<APIUserApplicationsResponse> GetUserApplications(int userId, string token);


}
