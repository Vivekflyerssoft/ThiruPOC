using AutoMapper;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys
{
    public class EmpRepository : IEmpRepository
    {
        private readonly EmployeeDbContext _employeeRepository;
        private readonly IMapper _mapper;
        public EmpRepository(EmployeeDbContext dbContext, IMapper mapper)
        {
            _employeeRepository = dbContext;
            _mapper = mapper;
        }
        public async Task<EmployeeRequestModel> AddEmployee(EmployeeRequestModel employeeModel)
        {
            try
            {
                var addEmpDetails = _mapper.Map<EmployeeModel>(employeeModel);
                await _employeeRepository.employees.AddAsync(addEmpDetails);
                await _employeeRepository.SaveChangesAsync();
                return employeeModel;
                //var addEmployeeDetails = new EmployeeModel()
                //{
                //    EmpId = employeeModel.EmpId,
                //    Name = employeeModel.Name,
                //    EmailId = employeeModel.EmailId,
                //    PhoneNo = employeeModel.PhoneNo,
                //    Designation = employeeModel.Designation,
                //    Salary = employeeModel.Salary,
                //    DepId = employeeModel.DepId

                //};


                //_employeeRepository.employees.Add(addEmployeeDetails);
                //await _employeeRepository.SaveChangesAsync();
                //return employeeModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<EmployeeApiResponseModel>> GetAllEmployeeDetails()
        {
            try
            {



                var getEmp = await (from emp in _employeeRepository.employees
                                    join dep in _employeeRepository.departments on emp.DepId equals dep.DepId
                                    join org in _employeeRepository.organisations on dep.Id equals org.Id
                                    select new EmployeeApiResponseModel()
                                    {
                                        EmpId = emp.EmpId,
                                        EmpName = emp.Name,
                                        EmailId = emp.EmailId,
                                        Designation = emp.Designation,
                                        PhoneNo = emp.PhoneNo,
                                        Salary = emp.Salary,
                                        Department = dep.Name,
                                        DepId = dep.Id,
                                        OrgName = org.Name,

                                    }).ToListAsync();
                //return getEmp;
                return _mapper.Map<List<EmployeeApiResponseModel>>(getEmp);

                //var employeeDetails = await _employeeRepository.employees.Select(a => new EmployeeModel
                //{
                //    EmpId = a.EmpId,
                //    EmailId = a.EmailId,
                //    Name = a.Name,
                //    PhoneNo = a.PhoneNo,
                //    Designation = a.Designation,
                //    Salary = a.Salary
                //}).ToListAsync();
                //return employeeDetails;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
