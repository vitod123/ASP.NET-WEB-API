using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    internal class CarConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Model).WithMany(m => m.Cars).HasForeignKey(c => c.ModelId);
            builder.HasOne(c => c.Engine).WithMany(e => e.Cars).HasForeignKey(c => c.EngineId);
            builder.HasOne(c => c.Make).WithMany(m => m.Cars).HasForeignKey(c => c.MakeId);
            builder.HasOne(c => c.Year).WithMany(m => m.Cars).HasForeignKey(c => c.YearId);
        }
    }
}