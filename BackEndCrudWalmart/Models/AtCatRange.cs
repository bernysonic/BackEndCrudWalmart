using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatRange
{
    public int? UniqueNumber { get; set; }

    public int Range { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? RangeCode { get; set; }

    public string? RemarksAck { get; set; }
}
