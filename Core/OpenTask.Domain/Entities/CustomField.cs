using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class CustomField : BaseModel
{
    public string Name { get; set; }
    public string DataType { get; set; }
    public ICollection<CustomFieldOption> CustomFieldOptions { get; } = new List<CustomFieldOption>();
}
