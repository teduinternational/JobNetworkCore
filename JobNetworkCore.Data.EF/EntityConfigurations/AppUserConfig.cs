using JobNetworkCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobNetworkCore.Data.EF.EntityConfigurations
{
    public class AppUserConfig
    {
        public AppUserConfig(EntityTypeBuilder<AppUser> entityBuilder)
        {
            entityBuilder.ToTable("AppUsers");
            entityBuilder.Property(x => x.FullName).IsRequired().HasMaxLength(128);

        }
    }
}
