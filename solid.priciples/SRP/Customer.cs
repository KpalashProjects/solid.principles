using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.priciples.SRP
{

    // The customer class of e-commerce site has this responsibilities. It's violate the SRP rules
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public void SaveCustomer()
        {
            // Logic to save customer data to a database
        }

        public void CalculateDiscount(int orderAmount)
        {
            // Logic to calculate discount based on order amount
        }

        public void SendWelcomeEmail()
        {
            // Logic to send a welcome email to the customer
        }

    }
}
