using Microsoft.EntityFrameworkCore;
using OpenTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Application.Common;

public interface IOpenTaskDataContext
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Configuration> Configurations { get; set; }
    public DbSet<CustomField> CustomFields { get; set; }
    public DbSet<CustomFieldOption> CustomFieldOptions { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventType> EventTypes { get; set; }
    public DbSet<Goal> Goals { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Priority> Priority { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<WorkLog> WorkLogs { get; set; }
    public DbSet<WorkUnit> WorkUnits { get; set; }
    public DbSet<WorkUnitType> WorkUnitTypes { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    Task SaveChangesAsync();
}
