using Compi.DesignPatterns.Specification.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.Specification.Infrastructure.Repositories.Maps
{
    public class ProjectMaps : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder
                .ToTable("Projects");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
              .Property(x => x.Name)
              .HasMaxLength(200);


        }
    }
}
