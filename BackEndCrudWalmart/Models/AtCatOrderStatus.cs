using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatOrderStatus
{
    public int StatusNumber { get; set; }

    public byte? Status { get; set; }

    public string? StatusCode { get; set; }

    public int? UniqueNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public virtual ICollection<AtCatOrderStatusDesc> AtCatOrderStatusDescs { get; set; } = new List<AtCatOrderStatusDesc>();
}
