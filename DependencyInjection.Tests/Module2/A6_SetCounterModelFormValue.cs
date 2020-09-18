using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A6_SetCounterModelFormValue
    {
        [Fact(DisplayName = "Set Counter field in CounterModele @set-counter-field")]
        public void SetCounterModelFormValue()
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

            Assert.True(file.Contains("Counter = _siteCounter.GetCounter();"),
                "The `OnPost` method in `Counter.cshtml.cs` should set the 'Counter' field to get the most current value from the 'GetCounter' value.");

            Assert.False(file.Contains(" Counter++;"),
               "The `OnPost` method in `Counter.cshtml.cs` should remove the existing to increase the 'Counter' field.  Note: 'Counter++;'");

        }
    }
}
