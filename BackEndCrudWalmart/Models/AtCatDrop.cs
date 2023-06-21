using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatDrop
{
    public int? UniqueNumber { get; set; }

    public int DropNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? DropCode { get; set; }

    public byte? SelectedDropFlag { get; set; }

    public virtual ICollection<AtCatDropDesc> AtCatDropDescs { get; set; } = new List<AtCatDropDesc>();
}
