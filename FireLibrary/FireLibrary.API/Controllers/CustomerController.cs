using Microsoft.AspNetCore.Mvc;
using FireLibrary.Data;
using FireLibrary.Model;
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
            throw new NotImplementedException();
        }
    }
}

