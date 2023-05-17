using KeyInteractiveApiResponses;
using KiApiModels.ApiResponses;
using KiApiModels.Classes;
using KiApiModels.DTO;
using Newtonsoft.Json.Linq;
using System.Text.Json;
//using Newtonsoft.Json;
//using System.Net.Http.Json;
//using System.Text.Json;

namespace KiApiModels.ApiConsumer;

public class KiApiConsumer : IKiApiConsumer
{
    private HttpClient _ApiClient;

    private static readonly string baseUri = "https://localhost:7183/";

    //private static readonly string baseUri = "https://keyinteractiveapi.com/";

    public KiApiConsumer()
	{
        _ApiClient = new HttpClient();
        _ApiClient.DefaultRequestHeaders.Accept.Clear();
        _ApiClient.BaseAddress = new Uri(baseUri);
        _ApiClient.Timeout = TimeSpan.FromSeconds(20);
    }


    private void AuthorizationToken(string token)
    {
        _ApiClient.DefaultRequestHeaders.Clear();
        _ApiClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
    }

    /// <summary>
    /// Registra un nuovo utente Key Interactive
    /// </summary>
    /// <param name="userRegistration">UserRegistrationDto type of</param>
    /// <returns>APIRegistrationResponse</returns>
    public async Task<APIRegistrationResponse> RegisterUser(UserRegistrationDto userRegistration)
    {
        string apiEndpoint = $"User/RegisterUser";

        string url = $"{baseUri}{apiEndpoint}";

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, userRegistration))
        {
            return await response.Content.ReadAsAsync<APIRegistrationResponse>();
        }
    }

    /// <summary>
    /// Chiamata per effettuare il login
    /// </summary>
    /// <param name="userLoginDTO">UserLoginDTO typeOf</param>
    /// <returns>APILoginResponse -  se positivo data typeOf UserLoginResponse</returns>
    public async Task<APILoginResponse> LoginUser(UserLoginDTO userLoginDTO)
    {
        string apiEndpoint = $"User/LoginUser";

        string url = $"{baseUri}{apiEndpoint}";

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, userLoginDTO))
        {
            APILoginResponse dd = await response.Content.ReadAsAsync<APILoginResponse>();
            return dd;
        }
    }

    /// <summary>
    /// Chiamata per validare un codice OTP
    /// </summary>
    /// <param name="validateUserDTO">ValidateUserOtpDTO typeOf</param>
    /// <returns>KiApiResponseData</returns>
    public async Task<KiApiResponseData> ValidateUserSmsOTP(ValidateUserOtpDTO validateUserDTO, string token)
    {
        string apiEndpoint = $"User/ValidateUserSmsOTP";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, validateUserDTO))
        {
            return await response.Content.ReadAsAsync<KiApiResponseData>();   
        }
    }

    /// <summary>
    /// Chiamata per effettuare la validazione del token
    /// </summary>
    /// <param name="emailToken">Il token da validare</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> ValidateUserEmailToken(string emailToken)
    {
        string apiEndpoint = $"User/ValidateUserEmailToken?token={emailToken}";

        string url = $"{baseUri}{apiEndpoint}";


        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, new { }))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }

    /// <summary>
    /// Chiamata per richiedere un nuovo invio di un codice OTP
    /// </summary>
    /// <param name="userId">ID utente per cui richiedere un nuovo codice</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> RequestNewOTP(int userId, string token)
    {
        string apiEndpoint = $"User/RequestNewOTP?userId={userId}";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, new { }))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }

    /// <summary>
    /// Chiamata per richiedere un nuovo invio di Token
    /// </summary>
    /// <param name="userId">ID utente per cui richiedere un nuovo Token</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> RequestNewEmail(int userId, string token)
    {
        string apiEndpoint = $"User/RequestNewEmail?userId={userId}";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, new { }))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }

    /// <summary>
    /// Chiamata per ottenere i dati (telefono e email) dell'utente con la mascheratura di sicurezza
    /// </summary>
    /// <param name="userId">Id dell'utente per cui ottenere i dati</param>
    /// <returns>APIAuthContactsHiddenResponse</returns>
    public async Task<APIAuthContactsHiddenResponse> GetUserAuthContactsHidden(int userId, string token)
    {
        string apiEndpoint = $"User/GetUserAuthContactsHidden?userId={userId}";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.GetAsync(url))
        {
            return await response.Content.ReadAsAsync<APIAuthContactsHiddenResponse>();
        }
    }


    /// <summary>
    /// Chiamata per ottenere il cambio della password
    /// </summary>
    /// <param name="userCredentials">Email o username dell'utente per cui cambiare la password</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> PasswordForgot(string userCredentials, string token)
    {
        string apiEndpoint = $"User/PasswordForgot?userCredentials={userCredentials}";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, new { }))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }

    /// <summary>
    /// Chaiamata per cambiare il numero di telefono di un utente
    /// </summary>
    /// <param name="phoneDTO">UserChangePhoneDTO typeOf</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> ChangeUserPhone(UserChangePhoneDTO phoneDTO, string token)
    {
        string apiEndpoint = $"User/ChangeUserPhone";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, phoneDTO))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }

    

    /// <summary>
    /// Chiamata per modificare l'indirizzo email dell utente
    /// </summary>
    /// <param name="emailDTO">UserChangeEmailDTO typeOf</param>
    /// <returns>KiApiResponse</returns>
    public async Task<KiApiResponse> ChangeUserEmail(UserChangeEmailDTO emailDTO, string token)
    {
        string apiEndpoint = $"User/ChangeUserEmail";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.PostAsJsonAsync(url, emailDTO))
        {
            return await response.Content.ReadAsAsync<KiApiResponse>();
        }
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// Chiamata per ottenere un elenco di tutte le applicazioni KI
    /// </summary>
    /// <param name="token"></param>
    /// <returns>APIGetApplicationsResponse</returns>
    public async Task<APIGetApplicationsResponse> GetApplications(string token)
    {
        string apiEndpoint = $"Applications/GetApplications";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.GetAsync(url))
        {
            return await response.Content.ReadAsAsync<APIGetApplicationsResponse>();
        }
    }

    /// <summary>
    /// Chiamata per ottenere un elenco di tutte le applicazioni KI e i dati di quelle possedute da un utente
    /// </summary>
    /// <param name="userId">Id dell'utente per cui eseguire il raffront</param>
    /// <param name="token"></param>
    /// <returns>APIUserApplicationsResponse</returns>
    public async Task<APIUserApplicationsResponse> GetUserApplications(int userId, string token)
    {
        string apiEndpoint = $"Applications/GetUserApplications?userId={userId}";

        string url = $"{baseUri}{apiEndpoint}";

        AuthorizationToken(token);

        using (HttpResponseMessage response = await _ApiClient.GetAsync(url))
        {
            return await response.Content.ReadAsAsync<APIUserApplicationsResponse>();
        }
    }
}
