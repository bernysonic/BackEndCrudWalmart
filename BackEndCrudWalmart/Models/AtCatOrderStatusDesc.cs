using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatOrderStatusDesc
{
    public int StatusNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatOrderStatus StatusNumberNavigation { get; set; } = null!;
}
