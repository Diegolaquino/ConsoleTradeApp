using ConsoleTradeApp.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTradeAppTests
{
    [TestClass]
    public class ApplicationFactoryTests
    {
        [TestMethod]
        [DataRow("5000000", "public")]
        [DataRow("3000000", "public")]
        public void Given_MediumRiskAttributes_Should_Return_MediumRiskObject(string tradeValue, string clientSector)
        {
            var referencedate = DateTime.Now;
            var contractDate = DateTime.Now.AddDays(5);

            var trade = ApplicationFactory.ExecuteAction(referencedate, double.Parse(tradeValue), clientSector, contractDate);

            Assert.IsTrue(trade.GetType().Name.Contains("MediumRisk"));
        }

        [TestMethod]
        [DataRow("2000000", "private")]
        public void Given_HighRiskAttributes_Should_Return_HighRiskObject(string tradeValue, string clientSector)
        {
            var referencedate = DateTime.Now;
            var contractDate = DateTime.Now.AddDays(5);

            var trade = ApplicationFactory.ExecuteAction(referencedate, double.Parse(tradeValue), clientSector, contractDate);

            Assert.IsTrue(trade.GetType().Name.Contains("HighRisk"));
        }

        [TestMethod]
        [DataRow("400000", "public")]
        public void Given_ExpiredAttributes_Should_Return_ExpiredObject(string tradeValue, string clientSector)
        {
            var referencedate = DateTime.Now;
            var contractDate = DateTime.Now.AddDays(-5);

            var trade = ApplicationFactory.ExecuteAction(referencedate, double.Parse(tradeValue), clientSector, contractDate);

            Assert.IsTrue(trade.GetType().Name.Contains("Expired"));
        }
    }
}