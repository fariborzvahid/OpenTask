﻿using OpenTask.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Entities;

public class Tag : BaseModel
{
    public string Name { get; set; }
    public string Color { get; set; }

    public List<WorkUnit> WorkUnits { get; } = [];
}
