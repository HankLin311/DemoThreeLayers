using DemoThreeLayers.Common.Entities;
using System.Collections.Generic;

namespace DemoThreeLayers.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
    }
}
