using Problem02BankAccounts.Contracts;
using Problem02BankAccounts.Customers;

namespace Problem02BankAccounts.Accounts
{
    using AbstractClasses;

    public class MortgageAccount : Account, IAccount
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRatePerMonth) : base(customer, balance, interestRatePerMonth)
        {
        }

 
        public override decimal CalculateInterestAmountForPeriod(int numberOfMonths)
        {
            if (numberOfMonths < 12 && this.Customer == Customer.Company)
            {
                return base.CalculateInterestAmountForPeriod(numberOfMonths) / 2;
            }
            else if (numberOfMonths <= 6 && this.Customer == Customer.Individual)
            {
                return base.CalculateInterestAmountForPeriod(numberOfMonths);
            }

            return 0;
        }
    }
}