using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireLibrary.Model;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace FireLibrary.Data
{
    public class AuthRepository : IRepository
    {
        public readonly string _connectionString;
        private readonly ILogger<LibraryRepository> _logger;

        public AuthRepository(string connectionString, ILogger<LibraryRepository> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        //Methods
        //GET
        public Task<Boolean> UserLogIn(string userName, string pword)
        {
            //logic, tbd
            throw new NotImplementedException();
        }


        //POST
        public Task CreateUserAsync(User user)
        {
            //logic
            throw new NotImplementedException();
        }




        //Unused Methods, from other controller. Find better solution
        public Task<Book> GetBookIsbnAsync(string isbn)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksAsync(string author, string title)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksByGenre(string genre)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
