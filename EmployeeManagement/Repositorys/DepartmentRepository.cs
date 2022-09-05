using AutoMapper;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly EmployeeDbContext _departmentDbContext;
        private readonly IMapper _mapper;
        public DepartmentRepository(EmployeeDbContext dbContext, IMapper mapper)
        {
            _departmentDbContext = dbContext;
            _mapper = mapper;   
        }
        public async Task<DepartmentRequestModel> AddDepartmentDetails(DepartmentRequestModel model)
        {
            try
            {
                var addDepartmentDetails = _mapper.Map<DepartmentModel>(model); 
                await _departmentDbContext.departments.AddAsync(addDepartmentDetails);
                await _departmentDbContext.SaveChangesAsync();
                return model;
                //var addDepartmentDetails = new DepartmentModel
                //{
                //    Id = model.Id,
                //    Name = model.Name,
                //    DepId = model.DepId
                //};
                //_employeeDbContext.departments.Add(addDepartmentDetails);
                //await _employeeDbContext.SaveChangesAsync();
                //return addDepartmentDetails;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public async Task<List<DepartmentRequestModel>> GetAllDepartment()
        {
            try
            {
                var getAllDepartment = await _departmentDbContext.departments.ToListAsync();
                return _mapper.Map<List<DepartmentRequestModel>>(getAllDepartment);
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}
