using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTradeApp.Factory
{
    public class ApplicationFactory
    {
        public static ITrade ExecuteAction(DateTime referenceDate, double tradeValue, string clientSector, DateTime contractDate)
        {
            if (DateTime.Now.Subtract(contractDate).Days > 0)
                return new ExpiredFactory().Create(tradeValue, clientSector, contractDate);
            else if (clientSector == "private" && tradeValue > 1_000_000)
                return new HighRiskFactory().Create(tradeValue, clientSector, contractDate);

            else if (clientSector == "public" && tradeValue > 1_000_000)
                return new MediumRiskFactory().Create(tradeValue, clientSector, contractDate);
            else
                throw new Exception("Modelo não conhecido");
        }
    }
}
