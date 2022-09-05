using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class EmployeeApiResponseModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public int DepId { get; set; }
        public string Department { get; set; }
        public string OrgName { get; set; }

    }
}
