using Web.PersistenceModels;
using System;
using System.Linq;

namespace Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MyMoneyContext context)
        {
            // Look for any students.
            if (context.Sites.Any())
            {
                return;   // DB has been seeded
            }

            var baseCurrency = new Currency()
                {Name = "British Pound Sterling", ShortCode = "GBP", ConversionRateToBaseCurrency = 1};

            context.Currencies.Add(baseCurrency);

            var mainSite = new Site() {BaseCurrency = baseCurrency, SiteCode = "DEF", SiteName = "Default"};
            context.Sites.Add(mainSite);

            var accounts = new Account[]
            {
                new Account()
                    {Site = mainSite, AccountCurrency = baseCurrency, Name = "Current", Type = AccountType.Current}
            };

            context.Accounts.AddRange(accounts);

            var budgets = new Budget[]
            {
                new Budget() 
                { 
                    Site = mainSite, 
                    Type = BudgetType.Monthly, 
                    Name = "Default Budget",
                    Incomings = new Income[]
                    {
                        new Income() { Type = new IncomeType() {Description = "Salary"}, Value = 0, ValueCurrency = baseCurrency }
                    },
                    Outgoings = new Expenditure[]
                    {
                        new Expenditure() { Type = new ExpenditureType() {Description = "Mortgage/Rent"}, Value = 0, ValueCurrency = baseCurrency }
                    }
                }
            };

            context.Budgets.AddRange(budgets);

            context.SaveChanges();

        }
    }
}