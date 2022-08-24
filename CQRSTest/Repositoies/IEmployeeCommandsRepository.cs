using CQRSTest.Models;

namespace CQRSTest.Repositoies
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
}
