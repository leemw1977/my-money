using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.PersistenceModels;

namespace Web.Data
{
    public class MyMoneyContext : DbContext
    {
        public MyMoneyContext (DbContextOptions<MyMoneyContext> options)
            : base(options)
        {
        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<ExpenditureType> ExpenditureTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Site> Sites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncomeType>().ToTable("IncomeType");
            modelBuilder.Entity<ExpenditureType>().ToTable("ExpenditureType");

            modelBuilder.Entity<Income>().ToTable("Income");
            modelBuilder.Entity<Expenditure>().ToTable("Expenditure");

            modelBuilder.Entity<Currency>().ToTable("Currency");
            modelBuilder.Entity<Site>().ToTable("Site");

            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Budget>().ToTable("Budget");
        }
    }
}
