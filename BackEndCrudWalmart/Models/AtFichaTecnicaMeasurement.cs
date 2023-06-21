using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtFichaTecnicaMeasurement
{
    public int ModelNumber { get; set; }

    public short RowNumber { get; set; }

    public int? DropNumber { get; set; }

    public int? MeasurementSequenceNumber { get; set; }

    public int? Size { get; set; }

    public string? Flag { get; set; }

    public string? Indicator { get; set; }

    public byte? Tolerance { get; set; }

    public decimal? ToleranceValue1 { get; set; }

    public string? RemarksAck { get; set; }

    public decimal? Value1 { get; set; }

    public decimal? GradingValue1 { get; set; }

    public decimal? ToleranceValue { get; set; }

    public decimal? Value { get; set; }

    public decimal? GradingValue { get; set; }

    public virtual AtFichaTecnica ModelNumberNavigation { get; set; } = null!;
}
