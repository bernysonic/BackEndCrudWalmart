using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatProduct
{
    public int? UniqueNumber { get; set; }

    public int ProductType { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public int? AttachedProductType { get; set; }

    public byte? Level { get; set; }

    public int? IdProductTypeGdm { get; set; }

    public virtual ICollection<AtCatProductDesc> AtCatProductDescs { get; set; } = new List<AtCatProductDesc>();

    public virtual ICollection<AtCatProductDet> AtCatProductDets { get; set; } = new List<AtCatProductDet>();

    public virtual ICollection<AtCatProductSize> AtCatProductSizes { get; set; } = new List<AtCatProductSize>();
}
