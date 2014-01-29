KatanaContrib.Security.Linkedin
=============================

**OwinContrib.Security.LinkedIn** provides a owin/[katana](http://katanaproject.codeplex.com/) middleware that supports the LinkedIn authentication flow. 
In order to add it to your project or solution run the `Install-Package KatanaContrib.Security.LinkedIn` command from the NuGet Package Manager console in Visual Studio. 

The OwinContrib.Security.LinkedIn was designed and implemented similar to [Microsoft.Owin.Security.Facebook](https://www.nuget.org/packages/Microsoft.Owin.Security.Facebook) and [Microsoft.Owin.Security.Twitter](https://www.nuget.org/packages/Microsoft.Owin.Security.Twitter) this allows you to use it the same way as the security middlewares provided by Microsoft.  
How to use in MVC5 project: 
--------
A couple of actions will need to be done under the App_Start folder in the Startup.Auth.cs file :
 
* Add namespace  `using OwinContrib.Security.LinkedIn;`
* In the `ConfigureAuth` call the corresponding *apps* extention method and pass your params:
```csharp
public void ConfigureAuth(IAppBuilder app)
{
        //... custom code ..
    
        app.UseLinkedInAuthentication("YOUR_APP_KEY", "YOUR_APP_SECRET_KEY");
    
        //... custom code ...
}
```
* If you need to pass more params application scope for instance pass a `LinkedInAuthenticationOptions` object as param:
```csharp
public void ConfigureAuth(IAppBuilder app)
{
        //... custom code ..
    
        app.UseLinkedInAuthentication(new LinkedInAuthenticationOptions()
        {
                AppId = "YOUR_APP_API_KEY",
                AppSecret = "YOUR_APP_SECRET_KEY",
                Scope = new List<string>() {"r_fullprofile", "r_emailaddress"}, 
        });

    
        //... custom code ...
}
```

Contribution
-------------
Any pull request will be very appreciated!

Got questions or suggestions? Feel free to create and issue or contact [@dkillewo](https://twitter.com/dkillewo) on twitter.
