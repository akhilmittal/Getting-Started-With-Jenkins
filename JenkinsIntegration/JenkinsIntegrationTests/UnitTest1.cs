using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace JenkinsIntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDataService dataService = new DataService();
            var hostName = dataService.GetHost();
            Assert.AreEqual(Environment.MachineName, hostName);
        }
    }
}
