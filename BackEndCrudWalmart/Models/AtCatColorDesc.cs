using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatColorDesc
{
    public int Color { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatColor ColorNavigation { get; set; } = null!;
}
