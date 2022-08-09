using System;
namespace FireLibrary.Model
{
    public class CustomerResponse
    {

        public Customer Customer { get; set; }
        public int OutstandingBooks { get; set; }
        public int Fines { get; set; }

        public CustomerResponse() { }
    
        public CustomerResponse(Customer customer, int outstandingbooks, int fines)
        {
            this.Customer = customer;
            this.OutstandingBooks = outstandingbooks;
            this.Fines = fines;
        }
    }
}

