using System;
using JenkinsIntegration.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsIntegration.Tests
{
    [TestClass]
    public class JenkinsTests
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
