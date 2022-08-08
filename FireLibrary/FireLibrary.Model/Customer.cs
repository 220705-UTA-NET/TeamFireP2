using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Username { get; set; }
        public bool CanBorrow { get; set; } = true;
        public double Fines { get; set; } = 0;
        public int BookCount { get; set; } = 0;

        public Customer() { }
        public Customer(int customerId, string username, bool canBorrow, double fines, int bookCount)
        {
            CustomerId = customerId;
            Username = username;
            CanBorrow = canBorrow;
            Fines = fines;
            BookCount = bookCount;
        }
    }
}
