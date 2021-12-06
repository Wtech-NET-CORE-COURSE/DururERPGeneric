using Durur.Modules.Generic.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(w=>w.Department_ID);
            builder.Property(w=>w.Department_ID).UseIdentityColumn();

            builder.Property(w => w.Department_Name).HasMaxLength(40).IsRequired();


            //builder.HasOne(w => w.EmployeePosition).WithMany(w => w.Departments);

            //builder.HasOne(w=>w.Location).WithMany(w=>w.Departments);

            builder.ToTable("Departments");
        }
    }
}
