using AutoMapper;
using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys.IRepository
{
    public interface IOrganisationRepository
    {
        Task<OrganisationRequestModel> AddOrganisation(OrganisationRequestModel OrgRequestmodel);
        Task<List<OrganisationRequestModel>> GetOrganisation();
    }
}
