using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatBrandDesc
{
    public int BrandNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatBrand BrandNumberNavigation { get; set; } = null!;
}
