using ConsoleTradeApp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTradeApp.Factory
{
    public class MediumRiskFactory : ITradeFactory
    {
        public ITrade Create(double tradeValue, string clientSector, DateTime contractDate)
        {
            return new MediumRisk(tradeValue, clientSector, contractDate);
        }
    }
}
