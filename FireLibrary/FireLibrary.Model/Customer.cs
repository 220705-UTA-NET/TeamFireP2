using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public bool CanBorrow { get; set; }
        public int BookCount { get; set; }

        public Customer () { }

        public Customer(int customerID, string username, bool canBorrow, int bookCount)
        {
            this.CustomerID = customerID;
            this.Username = username;
            this.CanBorrow = canBorrow;
            this.BookCount = bookCount;
        }
    }
}
