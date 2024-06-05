using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.priciples.SRP
{
    public class CustomerRefactor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public CustomerRefactor(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public string GetName() { 
            return Name;
        
        }

        public string GetAddress() {
            return Address;
        }
    }

    // Class for persisting customer data
    public class CustomerDataAccss {
        public void SaveCustomer()
        {
            // Logic to save customer data to a database
        }

    }

    // Class for customer discount
    public class CustomerDiscountClaculator {

        public void CalculateDiscount(int orderAmount)
        {
            // Logic to calculate discount based on order amount
        }

    }

    // Class for the notification
    public class Notification {
        public void SendWelcomeEmail()
        {
            // Logic to send a welcome email to the customer
        }
    }
}
