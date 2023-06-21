using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtFichaTecnicaAccesorio
{
    public int ModelNumber { get; set; }

    public short RowNumber { get; set; }

    public int? AccessoryNumber { get; set; }

    public short? MaterialNumber { get; set; }

    public int? ContentNumber { get; set; }

    public string? WhereUsedDescription { get; set; }

    public int? Notes { get; set; }

    public int? Qfabric { get; set; }

    public int? LabDip { get; set; }

    public virtual AtFichaTecnica ModelNumberNavigation { get; set; } = null!;
}
