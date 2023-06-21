using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSizeGroupDesc
{
    public int SizeGroupNumber { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatSizeGroup SizeGroupNumberNavigation { get; set; } = null!;
}
