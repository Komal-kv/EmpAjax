using System.ComponentModel.DataAnnotations;

namespace EmpAjaxJquery.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Notes { get; set; }
    }
}
