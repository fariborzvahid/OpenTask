using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class CustomFieldOptions
{
    public int Id { get; set; }
    public int CustomFieldId { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}
