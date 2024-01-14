using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace OpenTask.Persistence.Configurations;

public class WorkUnitConfiguration : IEntityTypeConfiguration<WorkUnit>
{
    public void Configure(EntityTypeBuilder<WorkUnit> builder)
    {
        builder
        .HasMany(e => e.Comments)
        .WithOne(e => e.WorkUnit)
        .HasForeignKey(e => e.TaskId)
        .IsRequired();
        builder.HasKey(p => p.ID);
        builder.Property(e => e.ID).HasDefaultValue(Guid.NewGuid());
    }
}
