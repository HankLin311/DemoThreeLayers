using AutoMapper;
using DemoThreeLayers.Common.Dtos;
using DemoThreeLayers.Common.Entities;
using DemoThreeLayers.Repository.Interfaces;
using DemoThreeLayers.Services.Interfaces;

namespace DemoThreeLayers.Services
{
    public class EmployeeService : IEmployeeService
    {
        readonly IEmployeeRepository _employeeRepository;
        readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public EmployeeDto GetRehabusInfo(int id)
        {
            Employee employee = _employeeRepository.GetEmployee(id);

            // AutoMapper 作法
            EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(employee);

            // 傳統作法
            //EmployeeDto employeeDto = new EmployeeDto() { 
            //    EmployeeId = employee.EmployeeId,
            //    FirstName = employee.FirstName,
            //    IdentityNumber = employee.IdentityNumber,
            //    IsResign = employee.IsResign,
            //    LastName = employee.LastName
            //};

            return employeeDto;
        }
    }
}
