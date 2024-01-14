using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTask.Domain.Core;

public abstract class BaseModel
{
    [Key]
    [Required]
    public Guid ID { get; set; }=Guid.NewGuid();
    public DateTime CreateDate { get; set; }
    public DateTime ModifyDate { get; set; }
    public bool IsDelete { get; set; } = false;

}
