using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.PersistenceModels
{
    public class Site
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public Currency BaseCurrency { get; set; }
    }
}
