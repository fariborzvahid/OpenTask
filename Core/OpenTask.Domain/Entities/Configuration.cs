using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class Configuration : BaseModel
{
    public string Key { get; set; }
    public string Value { get; set; }
    public bool IsSystemConfiguration { get; set; }
}
