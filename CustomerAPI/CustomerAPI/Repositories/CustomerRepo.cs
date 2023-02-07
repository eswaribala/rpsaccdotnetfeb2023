using CustomerAPI.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly BankingContext _dbContext;

        //dependecy injection

        public CustomerRepo(BankingContext bankingContext)
        {
            _dbContext = bankingContext;
        }

        public async Task<Customer> AddCustomer(Customer Customer)
        {

              var result= await _dbContext.Customers.AddAsync(Customer);
               await _dbContext.SaveChangesAsync();
               return result.Entity;

        }

        public async Task<bool> DeleteCustomer(long CustomerId)
        {
            var result = await this._dbContext.Customers.FirstOrDefaultAsync(c =>
             c.CustomerId == CustomerId);
            if (result != null)
            {
                this._dbContext.Customers.Remove(result);
                await this._dbContext.SaveChangesAsync();
            }

            result = await GetCustomerById(CustomerId);
            if (result == null)
                return true;
            else
                return false;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(long CustomerId)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
