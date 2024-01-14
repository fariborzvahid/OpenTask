using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class Project : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<WorkUnit> WorkUnits { get; } = new List<WorkUnit>();
}
