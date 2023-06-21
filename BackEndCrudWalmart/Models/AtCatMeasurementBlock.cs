using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatMeasurementBlock
{
    public int? UniqueNumber { get; set; }

    public int BlockNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? BlockCode { get; set; }

    public string? MeasurementUnitCode { get; set; }

    public virtual ICollection<AtCatMeasurementBlockDesc> AtCatMeasurementBlockDescs { get; set; } = new List<AtCatMeasurementBlockDesc>();
}
