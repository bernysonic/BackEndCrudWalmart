using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtFichaTecnicaPrint
{
    public int ModelNumber { get; set; }

    public short RowNumber { get; set; }

    public int? ContentNumber { get; set; }

    public byte? Type { get; set; }

    public int? PrintNumber { get; set; }

    public string? WhereUsedDescription { get; set; }

    public string? Notes { get; set; }

    public int? Inks { get; set; }

    public int? Tecniques { get; set; }

    public int? Fabrics { get; set; }

    public int? Threads { get; set; }

    public string? Size { get; set; }

    public virtual AtFichaTecnica ModelNumberNavigation { get; set; } = null!;
}
