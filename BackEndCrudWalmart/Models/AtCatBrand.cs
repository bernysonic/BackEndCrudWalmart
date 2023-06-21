using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatBrand
{
    public int UniqueNumber { get; set; }

    public int BrandNumber { get; set; }

    public int? BuyerCdsnumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte Environment { get; set; }

    public string? BrandCode { get; set; }

    public virtual ICollection<AtCatBrandDesc> AtCatBrandDescs { get; set; } = new List<AtCatBrandDesc>();
}
