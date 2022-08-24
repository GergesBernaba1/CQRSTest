using CQRSTest.Models;
using System;

namespace CQRSTest.Repositoies
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            // Get the employee record from a data store  
            // Below is for demo purposes only  
            return new Employee()
            {
                Id = 1,
                FirstName = "Gerges",
                LastName = "Bernaba",
                DateOfBirth = new DateTime(1992, 12, 09),
                Street = "221 Gesr El Suez",
                City = "Cairo",
                PostalCode = "16162"
            };
        }
    }
}
