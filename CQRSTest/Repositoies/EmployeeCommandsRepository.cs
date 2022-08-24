
using CQRSTest.Models;

namespace CQRSTest.Repositoies
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee employee)
        {
            // Persist the employee record in a data store  
        }
    }


    
}
