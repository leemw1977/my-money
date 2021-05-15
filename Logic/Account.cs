using My.Money.Domain.ValueObjects;
using My.Money.Logic;

namespace My.Money.Domain
{
    public sealed class Account
    {
        public string FriendlyName { get; private set; }
        public double Balance { get; private set; }
        public Currency CurrencyCode { get; private set; }

        public double GetBalance()
        {
            return Balance;
        }

        public void Credit(double valueToCredit, string currencyOfCredit)
        {
            double amount = 0;
            string currency = "";
            ConvertToAccountCurrency(valueToCredit, currencyOfCredit, out amount, out currency);

            Balance += amount;
        }

        public void Debit(double valueToDebit, string currencyOfDebit)
        {
            double amount = 0;
            string currency = "";
            ConvertToAccountCurrency(valueToDebit, currencyOfDebit, out amount, out currency);

            Balance -= amount;
        }

        private void ConvertToAccountCurrency(double amountIn, string currencyIn, out double amountOut, out string currencyOut)
        {
            currencyOut = CurrencyCode.ToString();
            amountOut = amountIn; // Obviously we need to do the conversion of this but it'll suffice to assume 1:1 of all currencies for now
        }
    }
}
