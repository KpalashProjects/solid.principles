﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.priciples.LSP
{
    public class LSPRefactor
    {             

        public static void GetResult()
        {
            Employee contractEmp = new ContractualEmployee
            {
                Name = "John Doe",
                EmployeeId = 1,
                HourlyRate = 50,
                HoursWorked = 160
            };

            Employee permEmp = new PermanentEmployee
            {
                Name = "Jane Smith",
                EmployeeId = 2,
                AnnualSalary = 72000
            };

            PrintYearlyBonus(contractEmp); // John Doe (ID: 1) - Error: Contractual employees do not receive a yearly bonus.
            PrintYearlyBonus(permEmp);
        }

        public static void PrintYearlyBonus(Employee employee)
        {
            try
            {
                if (employee is IBonusCalculator bonusCalculator)
                {
                    Console.WriteLine($"{employee.Name} (ID: {employee.EmployeeId}) - Yearly Bonus: {bonusCalculator.CalculateYearlyBonus():C}");
                }
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"{employee.Name} (ID: {employee.EmployeeId}) - Error: {ex.Message}");
            }
        }
    }

    public abstract class Employee {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public string Address { get; set; }

        public abstract decimal CalculateMonthlySalary();

    }

    public interface IBonusCalculator
    {
        decimal CalculateYearlyBonus();
    }

    public class PermanentEmployee : Employee, IBonusCalculator
    {
        public decimal AnnualSalary { get; set; }
        public override decimal CalculateMonthlySalary()
        {
            return AnnualSalary/12;
        }

        public decimal CalculateYearlyBonus()
        {
            return AnnualSalary * 0.1m; // 10% of annual salary as bonus
        }
    }


    public class ContractualEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }
        public override decimal CalculateMonthlySalary()
        {
            return HourlyRate * HoursWorked;
        }
       
    }


}
 