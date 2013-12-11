using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Entities
{
    public class Customer : Entity
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
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }
        public virtual ICollection<History> Histories { get; set; }

        public void SetAge()
        {
            TimeSpan timeSpan = DateTime.Now - BirthDate;
            double year = timeSpan.TotalDays/365;
            Age = (int) year;
        }
    }
}
