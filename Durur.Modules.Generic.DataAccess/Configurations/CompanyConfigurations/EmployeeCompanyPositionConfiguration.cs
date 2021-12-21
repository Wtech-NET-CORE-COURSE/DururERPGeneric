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

            //builder.HasMany(w => w.Departments).WithOne(w => w.EmployeePosition);

            //builder.HasMany(w => w.Positions).WithOne(w => w.EmployeeCompanyPosition);

            //builder.HasMany(w => w.Employees).WithOne(w => w.Position);
            //builder.Property(w => w.CreatedDate).HasAnnotation("Order", 5);
            //builder.Property(w=>w.LastUpdatedDate).HasAnnotation("Order",6);



            builder.ToTable("Employee_CompanyPositions");
        }
    }
}
