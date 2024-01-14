using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class Note : BaseModel
{
    public int TaskId { get; set; }
    public string Content { get; set; }
}
