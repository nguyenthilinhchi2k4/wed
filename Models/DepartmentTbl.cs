using System;
using System.Collections.Generic;

namespace HRManagementApp.Models;

public partial class DepartmentTbl
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? DepartmentCode { get; set; }

    public string? Location { get; set; }

    public int? NumberOfPersonals { get; set; }

    public virtual ICollection<EmployeeTbl> EmployeeTbls { get; set; } = new List<EmployeeTbl>();
}
