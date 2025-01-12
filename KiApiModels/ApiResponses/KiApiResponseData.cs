using System.Net;

namespace KiApiModels.ApiResponses;

/// <summary>
/// Classe per le risposte delle API di key interactive con un oggetto (T) nella risposta
/// </summary>
public class KiApiResponseData : KiApiResponse
{
    /// <summary>
    /// In caso di risposta positiva contiene object (T) contenente i dati restituiti
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Risposta standard per operazione andata a buon fine
    /// </summary>
    /// <param name="data">Il dato restiruito dall API</param>
    /// <param name="successMessage">Messaggio di risposta facoltativo</param>
    /// <returns>KiApiResponseData</returns>
    public new static KiApiResponseData SuccessResponse(object data, string successMessage = "") => new KiApiResponseData { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, Data = data };

    /// <summary>
    /// Risposta standard per operazione non andata a buon fine
    /// </summary>
    /// <param name="errorCode">Il codice di errore HTTP restituito</param>
    /// <param name="errorMessage">Il messaggio di errore user friendly</param>
    /// <returns></returns>
    public new static KiApiResponseData ErrorResponse(HttpStatusCode errorCode, string errorMessage) => new KiApiResponseData { Success = false, ResponseCode = errorCode, ErrorMessage = errorMessage, Data = null };
}
