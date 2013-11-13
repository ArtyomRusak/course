using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer.Repositories.Contracts
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByPassportData(string passportData);
        List<Customer> GetCustomersWhichContainsSurname(string surname);
    }
}
