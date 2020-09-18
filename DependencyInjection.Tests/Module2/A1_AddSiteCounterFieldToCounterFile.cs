using System.IO;
using System.Reflection;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A1_AddSiteCounterFieldToCounterFile
    {
        [Fact(DisplayName = "Add the SiteCounter field @add-sitecounter-field")]
        public void AddSiteCounterFieldToCounterFile()
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

            Assert.True(file.Contains("private readonly ISiteCounter _siteCounter"),
                "The `CounterModel` class should have a private readonly property called '_siteCounter' of type 'ISiteCounter'.");

            var siteCounter = TestHelpers.GetClassType("Customer.ASPNETCore.UI.Pages.CounterModel");
            var fieldInfo = siteCounter.GetField("_siteCounter", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DoNotWrapExceptions);

            Assert.True(fieldInfo != null && fieldInfo.Name.Contains("_siteCounter")
                                          && siteCounter.IsPublic
                                         // && siteCounter.GetProperty("BugService").Name.Contains("BugService")
                , "`Counter.cshtml.cs` should contain a private property `_siteCounter` of type `ISiteCounter`.");


        }
    }
}
