using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatAccesory
{
    public int? UniqueNumber { get; set; }

    public int AccessoryNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? AccessoryCode { get; set; }
}
