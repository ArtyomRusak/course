using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DomainClasses
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PassportData { get; set; }
        public List<Account> Account { get; set; }
        public List<Deposit> Deposits { get; set; }
    }
}
