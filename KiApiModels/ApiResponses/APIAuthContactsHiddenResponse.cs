using KeyInteractiveApiResponses;
using KiApiModels.Classes;
using System.Net;

namespace KiApiModels.ApiResponses;

public class APIAuthContactsHiddenResponse : KiApiResponse
{
    public AuthContactsHidden HiddenContacts { get; set; }

    public static APIAuthContactsHiddenResponse SuccessResponse(AuthContactsHidden data, string successMessage = "") => new APIAuthContactsHiddenResponse { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, HiddenContacts = data };
}
