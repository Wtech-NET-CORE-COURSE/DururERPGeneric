using Durur.Modules.Generic.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Configurations
{
    public class EmployeeCompanyPositionConfiguration : IEntityTypeConfiguration<EmployeeCompanyPosition>
    {
        public void Configure(EntityTypeBuilder<EmployeeCompanyPosition> builder)
        {
            builder.HasKey(w => new { w.Department_ID, w.Position_ID, w.Employee_ID });

            builder.Property(w=>w.Department_ID).



            builder.HasMany(w => w.Departments).WithOne(w=>w.EmployeePosition).HasForeignKey("Department_ID");

            builder.HasMany(w => w.Positions).WithOne(w => w.EmployeeCompanyPosition).HasForeignKey("Position_ID");

            builder.HasMany(w => w.Employees).WithOne(w => w.Position).HasForeignKey("Employee_ID");

            builder.ToTable("Employee_CompanyPositions");
        }
    }
}
