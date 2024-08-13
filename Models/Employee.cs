using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagementApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeCode { get; set; }

        [Required]
        public int DepartmentId { get; set; } // Liên kết với phòng ban

        public string Rank { get; set; }

        public Department? Department { get; set; } // Phòng ban của nhân viên, không cần thiết có [Required]
    }


}
