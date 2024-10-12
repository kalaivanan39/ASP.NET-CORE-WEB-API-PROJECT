using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public required String Place { get; set; }

        public String? Contact { get; set; }

        public required string Email { get; set; }

        public decimal Salary { get; set; }
    }
}
