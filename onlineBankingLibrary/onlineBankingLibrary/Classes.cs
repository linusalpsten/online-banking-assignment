using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBankingLibrary
{
    public class Client
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get { return string.Format("{0} {1}", firstName, lastName); } }

        public List<Account> accounts = new List<Account>();

        public void addAccount(Account account)
        {
            accounts.Add(account);
        }
    }

    public class Account
    {
        public int accountNr { get; set; }
        private int balance { get; set; }
        public string information { get { return string.Format("Account: {0}", accountNr.ToString()); } }
        public List<Transaction> transactions = new List<Transaction>();

        public Account()
        {
            balance = 1000;
        }
        public Account(int balance)
        {
            this.balance = balance;
        }

        public int getBalance()
        {
            return balance;
        }

        public void deposit(int amount)
        {
            // Amount must be a positive number
            if (amount < 0)
            {
                return;
            }

            // Deposit amount to account balance
            balance += amount;

            // Add new transaction
            transactions.Add(new Transaction(amount));
        }
        public void withdraw(int amount)
        {
            // Amount must be a positive number
            if (amount < 0)
            {
                return;
            }

            // Deny withdrawal if balance becomes less than 500
            if (balance - amount < 500)
            {
                return;
            }

            // Withdraw amount from account balance
            balance -= amount;

            // Add new transaction
            transactions.Add(new Transaction(-amount));

        }
    }

    public class Transaction
    {
        private int amount { get; set; }
        public DateTime dateAndTime { get; }
        public string information { get { return string.Format("{0}: {1} {2}", dateAndTime.ToString("G"), getTransactionTypeForInfo(), getTransactionAmount()); } }
        public Transaction(int amount)
        {
            this.amount = amount;
            dateAndTime = DateTime.UtcNow;
        }
        private string getTransactionTypeForInfo()
        {
            if (amount > 0)
            {
                return "Deposited";
            }
            else
            {
                return "Withdrew";
            }
        }
        private int getTransactionAmount()
        {
            if (amount < 0)
            {
                return amount * -1;
            }

            return amount;
        }
    }
}
