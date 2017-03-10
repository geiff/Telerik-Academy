namespace Problem02BankAccounts.Contracts
{
    using Problem02BankAccounts.Customers;

    interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRatePerMonth { get; set; }

        void Deposit(decimal depositSum);

        decimal CalculateInterestAmountForPeriod(int numberOfMonths);
    }
}