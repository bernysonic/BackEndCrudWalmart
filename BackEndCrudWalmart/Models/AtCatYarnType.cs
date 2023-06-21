using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatYarnType
{
    public int? UniqueNumber { get; set; }

    public int YarnTypeNumber { get; set; }

    public int? YarnTypeCode { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public decimal? Percentage { get; set; }

    public byte? Environment { get; set; }

    public virtual ICollection<AtCatYarnTypeDesc> AtCatYarnTypeDescs { get; set; } = new List<AtCatYarnTypeDesc>();
}
