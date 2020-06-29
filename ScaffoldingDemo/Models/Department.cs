using System.ComponentModel.DataAnnotations;

namespace ScaffoldingDemo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        
        [MaxLength(50)]
        public string DepartmentName { get; set; }
    }
}
