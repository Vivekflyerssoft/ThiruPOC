using AutoMapper;
using EmployeeManagement.Models;

namespace EmployeeManagement.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<DepartmentModel, DepartmentRequestModel>().ReverseMap();
            CreateMap<EmployeeModel, EmployeeRequestModel>().ReverseMap();  
            CreateMap<OrganisationModel, OrganisationRequestModel>().ReverseMap();
        }
    }
}
