using AutoMapper;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys
{
    public class OrganisationRepository : IOrganisationRepository
    {
        private readonly EmployeeDbContext _organisationDbContext;
        private readonly IMapper _mapper;   
        public OrganisationRepository(EmployeeDbContext dbContext, IMapper mapper)
        {
            _organisationDbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<OrganisationRequestModel> AddOrganisation(OrganisationRequestModel OrgRequestmodel)
        {
            try
            {
                var addOrgDetails = _mapper.Map<OrganisationModel>(OrgRequestmodel); 
                await _organisationDbContext.organisations.AddAsync(addOrgDetails);
                await _organisationDbContext.SaveChangesAsync();
                return OrgRequestmodel;
                
                //var organisation = new OrganisationModel
                //{
                //    Name = model.Name,
                //    Id = model.Id
                //};
                //_organisationDbContext.organisations.Add(organisation);
                //await _organisationDbContext.SaveChangesAsync();
                //return organisation;
            }
            catch (System.Exception)
            {

                throw;
            }           
        }
        public async Task<List<OrganisationRequestModel>> GetOrganisation()
        {
            try
            {
                var getAllOrganisation = await _organisationDbContext.organisations.ToListAsync();
                return _mapper.Map<List<OrganisationRequestModel>>(getAllOrganisation);
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}
