using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatFabricGroup
{
    public int? UniqueNumber { get; set; }

    public int FabricGroupNumber { get; set; }

    public byte? Code { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? YarnNumber { get; set; }

    public byte? Environment { get; set; }

    public string? FabricGroupcode { get; set; }

    public byte? Fabricwidth { get; set; }

    public byte? Openwidth { get; set; }

    public int? DivTelaNo { get; set; }

    public string? FabricGroupcode2 { get; set; }

    public virtual ICollection<AtCatFabricGroupDesc> AtCatFabricGroupDescs { get; set; } = new List<AtCatFabricGroupDesc>();
}
