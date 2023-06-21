using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatYarnTypeDesc
{
    public int YarnTypeNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public string? ShortDescription { get; set; }

    public virtual AtCatYarnType YarnTypeNumberNavigation { get; set; } = null!;
}
