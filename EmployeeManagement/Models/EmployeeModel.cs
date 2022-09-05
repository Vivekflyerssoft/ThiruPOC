using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }
  
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Email Id cannot be empty")]
       
        public string EmailId { get; set; }
        [Phone(ErrorMessage = "Phone number is not valid. The phone number is must an integer")]
        
        [MaxLength(10),MinLength(10)]
        
        public string PhoneNo { get; set; }
        [Required]
        public string Designation { get; set; }
        public int Salary { get; set; }
        public int DepId { get; set; }
        public DepartmentModel Department { get; set; }
    }
}
