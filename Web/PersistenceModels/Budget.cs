using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.PersistenceModels
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Site Site { get; set; }
        public IEnumerable<Income> Incomings { get; set; }
        public IEnumerable<Expenditure> Outgoings { get; set; }
        public BudgetType Type { get; set; }
    }
}
