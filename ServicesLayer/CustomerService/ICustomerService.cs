using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace ServicesLayer.CustomerService
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);

    }
}
