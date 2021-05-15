namespace Web.PersistenceModels
{
    public class Expenditure : IncomeExpenditureType
    {
        public ExpenditureType Type { get; set; }
        public double Value { get; set; }
        public Currency ValueCurrency { get; set; }
    }
}