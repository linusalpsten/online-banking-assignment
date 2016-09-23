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
        public int balance { get; set; }
        public string displayMember { get { return accountNr.ToString(); } }
        public List<Transaction> transactions = new List<Transaction>();
        public Account()
        {
            balance = 1000;
        }
        public Account(int balance)
        {
            this.balance = balance;
        }
    }

    public class Transaction
    {
        public int amount { get; }
        public DateTime dateAndTime { get; }
        public Transaction(int amount)
        {
            this.amount = amount;
            dateAndTime = DateTime.UtcNow;
        }
    }
}
