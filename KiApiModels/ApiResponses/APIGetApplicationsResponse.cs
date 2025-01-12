using KiApiModels.Classes;
using System.Net;

namespace KiApiModels.ApiResponses;

public class APIGetApplicationsResponse :KiApiResponse
{
    public IEnumerable<KiApplications> Applications { get; set; }

    public static APIGetApplicationsResponse SuccessResponse(IEnumerable<KiApplications> data, string successMessage = "") => new APIGetApplicationsResponse { Success = true, ResponseCode = HttpStatusCode.OK, SuccessMessage = successMessage, Applications = data };
}
