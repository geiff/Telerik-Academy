using System;
using Problem02BankAccounts.Contracts;
using Problem02BankAccounts.Customers;

namespace Problem02BankAccounts.AbstractClasses
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRatePerMonth;

        protected Account(Customer customer, decimal balance, decimal interestRatePerMonth)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRatePerMonth = interestRatePerMonth;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRatePerMonth { get; set; }

        public void Deposit(decimal depositSum)
        {
            this.Balance += depositSum;
        }

        public virtual decimal CalculateInterestAmountForPeriod(int numberOfMonths)
        {
            return numberOfMonths * this.InterestRatePerMonth;
        }
    }
}