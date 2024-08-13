using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRManagementApp.Models;

public partial class HrManageContext : DbContext
{
    public HrManageContext()
    {
    }

    public HrManageContext(DbContextOptions<HrManageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DepartmentTbl> DepartmentTbls { get; set; }

    public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-R7PG95R\\SQLEXPRESS;Initial Catalog=HR_Manage;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentTbl>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED008B8876");

            entity.ToTable("Department_Tbl");

            entity.Property(e => e.DepartmentCode).HasMaxLength(50);
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(100);
        });

        modelBuilder.Entity<EmployeeTbl>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11840D5670");

            entity.ToTable("Employee_Tbl");

            entity.Property(e => e.EmployeeCode).HasMaxLength(50);
            entity.Property(e => e.EmployeeName).HasMaxLength(100);
            entity.Property(e => e.Rank).HasMaxLength(50);

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeTbls)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK__Employee___Depar__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
