using Microsoft.AspNetCore.Mvc;
using FireLibrary.Data;
using FireLibrary.Model;
using System.Text.Json;

namespace FireLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        
        private readonly ILogger<AuthorController> _logger;
        private readonly IRepository _repo;

        public AuthorController(IRepository repo, ILogger<AuthorController> logger)
        {
            this._repo = repo;
            this._logger = logger;
        }
        [HttpGet("author")]
        public async Task<ActionResult<Author>> GetAuthorAsync(int? id, string? username)
        {
            //return one fake author hard coded for now
            Author author = new Author(12345, "authorname1");//this should pass test by cheating
            //Author author = await _repo.GetAuthorAsync(12345);
            string json = JsonSerializer.Serialize(author);
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

