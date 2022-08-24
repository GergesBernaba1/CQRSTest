using CQRSTest.Commands;
using CQRSTest.Queries;
using CQRSTest.Repositoies;
using System;
using System.Reflection;

namespace CQRSTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());
            employeeCommand.SaveEmployeeData(new CQRSTest.Models.Employee
            {
                Id = 2,
                FirstName = "Mina",
                LastName = "Bernaba",
                DateOfBirth = new DateTime(1992, 12, 09),
                Street = "221 Gesr El Suez",
                City = "Cairo",
                PostalCode = "16162"
            });

            Console.WriteLine($"Employee data stored");

            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(1);
            Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
            Console.ReadKey();
        }
    }
}
