using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module2
{
    public class A2_IncludeBusinessSharedNamespace
    {
        [Fact(DisplayName = "Include Business.Shared Namespace @include-businessshared-namespace")]
        public void IncludeBusinessSharedNamespace()
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

            Assert.True(file.Contains("using Business.Shared;"),
                "The 'using Business.Shared' namespace has not been added to the `Counter.cshtml.cs` file."); 

        }
    }
}
