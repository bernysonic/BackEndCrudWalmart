using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdModel
{
    public int OrderNumber { get; set; }

    public byte PackageNumber { get; set; }

    public int ModelNumber { get; set; }

    public int? Color { get; set; }

    public int? Department { get; set; }

    public decimal? NoofItems { get; set; }

    public byte? ContentNumber { get; set; }

    public virtual AtOrderProd OrderNumberNavigation { get; set; } = null!;
}
