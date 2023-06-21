using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatAccesoryDesc
{
    public int AccessoryNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatAccesory AccessoryNumberNavigation { get; set; } = null!;
}
