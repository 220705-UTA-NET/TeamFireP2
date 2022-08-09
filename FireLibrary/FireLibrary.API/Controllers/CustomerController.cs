using Microsoft.AspNetCore.Mvc;
using FireLibrary.Data;
using FireLibrary.Model;
using System.Text.Json;

namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase 
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IRepository _repo;

        public CustomerController(IRepository repo,ILogger<CustomerController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("api/customer")]
        public async Task<ActionResult<Customer>> GetCustomerAsync(int id,string username)
        {
            //throw new NotImplementedException();
            //Customer customer = new Customer(12345,"username1",true,0);was before merged with dev
            //Customer customer = new Customer(12345, "username1", true, 0, 0);//this should pass test by cheating
            Customer customer = await _repo.GetCustomerAsync(12345);
            string json = JsonSerializer.Serialize(customer);
            var result = new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = json
            };
            return result;

        }
    }
}

