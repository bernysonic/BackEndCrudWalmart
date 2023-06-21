using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCriticalPathDataTemplateDet
{
    public int TamplateNumber { get; set; }

    public int RowNumber { get; set; }

    public string? ResponsibleGroup { get; set; }

    public int? JobNumber { get; set; }

    public byte? Planning { get; set; }

    public byte? Obligatory { get; set; }

    public string? Formula { get; set; }

    public virtual AtCriticalPathDataTemplate TamplateNumberNavigation { get; set; } = null!;
}
