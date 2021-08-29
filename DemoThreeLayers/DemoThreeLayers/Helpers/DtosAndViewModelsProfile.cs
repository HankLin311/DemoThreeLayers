using AutoMapper;
using DemoThreeLayers.Common.Dtos;
using DemoThreeLayers.Common.ViewModels;

namespace DemoThreeLayers.Helpers
{
    public class DtosAndViewModelsProfile : Profile
    { 
        public DtosAndViewModelsProfile()
        {
            // 由 Entities 和 Dtos 互相映射
            CreateMap<VmEmployee, EmployeeDto>()

                // ReverseMap表示雙向映射
                .ReverseMap();

        }
    }
}
