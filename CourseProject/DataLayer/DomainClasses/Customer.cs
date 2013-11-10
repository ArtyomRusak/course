using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DomainClasses
{
    public class Customer
    {
        public Customer()
        {
            Accounts = new List<Account>();
            Deposits = new List<Deposit>();
            Loans = new List<Loan>();
            Histories = new List<History>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PassportData { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Deposit> Deposits { get; set; }
        public List<Loan> Loans { get; set; }
        public List<History> Histories { get; set; }
    }
}
