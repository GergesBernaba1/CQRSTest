using CQRSTest.Models;

namespace CQRSTest.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}
