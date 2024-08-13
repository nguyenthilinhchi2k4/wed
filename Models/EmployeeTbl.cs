using System;
using System.Collections.Generic;

namespace HRManagementApp.Models;

public partial class EmployeeTbl
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeCode { get; set; }

    public int? DepartmentId { get; set; }

    public string? Rank { get; set; }

    public virtual DepartmentTbl? Department { get; set; }
}
