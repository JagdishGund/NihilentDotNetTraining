namespace CRMRepositories;

using CRMEntities;
public class CustomerRepositories : ICustomerRepositories
{
    public IEnumerable<Customer>? GetAllCustomers()
    {
        return JsonCustomerManager.LoadCustomers();
    }
     public Customer? GetCustomerById(int id)
    {
        IEnumerable<Customer> customers = GetAllCustomers();
        return customers.FirstOrDefault(c => c.Id == id);
    }

    public void AddCustomer(Customer cust)
    {
        List<Customer> customers = GetAllCustomers().ToList();
        customers.Add(cust);
        JsonCustomerManager.SaveCustomers(customers);
    }

}
