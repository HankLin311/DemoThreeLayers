using AutoMapper;
using DemoThreeLayers.Common.Dtos;
using DemoThreeLayers.Common.Entities;

namespace DemoThreeLayers.Helpers
{
    public class EntitiesAndDtosProfile : Profile
    {
        public EntitiesAndDtosProfile()
        {
            // 由 Entities 和 Dtos 互相映射
            CreateMap<Employee, EmployeeDto>()

                // 使用自定義映射 
                .ForMember(
                    destinationMember: des => des.Id,
                    memberOptions: opt => {
                        opt.MapFrom(mapExpression: map => map.EmployeeId);
                    })

                // ReverseMap表示雙向映射
                .ReverseMap();

        }
    }
}
