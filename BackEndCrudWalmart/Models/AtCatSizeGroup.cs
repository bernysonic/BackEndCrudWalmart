using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSizeGroup
{
    public int? UniqueNumber { get; set; }

    public int SizeGroupNumber { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public string? SizeGroupCode { get; set; }

    public virtual ICollection<AtCatSizeGroupDesc> AtCatSizeGroupDescs { get; set; } = new List<AtCatSizeGroupDesc>();

    public virtual ICollection<AtCatSizeGroupDet> AtCatSizeGroupDets { get; set; } = new List<AtCatSizeGroupDet>();
}
