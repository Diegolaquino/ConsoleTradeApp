using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTradeApp.Factory
{
    public interface ITradeFactory
    {
        ITrade Create(double tradeValue, string clientSector, DateTime referencedate);
    }
}
