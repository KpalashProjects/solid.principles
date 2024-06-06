using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.principles.ISP
{
    public class ISPRefactor
    {
    }

    public interface IEmployee {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public decimal CalculateMonthllySalary();        

    }

    public interface IBonusCalculator{
        public decimal CalculateYearllyBonus();
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateMonthllySalary()
        {
            return HourlyRate * HoursWorked;
        }

    }

    public class PermanentEmployee : IEmployee, IBonusCalculator
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public decimal AnnualSalary { get; set; }

        public decimal CalculateMonthllySalary()
        {
            return AnnualSalary / 12;
        }

        public decimal CalculateYearllyBonus()
        {
            return AnnualSalary / 0.1m;
        }
    }
}
