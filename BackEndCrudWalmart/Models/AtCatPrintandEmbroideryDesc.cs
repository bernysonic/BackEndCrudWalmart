using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatPrintandEmbroideryDesc
{
    public int PrintNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatPrintandEmbroidery PrintNumberNavigation { get; set; } = null!;
}
