using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class EmployeeRequestModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public int DepId { get; set; }
    }
}
