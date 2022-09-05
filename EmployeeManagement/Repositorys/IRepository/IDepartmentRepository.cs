using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositorys.IRepository
{
    public interface IDepartmentRepository
    {
        Task<DepartmentRequestModel> AddDepartmentDetails(DepartmentRequestModel model);
        Task<List<DepartmentRequestModel>> GetAllDepartment();
    }
}
