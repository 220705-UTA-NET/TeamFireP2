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
        Task<Book> GetBookIsbnAsync(string isbn);
        Task<IEnumerable<Book>> GetBooksAsync(string title, string author);
        Task<IEnumerable<Book>> GetBooksByGenre(string genre);
        Task<Customer> GetCustomerAsync(int id);
       // Task<Book> GetAllBooksAsync();
    }
}
