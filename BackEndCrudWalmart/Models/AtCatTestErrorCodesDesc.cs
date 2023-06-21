using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatTestErrorCodesDesc
{
    public int ErrorCode { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatTestErrorCode ErrorCodeNavigation { get; set; } = null!;
}
