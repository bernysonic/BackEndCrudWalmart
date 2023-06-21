using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSeasonDesc
{
    public byte Season { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtCatSeason SeasonNavigation { get; set; } = null!;
}
