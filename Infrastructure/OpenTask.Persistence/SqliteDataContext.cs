using Microsoft.EntityFrameworkCore;
using OpenTask.Application.Common;
using OpenTask.Domain.Entities;
using OpenTask.Persistence.Configurations;

namespace OpenTask.Persistence;
public class SqliteDataContext : DbContext ,IOpenTaskDataContext
{
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=OpenTaskContext.db;");
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WorkUnitConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }

    public Task SaveChangesAsync() => base.SaveChangesAsync();


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
}
