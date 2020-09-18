using System.IO;
using Xunit;

namespace DependencyInjection.Tests.Module3
{
    public class B2_IncludeBusinessSharedNamespace
    {
        [Fact(DisplayName = "Include Business.Shared Namespace @include-businessshared-namespace")]
        public void IncludeBusinessSharedNamespace()
        {
            var filePath = TestHelpers.GetRootString() + "Customer.ASPNETCore.UI"
                                                       + Path.DirectorySeparatorChar + "Startup.cs";
            Assert.True(File.Exists(filePath), "`Startup.cs` was not found.");

            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }

            Assert.True(file.Contains("using Business.Shared;"),
                "The 'using Business.Shared' namespace has not been added to the `Startup.cs` file."); 

        }
    }
}
