using DemoThreeLayers.Common.Entities;
using DemoThreeLayers.Repository.Interfaces;
using RehabusSystem.Common.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace DemoThreeLayers.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employee;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employee.FirstOrDefault(n => n.EmployeeId == id);
        }
    }
}
