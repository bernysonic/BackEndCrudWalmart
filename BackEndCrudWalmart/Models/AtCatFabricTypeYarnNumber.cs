using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatFabricTypeYarnNumber
{
    public int FabricGroupNumber { get; set; }

    public short RowNumber { get; set; }

    public int YarnNumber { get; set; }

    public string? YarnTypeCode { get; set; }

    public virtual AtCatFabricType AtCatFabricType { get; set; } = null!;
}
