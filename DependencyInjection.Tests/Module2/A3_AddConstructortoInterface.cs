using System;
using System.IO;
using Business.Shared;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A3_AddConstructortoInterface
    {
        [Fact(DisplayName = "Add Constructor and parameter to Class @add-constructor-parameter")]
        public void AddConstructortoInterface()
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
            Assert.True(file.Contains("public CounterModel(ISiteCounter siteCounter)"),
                "The `CounterModel` constructor in `Counter.cshtml.cs` did not contain a parameter 'siteCounter' of type 'ISiteCounter'.");


            var siteCounter = TestHelpers.GetClassType("Customer.ASPNETCore.UI.Pages.CounterModel");
            Type[] types = new Type[1];
            types[0] = typeof(ISiteCounter);
            var constructor = siteCounter.GetConstructor(types);

            Assert.True(constructor != null && constructor.Name.Contains(".ctor")
                                          && siteCounter.IsPublic
                , "The `CounterModel` constructor in `Counter.cshtml.cs` did not contain a parameter 'siteCounter' of type 'ISiteCounter'.");

        }
    }
}
