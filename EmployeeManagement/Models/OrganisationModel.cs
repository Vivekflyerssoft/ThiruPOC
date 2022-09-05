using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class OrganisationModel
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       public ICollection<DepartmentModel> Department { get; set; }
    }
}
