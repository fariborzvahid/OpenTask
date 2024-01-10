using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

/// <summary>
/// The work unit.
/// </summary>
public class WorkUnit
{
    /// <summary>
    /// Gets or Sets the id.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Gets or Sets the name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Gets or Sets the description.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Gets or Sets the status.
    /// </summary>
    public string Status { get; set; }
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
    public List<WorkLog> WorkLogs { get; } = [];
    /// <summary>
    /// Gets the resources.
    /// </summary>
    public List<Resource> Resources { get; } = [];
    /// <summary>
    /// Gets the comments.
    /// </summary>
    public List<Comment> Comments { get; } = [];
    /// <summary>
    /// Gets the events.
    /// </summary>
    public List<Event> Events { get; } = [];
}
