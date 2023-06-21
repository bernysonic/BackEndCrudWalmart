using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatPrintandEmbroidery
{
    public int? UniqueNumber { get; set; }

    public int PrintNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public byte? Type { get; set; }

    public string? PrintCode { get; set; }

    public virtual ICollection<AtCatPrintandEmbroideryDesc> AtCatPrintandEmbroideryDescs { get; set; } = new List<AtCatPrintandEmbroideryDesc>();
}
