using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatMeasurementBlockPlaceDesc
{
    public int BlockNumber { get; set; }

    public short RowNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatMeasurementBlockPlace AtCatMeasurementBlockPlace { get; set; } = null!;
}
