using Problem02BankAccounts.Contracts;
using Problem02BankAccounts.Customers;

namespace Problem02BankAccounts.Accounts
{
    using AbstractClasses;

    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRatePerMonth) : base(customer, balance, interestRatePerMonth)
        {
        }

        public override decimal CalculateInterestAmountForPeriod(int numberOfMonths)
        {
            if (numberOfMonths > 3 && this.Customer == Customer.Individual)
            {
                return base.CalculateInterestAmountForPeriod(numberOfMonths);
            }
            else if(numberOfMonths > 2 && this.Customer == Customer.Company)
            {
                return base.CalculateInterestAmountForPeriod(numberOfMonths);
            }

            return 0;
        }
    }
}