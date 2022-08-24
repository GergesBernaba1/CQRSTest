using CQRSTest.DTOs;

namespace CQRSTest.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}
