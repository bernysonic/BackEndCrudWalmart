using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatProductDesc
{
    public int ProductType { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatProduct ProductTypeNavigation { get; set; } = null!;
}
