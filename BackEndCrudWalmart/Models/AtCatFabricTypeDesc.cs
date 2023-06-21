using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatFabricTypeDesc
{
    public int FabricGroupNumber { get; set; }

    public short RowNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatFabricType AtCatFabricType { get; set; } = null!;
}
