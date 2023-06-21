using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatFabricGroupDesc
{
    public int FabricGroupNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatFabricGroup FabricGroupNumberNavigation { get; set; } = null!;
}
