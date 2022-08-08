using FireLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Data
{
    public interface IRepository
    {
        Task<Book> GetBookIsbnAsync();
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<IEnumerable<Book>> GetBooksByGenre();
        Task<Customer> GetCustomerAsync();
    }
}
