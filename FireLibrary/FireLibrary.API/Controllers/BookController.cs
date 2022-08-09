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
        [HttpGet("book")]
        public async Task<ActionResult<Book>> GetBookAsync(string isbn)
        {
            throw new NotImplementedException();
        }
        [HttpGet("books")]
        public async Task<ActionResult<List<Book>>> GetBooksAsync(string author, string title)
        {
            throw new NotImplementedException();
        }

    }
}

