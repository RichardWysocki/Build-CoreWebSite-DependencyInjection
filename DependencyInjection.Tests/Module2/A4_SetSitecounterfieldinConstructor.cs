using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A4_SetSitecounterfieldinConstructor
    {
        [Fact(DisplayName = "Set siteCounter field in Constructor @set-sitecounter-field-constructor")]
        public void SetSitecounterfieldinConstructor()
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

            Assert.True(file.Contains("_siteCounter = siteCounter"),
                "The Constructor method in `Counter.cshtml.cs` did not set the '_siteCounter' field to the parameter 'siteCounter' variable."); 

        }
    }
}
