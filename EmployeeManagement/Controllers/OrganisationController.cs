using EmployeeManagement.Models;
using EmployeeManagement.Repositorys.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly IOrganisationRepository _organisationRepository;
        public OrganisationController(IOrganisationRepository organisationRepository)
        {
            _organisationRepository = organisationRepository;
        }
        [HttpPost("add organisation")]
        public async Task<IActionResult> AddOrganisation(OrganisationRequestModel organitationModel)
        {
            await _organisationRepository.AddOrganisation(organitationModel);
            return Ok(organitationModel);
        }
        [HttpGet("get all organisation")]
        public async Task<IActionResult> GetAllOrganisations()
        {
           var getOrg = await _organisationRepository.GetOrganisation();
            if (getOrg == null)
            {
                return NotFound();
            }
            return Ok(getOrg);
        }
    }
}
