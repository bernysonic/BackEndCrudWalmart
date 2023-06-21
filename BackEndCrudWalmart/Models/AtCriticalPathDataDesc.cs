using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCriticalPathDataDesc
{
    public int JobNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCriticalPathDatum JobNumberNavigation { get; set; } = null!;
}
