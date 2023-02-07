using CustomerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerAPI.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]  
    public class CustomersController : ControllerBase
    {

        private ICustomerRepo customerRepo;
        private IConfiguration configuration;

        public CustomersController(ICustomerRepo _customerRepo, IConfiguration _configuration)
        {
            this.customerRepo = _customerRepo;
            this.configuration = _configuration;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        [MapToApiVersion("2.0")]
        public Task<IEnumerable<Customer>> Get()
        {
            return this.customerRepo.GetAllCustomers();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{CustomerId}")]
        public Task<Customer> Get(long CustomerId)
        {
            return this.customerRepo.GetCustomerById(CustomerId);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            await this.customerRepo.AddCustomer(customer);
            return CreatedAtAction(nameof(Get),
                           new { id = customer.CustomerId }, customer);
        }


    
       

        // PUT api/<CustomersController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Customer customer)
        {
            await this.customerRepo.UpdateCustomer(customer);
            return CreatedAtAction(nameof(Get),
                           new { id = customer.CustomerId }, customer);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{CustomerId}")]
        public async Task<IActionResult> Delete(long CustomerId)
        {

            if (await this.customerRepo.DeleteCustomer(CustomerId))
                return new OkResult();
            else
                return new BadRequestResult();

        }
    }
}
