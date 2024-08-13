using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRManagementApp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        [Required]
        public string DepartmentCode { get; set; }

        [Required]
        public string Location { get; set; }

        public int NumberOfPersonals { get; set; }

        // Đây là danh sách nhân viên trong phòng ban, không cần bắt buộc khi tạo mới phòng ban
        public List<Employee>? Employees { get; set; }
    }



}
