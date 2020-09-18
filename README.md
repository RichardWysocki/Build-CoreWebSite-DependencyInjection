# ASP.NET Core Dependency Injection Application

The ASP.NET Core Dependency Injection Project is the first of a few different projects designed to give you expereinces on how to add dependency injection to different ASP.NET Core and Blazor solutions.  You will gain experiences in adding default Dependency Injection concepts to an ASP.NET Core Website and in future projects add dependency injection to Blazor Client and Server solutions even with other IoC (Scutor) containers. In this application, you will modify the Counter Razor page so that a concrete implemenation of the 'ISiteCounter' type will get injected into page using the Singleton service lifetime. Note: In a future enhacement, we'll remove the concrete implmentation to the Car List pages and inject those dependencies in as well. This ASP.NET Core application uses Razor pages.

Note: This project is the first in a series, with this project we will start using the build-in dependency injection so that concrete implementations are injected in using different service lifetimes. In a future enhancment, we will be converting the 'Car List' razor page to inject in its concrete implmentations. 

# Setup the Application

## If you want to use Visual Studio
If you want to use Visual Studio (highly recommended) follow the following steps:
-   If you already have Visual Studio installed make sure you have .Net Core installed by running the "Visual Studio Installer" and making sure ".NET Core cross-platform development" is checked
-   Open the .sln file in visual studio
-   If you need to install visual studio download it at https://visualstudio.microsoft.com/ (If you're using Windows you'll want to check "ASP.NET" and ".NET Core cross-platform development" on the workloads screen during installation.)
-   To run the application simply press the Start Debugging button (green arrow) or press F5
-   If you're using Visual Studio on Windows, to run tests open the Test menu, click Run, then click on Run all tests (results will show up in the Test Explorer)
-   If you're using Visual Studio on macOS, to run tests, select the Customer.ASPNETCore.UI Project, then go to the Run menu, then click on Run Unit Tests (results will show up in the Unit Tests panel)

(Note: All tests should fail! It's ok. This is supposed to happen. As you complete the project, more of the tests will pass. When you complete the project, **all** tests should pass)

## If you don't plan to use Visual studio
If you would rather use something other than Visual Studio
-   Install the .Net Core SDK from https://www.microsoft.com/net/download/core once that installation completes you're ready to roll!
-   To run the application go into the 'Customer.ASPNETCore.UI' project folder and type `dotnet run`
-   To run the tests go into the 'DependencyInjection.Tests' project folder and type `dotnet test`

# Features you will implement

- Change the Customer.ASPNETCore.UI website to inject into the Counter page an Interface of a SiteCounter
- Add a Singleton lifetime serivce of this SiteCounter into your website.

## Tasks necessary to complete implementation:

__Note:__ this isn't the only way to accomplish this, however; this is what the project's tests are expecting. Implementing this in a different way will likely result in being marked as incomplete / incorrect.

- [ ] Adding in Dependency Injection to an ASP.NET Core Application
	- [ ] Reconfigure the 'Counter.chtml' razor page for dependency Injection
		- [ ] Inject in the counter class object to the `Counter.chtml.cs` file.
			- [ ] Add a new private readonly property called '_siteCounter' of type 'ISiteCounter'.
			- [ ] Import in the missing using reference to the 'Business.Shared' library
			- [ ] Add a Constructor that accepts a parameter of type `ISiteCounter` named 'siteCounter'. 
			- [ ] Initialize the '_siteCounter' field with the 'siteCounter' paramter value within the Constructor
		- [ ] In the `OnPost` method within the `Counter.chtml.cs` file add support for increasing the counter and setting the Counter property.
			- [ ] Call the 'AddCounter' method on the '_siteCounter' field to increase the counter by 1.
			- [ ] Modify the 'Counter' property to get the counter from the 'GetCounter' method from the '_siteCounter' field.
			- [ ] Remove the existing process to increase the Counter variable. 
	- [ ] Register the 'ISiteCounter' service with the concrete Implmentation  
		- [ ] In the `Startup.cs` file add support for dependency types
			- [ ] In the `ConfigureServices` method call `AddSingleton` on `services` to add support for the 'ISiteCounter' interface to the Concrete implementation of 'SiteCounter'.
			- [ ] Import in the missing reference to the Business.Shared library (_Note_ : Alt+Enter)
	- Note: The application is now viewable in your browser!


## What Now?

Now is a good time to continue on with other [.Net Core Dependency Injection courses](https://app.pluralsight.com/search/?q=.net%20core%20dependency%20injection) to expand your understanding of this topic. You could also take a look at the [Dependency injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1).
