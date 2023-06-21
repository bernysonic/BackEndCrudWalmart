using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatMeasurementBlockDesc
{
    public int BlockNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatMeasurementBlock BlockNumberNavigation { get; set; } = null!;
}
