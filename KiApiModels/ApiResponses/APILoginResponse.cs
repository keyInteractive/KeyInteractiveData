using KiApiModels.Classes;
using System.Net;

namespace KiApiModels.ApiResponses;

public class APILoginResponse : KiApiResponse
{
    public UserLoginResponse LoginResponse { get; set; }

    public static APILoginResponse SuccessResponse(UserLoginResponse data, string successMessage = "") => new APILoginResponse { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, LoginResponse = data };

    public static APILoginResponse ErrorResponse(HttpStatusCode statusCode, string errorMessage) => new APILoginResponse { Success = false, ResponseCode = statusCode, ErrorMessage = errorMessage };
}
