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
        }
    }
}
