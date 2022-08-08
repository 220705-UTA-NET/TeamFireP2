using Microsoft.AspNetCore.Mvc;
using FireLibrary.Model;
namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class BookController : ControllerBase
    {
        public BookController()
        {
        }
        [HttpGet("books")]
        public async Task<ActionResult<Book>> GetBookAsync(string title, string author, string isbn)
        {
            throw new NotImplementedException();
        }

    }
}

