using Microsoft.Owin.Security.Provider;

namespace Microsoft.Owin.Security.LinkedIn
{
    public class LinkedInReturnEndpointContext : ReturnEndpointContext
    {
        public LinkedInReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}
