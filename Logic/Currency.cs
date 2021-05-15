using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Money.Logic
{
    public sealed class Currency
    {
        public string CurrencyCode { get; private set; }
        public string CurrencyName { get; private set; }

        public decimal ConversionToBaseCurrencyFactor { get; private set; }
    }
}
