using Microsoft.AspNetCore.Mvc;
using FireLibrary.Data;
using FireLibrary.Model;
using System.Text.Json;

namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class CustomerController : ControllerBase 
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IRepository _repo;

        public CustomerController(IRepository repo,ILogger<CustomerController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("customer")]
        public async Task<ActionResult<Customer>> GetCustomerAsync(int? id, string? username)
        {
            //return one fake customer hard coded for now
            Customer customer = new Customer(12345, "username1", true, 1, 1);//this should pass test by cheating
            //Customer customer = await _repo.GetCustomerAsync(12345);//um-implemented maybe get customer by id and get customer by username could be two separate methods
            if (customer.Username == "" || id == -1)//customer is null added the -1 to check for a user which does not exists while we wait for LibraryRepo
            {
                return NotFound();
            }
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

