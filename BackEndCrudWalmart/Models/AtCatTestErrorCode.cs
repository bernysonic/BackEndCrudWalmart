using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatTestErrorCode
{
    public int? UniqueNumber { get; set; }

    public int ErrorCode { get; set; }

    public int? AttachedErrorCode { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Level { get; set; }

    public byte? Environment { get; set; }

    public virtual ICollection<AtCatTestErrorCodesDesc> AtCatTestErrorCodesDescs { get; set; } = new List<AtCatTestErrorCodesDesc>();
}
