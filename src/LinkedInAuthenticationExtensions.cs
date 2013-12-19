using System;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.LinkedIn;

namespace Owin
{    
    public static class LinkedInAuthenticationExtensions
    {       
        public static IAppBuilder UseLinkedInAuthentication(this IAppBuilder app, LinkedInAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(LinkedInAuthenticationMiddleware), app, options);
            return app;
        }

        public static IAppBuilder UseLinkedInAuthentication(
            this IAppBuilder app,
            string APIKey,
            string SecretKey)
        {
            return UseLinkedInAuthentication(
                app,
                new LinkedInAuthenticationOptions
                {
                    AppId = APIKey,
                    AppSecret = SecretKey
                });
        }
    }
}
