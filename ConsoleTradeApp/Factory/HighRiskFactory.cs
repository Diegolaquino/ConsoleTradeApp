using ConsoleTradeApp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTradeApp.Factory
{
    public class HighRiskFactory : ITradeFactory
    {
        public ITrade Create(double tradeValue, string clientSector, DateTime referencedate)
        {
            return new HighRisk(tradeValue, clientSector, referencedate);
        }
    }
}
