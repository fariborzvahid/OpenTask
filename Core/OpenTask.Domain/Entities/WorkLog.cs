using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class WorkLog : BaseModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Hours { get; set; }
    public Resource Resource { get; set; } = null!;
    public WorkUnit WorkUnit { get; set; } = null!;
}
