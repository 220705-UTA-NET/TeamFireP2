using FireLibrary.Model;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace FireLibrary.Data
{
    public class SQLRepository : IRepository
    {
        


        // Fields
        private readonly string _connectionString;
        private readonly ILogger<SQLRepository> _logger;
        public SQLRepository(string connectionString, ILogger<SQLRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }


        //Methods
        /*
         * Methods to address.
        Task<Book> GetBookIsbnAsync();
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<IEnumerable<Book>> GetBooksByGenre();
        Task<Customer> GetCustomerAsync();
        */

        public async Task<IEnumerable<Book>> GetBooksAsync() //getting a list of all books
        {
            List<Book> booklist = new();

            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            // Could also use "SELECT * FROM FireLibrary.Books" or w/e fields we wantm but make sure that we add the fields
            string cmdText = "SELECT ISBN, Title, Pages FROM FireLibrary.Books";
            using SqlCommand cmd = new(cmdText, connection);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                int isbn = reader.GetInt32(0);
                string title = reader.GetString(1);
                int pages = reader.GetInt32(2);

                Book tmpBook = new Book(isbn, title, pages); //gotta make this shit in Model
                booklist.Add(tmpBook);
            }

            await connection.CloseAsync();
            _logger.LogInformation()("Executed GetBooksAsync, returned {0} results", booklist.Count); 
        }






    }
}