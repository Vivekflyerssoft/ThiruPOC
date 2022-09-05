using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys.IRepository
{
    public interface IEmpRepository
    {
        Task<EmployeeRequestModel> AddEmployee(EmployeeRequestModel employeeModel);
        Task<List<EmployeeApiResponseModel>> GetAllEmployeeDetails();

    }
}
