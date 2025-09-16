namespace CRMRepositories;

using CRMEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public interface ICustomerRepositories
{
    IEnumerable<Customer> GetAllCustomers();
    Customer? GetCustomerById(int id);
    void AddCustomer(Customer customer);
}