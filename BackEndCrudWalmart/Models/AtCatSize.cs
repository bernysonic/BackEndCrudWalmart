using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSize
{
    public int? UniqueNumber { get; set; }

    public int Size { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? SizeCode { get; set; }

    public virtual ICollection<AtCatSizeDesc> AtCatSizeDescs { get; set; } = new List<AtCatSizeDesc>();
}
