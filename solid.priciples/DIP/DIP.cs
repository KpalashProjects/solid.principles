using solid.priciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.principles.DIP
{
    internal class DIP
    {
    }

    //public class CustomerBusinessLogic
    //{
    //    private DataAccess dataAccess;

    //    public CustomerBusinessLogic()
    //    {
    //        dataAccess = new DataAccess(); // Tight coupling to DataAccess implementation
    //    }

    //    public List<Customer> GetCustomers()
    //    {
    //        return dataAccess.LoadCustomers();
    //    }
    //}

    //public class DataAccess
    //{
    //    public List<Customer> LoadCustomers()
    //    {
    //        // Logic to load customer data from a database
    //        return new List<Customer>();
    //    }
    //}
}
