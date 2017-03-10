using System;
using Problem02BankAccounts.Contracts;
using Problem02BankAccounts.Customers;

namespace Problem02BankAccounts.Accounts
{
    using AbstractClasses;

    public class DepositAccount : Account, IAccount,IDraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRatePerMonth) : base(customer, balance, interestRatePerMonth)
        {
        }

        public void DrawMoney(decimal moneyForDraw)
        {
                if (this.Balance >= moneyForDraw)
                {
                    this.Balance -= moneyForDraw;
                }
                else
                {
                    Console.WriteLine(new ArgumentOutOfRangeException("Balance", "Insufficient balance"));
                }
           
        }

        public override decimal CalculateInterestAmountForPeriod(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return base.CalculateInterestAmountForPeriod(numberOfMonths);
            }

            return 0;
        }
    }
}