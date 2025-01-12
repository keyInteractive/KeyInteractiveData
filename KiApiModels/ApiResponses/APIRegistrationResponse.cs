using KiApiModels.Classes;
using System.Net;

namespace KiApiModels.ApiResponses;

public class APIRegistrationResponse : KiApiResponse
{
    public UserRegistrationResponse RegistrationResponse { get; set; }

    public static APIRegistrationResponse SuccessResponse(UserRegistrationResponse data, string successMessage = "") => new APIRegistrationResponse { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, RegistrationResponse = data };
}
