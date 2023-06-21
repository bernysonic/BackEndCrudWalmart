using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatFabricType
{
    public int FabricGroupNumber { get; set; }

    public short RowNumber { get; set; }

    public string? FabricType1 { get; set; }

    public byte? DataActiveFlag { get; set; }

    public decimal? Fabricweight { get; set; }

    public byte? Fabricweightunit { get; set; }

    public string? Composition { get; set; }

    public short? FabricType { get; set; }

    public int? YarnTypeNumber1 { get; set; }

    public int? YarnTypeNumber2 { get; set; }

    public int? YarnTypeNumber3 { get; set; }

    public int? YarnTypeNumber4 { get; set; }

    public int? YarnTypeNumber5 { get; set; }

    public decimal? YarnTypePercentage1 { get; set; }

    public decimal? YarnTypePercentage2 { get; set; }

    public decimal? YarnTypePercentage3 { get; set; }

    public decimal? YarnTypePercentage4 { get; set; }

    public decimal? YarnTypePercentage5 { get; set; }

    public virtual ICollection<AtCatFabricTypeDesc> AtCatFabricTypeDescs { get; set; } = new List<AtCatFabricTypeDesc>();

    public virtual ICollection<AtCatFabricTypeYarnNumber> AtCatFabricTypeYarnNumbers { get; set; } = new List<AtCatFabricTypeYarnNumber>();
}
