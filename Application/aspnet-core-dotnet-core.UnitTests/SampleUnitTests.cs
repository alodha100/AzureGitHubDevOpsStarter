using aspnet_core_dotnet_core.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aspnet_core_dotnet_core.UnitTests
{
    [TestClass]
    public class SampleUnitTests
    {
        [TestMethod]
        public void IndexPageTest()
        {
            var model = new IndexModel();
            Assert.AreEqual("Index", model.DoTest());
        }
    }
}