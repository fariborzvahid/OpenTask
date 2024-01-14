using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class CustomFieldOption : BaseModel
{
    public string Name { get; set; }
    public string Value { get; set; }
    
    public int CustomFieldId { get; set; }
    public CustomField CustomField { get; set; } = null!;
}
