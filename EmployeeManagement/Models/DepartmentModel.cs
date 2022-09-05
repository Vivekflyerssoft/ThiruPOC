using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public OrganisationModel OrganisationModel { get; set; }    
        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
