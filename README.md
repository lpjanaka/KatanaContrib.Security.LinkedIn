### OwinContrib.Security.LinkedIn
**OwinContrib.Security.LinkedIn** is an OWIN (Katana) middleware that enables an application to support LinkedIn OAuth 2.0 authentication workflow.

#### Getting Started
- Install the [OwinContrib.Security.LinkedIn](https://www.nuget.org/packages/OwinContrib.Security.LinkedIn) Nuget Package
```
        PM> Install-Package OwinContrib.Security.LinkedIn 
```
- Call the UseLinkedInAuthentication method on the IAppBuilder object that is registered and used in the app
```csharp
public void ConfigureAuth(IAppBuilder app)
{
    //custom code...

    app.UseLinkedInAuthentication(
        apiKey: "YOUR_APP_API_KEY",
        secretKey: "YOUR_APP_SECRET_KEY");
                    
    //more custom code...
}
```
Or you can create a LinkedInAuthenticationOptions object and pass it as a param:
```csharp
public void ConfigureAuth(IAppBuilder app)
{
    //custom code...

    app.UseLinkedInAuthentication(new LinkedInAuthenticationOptions()
    {
        AppId = "YOUR_APP_API_KEY",
        AppSecret = "YOUR_APP_SECRET_KEY",
        Scope = new List<string>() {"r_fullprofile", "r_emailaddress"}, 
    });
                    
    //more custom code...
}
```
