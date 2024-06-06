using solid.priciples.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.principles.DIP
{
    internal class DIPRefactor
    {
    }

    public interface IDataAccess
    {
        List<Customer> LoadCustomers();
    }

    public class CustomerBusinessLogic
    {
        private IDataAccess dataAccess; // Dependency on an abstraction

        public CustomerBusinessLogic(IDataAccess dataAccess) // Dependency injection through constructor
        {
            this.dataAccess = dataAccess;
        }

        public List<Customer> GetCustomers()
        {
            return dataAccess.LoadCustomers();
        }
    }

    public class DataAccess1 : IDataAccess // Concrete implementation (e.g., database access)
    {
        public List<Customer> LoadCustomers()
        {
            // Logic to load customer data from a database

            Console.WriteLine("from Data Access 1");
            return new List<Customer>();
        }
    }

    public class DataAccess2 : IDataAccess // Alternative implementation (e.g., file access)
    {
        public List<Customer> LoadCustomers()
        {
            Console.WriteLine("from Data Access 2");
            // Logic to load customer data from a file
            return new List<Customer>();
        }
    }

}
