using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatMeasurementBlockPlaceDet
{
    public int BlockNumber { get; set; }

    public short RowNumber { get; set; }

    public int DropNumber { get; set; }

    public int Size { get; set; }

    public decimal? MeasurementValue1 { get; set; }

    public decimal? GradingValue1 { get; set; }

    public decimal? MeasurementValue { get; set; }

    public decimal? GradingValue { get; set; }

    public virtual AtCatMeasurementBlockPlace AtCatMeasurementBlockPlace { get; set; } = null!;
}
