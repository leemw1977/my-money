using System;
using System.Collections.Generic;

namespace My.Money.Logic
{
    public sealed class Money
    {
        public Currency Currency { get; }
        public decimal Value { get; }

        public Money(Currency currency, decimal value)
        {
            Currency = currency;
            Value = value;
        }

        public static Money operator +(Money moneyBase, Money moneyToAdd)
        {
            Money sum = new Money(moneyBase.Currency, moneyBase.Value + moneyToAdd.ToBaseCurrency().Value);
            return sum;
        }

        public static Money operator -(Money moneyBase, Money moneyToSubtract)
        {
            Money remaining = new Money(moneyBase.Currency, moneyBase.Value + moneyToSubtract.ToBaseCurrency().Value);
            return remaining;
        }


        //protected override IEnumerable<object> GetEqualityComponents()
        //{
        //    yield return Currency.ToUpper();
        //    yield return Math.Round(Amount, 2);
        //}
    }

    public static class MoneyExtensions
    {
        public static Money ToBaseCurrency(this Money item)
        {
            return new Money(item.Currency, item.Value);
        }
    }
}
