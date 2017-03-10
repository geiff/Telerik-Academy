using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Problem02BankAccounts.Accounts;
using Problem02BankAccounts.Contracts;
using Problem02BankAccounts.Customers;

namespace Problem02BankAccounts
{
    class BankAccountMain
    {
        static void Main()
        {
            IAccount depositIndividualAccount = new DepositAccount(Customer.Individual, 120.00m, 21.00m);
            DepositAccount depositCompany = new DepositAccount(Customer.Company, 240.00m, 25.00m);
            IAccount loanIndividial = new LoanAccount(Customer.Individual, 20.00m, 15.00m);
            IAccount loanCompany = new LoanAccount(Customer.Company, 200.00m, 17.00m);
            IAccount mortgageIndividial = new MortgageAccount(Customer.Individual, 2000.00m, 5.00m);
            IAccount mortgageCompany = new MortgageAccount(Customer.Company, 5000.00m, 7.00m);

            Console.WriteLine("Deposit individial account CalculateInterestAmountForPeriod for 5 month is ${0}",
                depositIndividualAccount.CalculateInterestAmountForPeriod(5));
            Console.WriteLine("Deposit individial account Balance before deposit is ${0}", depositIndividualAccount.Balance);
            depositIndividualAccount.Deposit(50);
            Console.WriteLine("Deposit individial account Balance after deposit is ${0}", depositIndividualAccount.Balance);
            Console.WriteLine("Deposit company account CalculateInterestAmountForPeriod for 2 month is ${0}",
                depositCompany.CalculateInterestAmountForPeriod(2));
            Console.WriteLine("Deposit company account Balance before draw money is ${0}", depositCompany.Balance);
            depositCompany.DrawMoney(2000);
            Console.WriteLine("Deposit company account Balance after draw money is ${0}", depositCompany.Balance);
            Console.WriteLine("Loan individial account CalculateInterestAmountForPeriod for 2 month is ${0}", 
                loanIndividial.CalculateInterestAmountForPeriod(2));
            Console.WriteLine("Loan company account CalculateInterestAmountForPeriod for 1 month is ${0}",
                loanCompany.CalculateInterestAmountForPeriod(1));
            Console.WriteLine("Mortgage individial account CalculateInterestAmountForPeriod for 6 month is ${0}",
                mortgageIndividial.CalculateInterestAmountForPeriod(6));
            Console.WriteLine("Mortgage company account CalculateInterestAmountForPeriod for 7 month is ${0}",
               mortgageCompany.CalculateInterestAmountForPeriod(7));
        }
    }
}
