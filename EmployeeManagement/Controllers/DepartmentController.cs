using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpPost("Add department")]
        public async Task<IActionResult>AddDepartment(DepartmentRequestModel departmentModel)
        {
            await _departmentRepository.AddDepartmentDetails(departmentModel);
            return Ok(departmentModel);
        }
        [HttpGet("get all Department")]
        public async Task<IActionResult> GetAllDepartments()
        {
            var getAllDept = await _departmentRepository.GetAllDepartment();
            if (getAllDept == null)
            {
                return NotFound();
            }
            return Ok(getAllDept);
        }
    }
}
