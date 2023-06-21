using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCriticalPathDatum
{
    public int? UniqueNumber { get; set; }

    public int JobNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public short? ProcessType { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? ProcessTypeCode { get; set; }

    public byte? Email { get; set; }

    public byte? Buyerapprovaltype { get; set; }

    public byte? BasedonLot { get; set; }

    public virtual ICollection<AtCriticalPathDataDesc> AtCriticalPathDataDescs { get; set; } = new List<AtCriticalPathDataDesc>();
}
