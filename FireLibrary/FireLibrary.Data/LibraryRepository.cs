using FireLibrary.Model;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;


namespace FireLibrary.Data
{
    public class LibraryRepository : IRepository
    {
        public readonly string _connectionString;
        private readonly ILogger<LibraryRepository> _logger;

        //2-arg constructor
        public LibraryRepository(string connectionString, ILogger<LibraryRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        //Methods - by HTTP method
        //GET 
        public async Task<Book> GetBookIsbnAsync(string isbn)
        {
            //logic pending
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksAsync(string? title, string? author)
        {
            //logic pending
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooksByGenre(string genre)
        {
            //logic pending
            throw new NotImplementedException();
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            //logic pending
            throw new NotImplementedException();
        }

        //POST
    }
}