using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A5_IncreaseSiteCountervalue
    {
        [Fact(DisplayName = "Increase the _siteCounter fielde @increase-sitecounter")]
        public void IncreaseSiteCountervalue()
        {
            var filePath = TestHelpers.GetRootString() + "Customer.ASPNETCore.UI"
                                                       + Path.DirectorySeparatorChar + "Pages"
                                                       + Path.DirectorySeparatorChar + "Counter.cshtml.cs";
            Assert.True(File.Exists(filePath), "`Counter.cshtml.cs` was not found.");

            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("_siteCounter.AddCounter()"),
                "The `OnPost` method in `Counter.cshtml.cs` should use the '_siteCounter' field and call the 'AddCounter' method to increase its value.");

        }
    }
}
