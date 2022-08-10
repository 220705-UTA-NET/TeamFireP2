using Microsoft.AspNetCore.Mvc;
using FireLibrary.Model;
using FireLibrary.Data;
using System.Text.Json;

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
            //throw new NotImplementedException();
            Book book1 = new Book("1785034677", "The Martian", "Ebury Publishing", "English", 171, 2, "Andy Weir", "So you want to lieve on Mars. Perhaps its the rugged terrain, beutiful scenery, or vast..", "Six days ago, astronaut Mark Watney became one of the fist people to walk on Mars", 5, 5);
            Book book2 = new Book("441569595", "Neuromancer", "Ace", "English", 271, 1, "William Gibson", "Case was the sharpest data-thief in the matrix--until he crossed the wrong people and they crippled his nervious system, banishing him from cyberspace. Now a mysterious new employer has recruited himfor a last-chance run at an unthinkably powerful art...", "The sky above the port was the color of televison, tuned to a dead channel. \"It's not like I'm Using,\" Case heard someone say, as he shouldered his way through the crowd around the door of the Chat.", 5, 5);
            string json = "";
            //Book book = await _repo.GetBookIsbnAsync(isbn);//um-implemented maybe get customer by id and get customer by username could be two separate methods

            if (isbn == book1.Isbn)
            {
                json = JsonSerializer.Serialize(book1);

            }
            else if(isbn == book2.Isbn)
            {
                json = JsonSerializer.Serialize(book1);

            }
            else
            {
                return NotFound();
            }
            var result = new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = json
            };
            return result;
        }
        [HttpGet("books")]
        public async Task<ActionResult<List<Book>>> GetBooksAsync(string? author, string? title)
        {
            //throw new NotImplementedException();
            Book book1 = new Book("1785034677","The Martian","Ebury Publishing","English",171,2,"Andy Weir","So you want to lieve on Mars. Perhaps its the rugged terrain, beutiful scenery, or vast..","Six days ago, astronaut Mark Watney became one of the fist people to walk on Mars",5,5);
            Book book2 = new Book("441569595","Neuromancer","Ace","English",271,1,"William Gibson","Case was the sharpest data-thief in the matrix--until he crossed the wrong people and they crippled his nervious system, banishing him from cyberspace. Now a mysterious new employer has recruited himfor a last-chance run at an unthinkably powerful art...","The sky above the port was the color of televison, tuned to a dead channel. \"It's not like I'm Using,\" Case heard someone say, as he shouldered his way through the crowd around the door of the Chat.",5,5);
            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            //List<Book> books = _repo.GetBooksAsync(author, title);// um-implemented method for getting books with author and title or maybe also include genre. waiting on someone else for this
            string json = JsonSerializer.Serialize(books);
            if(author == "give me not found")
            {
                return NotFound();
            }
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

