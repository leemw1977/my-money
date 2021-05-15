using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.PersistenceModels
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public float ConversionRateToBaseCurrency { get; set; }
    }
}
