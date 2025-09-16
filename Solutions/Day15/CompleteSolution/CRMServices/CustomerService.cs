
namespace CRMServices;

using CRMEntities;
using System.Collections.Generic;
using CRMRepositories;
public class CustomerService : ICustomerService
{
    private readonly ICustomerRepositories _customerRepositories;


    public CustomerService(ICustomerRepositories customerRepositories)
    {
        _customerRepositories = customerRepositories;
    }

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _customerRepositories.GetAllCustomers();
    }

    public Customer? GetCustomerById(int id)
    {
        return _customerRepositories.GetCustomerById(id);
    }

    public void AddCustomer(Customer customer)
    {
        _customerRepositories.AddCustomer(customer);
    }
}