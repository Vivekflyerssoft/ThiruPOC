using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpRepository _employeeRepository;
        public EmployeeController(IEmpRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpPost("add employee")]
        public async Task<IActionResult> AddEmployee(EmployeeRequestModel model)
        {
            try
            {
                var addEmployee = await _employeeRepository.AddEmployee(model);
                return Ok(addEmployee);
            }
            catch (System.Exception)
            {
                throw;
            }

        }
        [HttpGet("Get All EmpDetails")]
        public async Task<IActionResult> GetAllEmpDetails()
        {
            try
            {
                var getAllEmpDetails = await _employeeRepository.GetAllEmployeeDetails();

                if (getAllEmpDetails != null)
                {
                    return Ok(getAllEmpDetails);
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}
