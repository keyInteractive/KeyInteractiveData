using System.Net;

namespace KiApiModels.ApiResponses;

/// <summary>
/// Classe per le risposte delle API di key interactive
/// </summary>
public class KiApiResponse
{
    /// <summary>
    /// Indica se la risposta è positiva oppure se c'è stato un errore
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// In caso di errore restituisce il messaggio di errore generato dall endpoint
    /// </summary>
    public string SuccessMessage { get; set; } = string.Empty;

    /// <summary>
    /// Resrituisce il codice di risposta alla chiamata HTTP
    /// </summary>
    public HttpStatusCode? ResponseCode { get; set; }

    /// <summary>
    /// In caso di errore restituisce il messaggio di errore generato dall endpoint
    /// </summary>
    public string ErrorMessage { get; set; } = string.Empty;


    /// <summary>
    /// Risposta standard per operazione andata a buon fine
    /// </summary>
    /// <param name="successMessage">Messaggio di risposta facoltativo</param>
    /// <returns>KiApiResponse</returns>
    public static KiApiResponse SuccessResponse(string successMessage = "") => new KiApiResponse { Success = true, SuccessMessage = successMessage, ResponseCode = HttpStatusCode.OK };

    /// <summary>
    /// Risposta standard per operazione non andata a buon fine
    /// </summary>
    /// <param name="errorCode">Il codice di errore HTTP restituito</param>
    /// <param name="errorMessage">Il messaggio di errore user friendly</param>
    /// <returns>KiApiResponse</returns>
    public static KiApiResponse ErrorResponse(HttpStatusCode errorCode, string errorMessage) => new KiApiResponse { Success = false, ResponseCode = errorCode, ErrorMessage = errorMessage };
}
