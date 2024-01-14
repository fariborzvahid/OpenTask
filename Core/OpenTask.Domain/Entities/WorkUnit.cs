using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

/// <summary>
/// The work unit.
/// </summary>
public class WorkUnit : BaseModel
{
    /// <summary>
    /// Gets or Sets the title.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Gets or Sets the description.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Gets or Sets the status.
    /// </summary>
    public string Status { get; set; }
    public Project Project { get; set; }
    public WorkUnitType WorkUnitType { get; set; }

    public Goal? Goal { get; set; }
    /// <summary>
    /// Gets or Sets the parent work unit.
    /// </summary>
    public WorkUnit? ParentWorkUnit { get; set; } = null;
    /// <summary>
    /// Gets the child work units.
    /// </summary>
    public List<WorkUnit> ChildWorkUnits { get; } = [];
    /// <summary>
    /// Gets the tags.
    /// </summary>
    public List<Tag> Tags { get; } = [];
    /// <summary>
    /// Gets the work logs.
    /// </summary>
    public ICollection<WorkLog> WorkLogs { get; } = new List<WorkLog>();
    /// <summary>
    /// Gets the resources.
    /// </summary>
    public ICollection<Resource> Resources { get; } = new List<Resource>();
    /// <summary>
    /// Gets the comments.
    /// </summary>
    public ICollection<Comment> Comments { get; } = new List<Comment>();
    /// <summary>
    /// Gets the events.
    /// </summary>
    public ICollection<Event> Events { get; } = new List<Event>();
}
