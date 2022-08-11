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
        -From Hau
        Task<Book> GetAllBooksAsync()
        */

        //public async Task<IEnumerable<Book>> GetAllBooksAsync() //getting a list of all books
        //{
        //    List<Book> booklist = new();

        //    using SqlConnection connection = new SqlConnection(_connectionString);
        //    await connection.OpenAsync();

        //    // Could also use "SELECT * FROM FireLibrary.Books" or w/e fields we wantm but make sure that we add the fields
        //    //(string? isbn, string? title, string? publisher, string? language, int pages, string? genre, int authorId, string? authorname, string? synopsys, string? excerpt, int totalCopies, int avalableCopies)
        //    string cmdText = "SELECT ISBN, Title, Publisher, Language, Pages, Genre, Excerpt, Synopsis, TotalCopies, AvailableCopies, " +
        //        "a.Name as AuthorName FROM FireLibrary.Books AS b JOIN FireLibrary.Authors AS a ON a.Id = b.AuthorId";
        //    using SqlCommand cmd = new(cmdText, connection);
        //    using SqlDataReader reader = await cmd.ExecuteReaderAsync();


        //    while (await reader.ReadAsync())
        //    {
        //        int isbn = reader.GetInt32(0);
        //        string title = reader.GetString(1);
        //        int pages = reader.GetInt32(2);

        //        Book tmpBook = new Book(isbn, title, pages); //gotta make this shit in Model
        //        booklist.Add(tmpBook);
        //    }

        //    await connection.CloseAsync();
        //    _logger.LogInformation()("Executed GetBooksAsync, returned {0} results", booklist.Count); 
        //}


        // ********************  GetBookIsbnAsync***********************
        public async Task<IEnumerable<Book>> GetBookIsbnAsync(string isbn)
        {
            List<Book> book = new();

            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            string cmdText = "SELECT ISBN, Title, Publisher, Language, Pages, Genre, Excerpt, Synopsis, TotalCopies, AvailableCopies, " +
                "a.Name as AuthorName FROM FireLibrary.Books AS b JOIN FireLibrary.Authors AS a ON a.Id = b.AuthorId WHERE ISBN = @isbn";
            using SqlCommand cmd = new(cmdText, connection);
            cmd.Parameters.AddWithValue("@isbn", isbn); //taking the parameter from input
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            Book b1 = new Book();
            
            while (await reader.ReadAsync())
            {
                string _isbn = reader.GetString(0);
                string title = reader.GetString(1);
                string publisher = reader.GetString(2);
                string language = reader.GetString(3);
                int pages = reader.GetInt32(4);
                string genre = reader.GetString(5);
                string excerpt = reader.GetString(6);
                string synopsis = reader.GetString(7);
                int totalCopies = reader.GetInt32(8);
                int availableCopies = reader.GetInt32(9);
                string authorName = reader.GetString(10);
              


                Book tmpBook = new Book(_isbn, title, publisher, language, pages, genre, excerpt, synopsis, totalCopies, availableCopies, authorName);
                book.Add(tmpBook);

                b1 = tmpBook;
            }

            await connection.CloseAsync();
            _logger.LogInformation("Executed GetBooksAsync");

            return (IEnumerable<Book>)b1;
        }


        // ********************  GetBooksAsync***********************
        public async Task<IEnumerable<Book>> GetBooksAsync(string title, string author)
        {
            List<Book> book = new();

            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            string cmdText = "SELECT ISBN, Title, Publisher, Language, Pages, Genre, Excerpt, Synopsis, TotalCopies, AvailableCopies, " +
                "a.Name as AuthorName FROM FireLibrary.Books AS b JOIN FireLibrary.Authors AS a ON a.Id = b.AuthorId WHERE Title = @title AND a.Name = @author";
            using SqlCommand cmd = new(cmdText, connection);
            cmd.Parameters.AddWithValue("@isbn", title);
            cmd.Parameters.AddWithValue("@author", author);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            Book b2 = new Book();

            while (await reader.ReadAsync())
            {
                string _isbn = reader.GetString(0);
                string _title = reader.GetString(1);
                string publisher = reader.GetString(2);
                string language = reader.GetString(3);
                int pages = reader.GetInt32(4);
                string genre = reader.GetString(5);
                string excerpt = reader.GetString(6);
                string synopsis = reader.GetString(7);
                int totalCopies = reader.GetInt32(8);
                int availableCopies = reader.GetInt32(9);
                string authorName = reader.GetString(10);



                Book tmpBook = new Book(_isbn, _title, publisher, language, pages, genre, excerpt, synopsis, totalCopies, availableCopies, authorName);
                book.Add(tmpBook);
                b2 = tmpBook;
            }

            await connection.CloseAsync();
            _logger.LogInformation("Executed GetBooksAsync");

            return (IEnumerable<Book>)b2;
        }

        public Task<IEnumerable<Book>> GetBooksByGenre(string genre)
        {
            throw new NotImplementedException();
        }




        // ********************  GetCustomerAsync ***********************
        public async Task<Customer> GetCustomerAsync(int id)
        {
            List<Customer> customer = new();

            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();


            string cmdText = "SELECT Id, Username, CanBorrow, Fines, BookCount FROM FireLibrary.Customer WHERE Id = @id ";
            using SqlCommand cmd = new(cmdText, connection);
            cmd.Parameters.AddWithValue("@id", id);
            using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            Customer cus1 = new Customer();

            while (await reader.ReadAsync())
            {
                int _id = reader.GetInt32(0);
                string username = reader.GetString(1);

                int x = reader.GetInt32(2);
                bool canBorrow = x > 0;
                
                double fines = reader.GetDouble(3);
                int bookcount = reader.GetInt32(4);


                Customer tmpCustomer = new Customer(_id, username, canBorrow, fines, bookcount);
                customer.Add(tmpCustomer);
                cus1 = tmpCustomer;
            }

            await connection.CloseAsync();
            _logger.LogInformation("Executed GetCustomerAsync");
            return cus1;
        }



    }
}