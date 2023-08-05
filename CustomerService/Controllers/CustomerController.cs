using CustomerService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDbContext _customerDbContext;

        public CustomerController(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }


        [HttpGet]
        [Route(template:"/customers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
           return await _customerDbContext.Customers.ToListAsync();
        }

        //dont know why this tutor doesn't add Async n Await
        [HttpGet]
        [Route(template:"/products")]
        public ActionResult<IEnumerable<Product>> GetProduct()
        {
            return _customerDbContext.Products.ToList();
        }

        [HttpPost]
        [Route(template: "/customer")]
        public async Task PostCustomer(Customer customer)
        { 
            _customerDbContext.Customers.Add(customer);
            await _customerDbContext.SaveChangesAsync();
        }
    }
}
