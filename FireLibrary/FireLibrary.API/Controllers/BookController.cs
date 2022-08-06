using Microsoft.AspNetCore.Mvc;
using FireLibrary.Model;
using FireLibrary.Data;
namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class BookController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly ILogger<BookController> _logger;

        public BookController(IRepository repo, ILogger<BookController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("books")]
        public async Task<ActionResult<Book>> GetBookAsync(string title, string author, string isbn)
        {
            await Task.Delay(1000);
            throw new NotImplementedException();
        }

    }
}

