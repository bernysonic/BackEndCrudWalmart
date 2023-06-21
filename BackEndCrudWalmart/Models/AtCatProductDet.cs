using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatProductDet
{
    public int ProductType { get; set; }

    public int AttachedProductType { get; set; }

    public byte? Level { get; set; }

    public virtual AtCatProduct ProductTypeNavigation { get; set; } = null!;
}
