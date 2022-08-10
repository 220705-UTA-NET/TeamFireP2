using Microsoft.AspNetCore.Mvc;
using FireLibrary.Data;
using FireLibrary.Model;
using System.Text.Json;

namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthorController : ControllerBase
    {
        private readonly IRepository _repo;
        private readonly ILogger<AuthorController> _logger;

        public AuthorController(IRepository repo, ILogger<AuthorController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("authors")]
        public async Task<ActionResult<List<Author>>> GetAuthorsAsync(int id, string name)
        {
            if (id == -1)//customer is null added the -1 to check for a user which does not exists while we wait for LibraryRepo
            {
                //return new ContentResult()
                //{
                //    StatusCode = 204
                //};
                return NoContent();//no content
            }
            Author author1 = new Author(12345, "authorname1");
            Author author2 = new Author(56789, "authorname2");
            List<Author> authors = new List<Author>();
            //authors = _repo.getAuthorsAsync();// needs to be implemented
            authors.Add(author1);
            authors.Add(author2);
            string json = JsonSerializer.Serialize(author1);
            var result = new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = json
            };
            return result;
        }
        public async Task<ActionResult<Author>> GetAuthorAsyncById(int id)
        {
            if (id == -1)
            {
                return NotFound();
            }
            Author author1 = new Author(12345, "authorname1");
            //author1 = getAuthorByIdAsync(id);// needs to be implemented
            string json = JsonSerializer.Serialize(author1);
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

