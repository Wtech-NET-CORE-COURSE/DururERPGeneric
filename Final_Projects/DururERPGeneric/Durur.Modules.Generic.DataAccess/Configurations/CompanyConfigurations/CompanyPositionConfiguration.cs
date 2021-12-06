using Durur.Modules.Generic.Entities.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Configurations
{
    public class CompanyPositionConfiguration : IEntityTypeConfiguration<CompanyPosition>
    {
        public void Configure(EntityTypeBuilder<CompanyPosition> builder)
        {
            builder.HasKey(w=>w.Company_Position_ID);
            builder.Property(w => w.Company_Position_ID).UseIdentityColumn();
            builder.HasOne(w => w.EmployeeCompanyPosition).WithMany(w=>w.Positions);

            builder.Property(w => w.Company_Position_Name).HasMaxLength(30);

            builder.ToTable("CompanyPositions");
        }
    }
}
