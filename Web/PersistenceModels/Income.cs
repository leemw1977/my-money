namespace Web.PersistenceModels
{
    public class Income : IncomeExpenditureType
    {
        public IncomeType Type { get; set; }
        public double Value { get; set; }
        public Currency ValueCurrency { get; set; }
    }
}