using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class Comment : BaseModel
{
    public int TaskId { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
    public WorkUnit WorkUnit { get; set; } = null!;
}
