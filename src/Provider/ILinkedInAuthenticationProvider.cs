using System.Threading.Tasks;

namespace OwinContrib.Security.LinkedIn
{
    public interface ILinkedInAuthenticationProvider
    {
        Task Authenticated(LinkedInAuthenticatedContext context);
        Task ReturnEndpoint(LinkedInReturnEndpointContext context);
    }
}
