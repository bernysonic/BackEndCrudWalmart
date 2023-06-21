using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatDropDesc
{
    public int DropNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatDrop DropNumberNavigation { get; set; } = null!;
}
