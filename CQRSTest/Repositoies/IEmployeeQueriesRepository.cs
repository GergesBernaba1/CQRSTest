using CQRSTest.Models;

namespace CQRSTest.Repositoies
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}
