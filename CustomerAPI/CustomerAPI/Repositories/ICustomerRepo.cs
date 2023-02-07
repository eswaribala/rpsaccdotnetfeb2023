global using CustomerAPI.Models;

namespace CustomerAPI.Repositories
{
    public interface ICustomerRepo
    {
       Task<Customer> AddCustomer(Customer Customer);
        Task<Customer> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(long CustomerId);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(long CustomerId);

    }
}
