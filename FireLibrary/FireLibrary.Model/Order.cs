using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateLent { get; set; }
        public DateTime DateDue { get; set; }

        public Order() { }
        public Order(int orderId, int customerId, DateTime dateLent, DateTime dateDue) 
        {
            OrderId = orderId;
            CustomerId = customerId;
            DateLent = dateLent;
            DateDue = dateDue;
        }


    }
}
