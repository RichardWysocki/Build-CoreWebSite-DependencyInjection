using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module3
{
    public class B1_InjectConcerteClassforInterface
    {
        [Fact(DisplayName = "Add Singleton into Startup with Concrete class for Interface")]
        public void InjectConcerteClassforInterface()
        {
            var filePath = TestHelpers.GetRootString() + "Customer.ASPNETCore.UI"
                                                       + Path.DirectorySeparatorChar + "Startup.cs";
            Assert.True(File.Exists(filePath), "`Startup.cs` was not found.");

            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("services.AddSingleton<ISiteCounter, SiteCounter>()"),
                "The `ConfigureServices` method in `Startup.cs` did not contain a call to `services.AddSingleton` with the type parametrs `<ISiteCounter, SiteCounter>`."); 

        }
    }
}
