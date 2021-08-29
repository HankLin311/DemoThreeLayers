using DemoThreeLayers.Common.Dtos;

namespace DemoThreeLayers.Services.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeDto GetRehabusInfo(int id);
    }
}
