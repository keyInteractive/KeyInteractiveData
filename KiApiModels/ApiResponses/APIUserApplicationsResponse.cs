using KiApiModels.Classes;
using System.Net;

namespace KiApiModels.ApiResponses;

public class APIUserApplicationsResponse : KiApiResponse
{
    public IEnumerable<KiUserOwnedApplications> Applications { get; set; }

    public static APIUserApplicationsResponse SuccessResponse(IEnumerable<KiUserOwnedApplications> data, string successMessage = "") => new APIUserApplicationsResponse { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, Applications = data };
}
