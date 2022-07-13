using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTradeApp.Categories
{
    public class HighRisk : ITrade
    {
        public HighRisk(double tradeValue, string clientSector, DateTime referencedate)
        {
            this.Value = tradeValue;
            this.ClientSector = clientSector;
            this.NextPaymentDate = referencedate;
        }

        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public bool IsPoliticallyExposed { get; set; }
    }
}
