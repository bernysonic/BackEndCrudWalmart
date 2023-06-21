using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCriticalPathDataTemplate
{
    public int? UniqueNumber { get; set; }

    public int TamplateNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public string? RemarksAck { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public virtual ICollection<AtCriticalPathDataTemplateDet> AtCriticalPathDataTemplateDets { get; set; } = new List<AtCriticalPathDataTemplateDet>();
}
