using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatMeasurementBlockPlace
{
    public int BlockNumber { get; set; }

    public short RowNumber { get; set; }

    public short? MesurementPlace { get; set; }

    public string? Indicator { get; set; }

    public byte? Tolerance { get; set; }

    public decimal? ToleranceValue { get; set; }

    public virtual ICollection<AtCatMeasurementBlockPlaceDesc> AtCatMeasurementBlockPlaceDescs { get; set; } = new List<AtCatMeasurementBlockPlaceDesc>();

    public virtual ICollection<AtCatMeasurementBlockPlaceDet> AtCatMeasurementBlockPlaceDets { get; set; } = new List<AtCatMeasurementBlockPlaceDet>();
}
