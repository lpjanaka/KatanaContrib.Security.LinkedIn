using System.Threading.Tasks;

namespace Microsoft.Owin.Security.LinkedIn
{
    public interface ILinkedInAuthenticationProvider
    {
        Task Authenticated(LinkedInAuthenticatedContext context);
        Task ReturnEndpoint(LinkedInReturnEndpointContext context);
    }
}
