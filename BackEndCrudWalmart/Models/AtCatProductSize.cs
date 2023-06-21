using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatProductSize
{
    public int ProductType { get; set; }

    public int BlockNumber { get; set; }

    public virtual AtCatProduct ProductTypeNavigation { get; set; } = null!;
}
