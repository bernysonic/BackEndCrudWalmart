using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSeason
{
    public int? UniqueNumber { get; set; }

    public byte Season { get; set; }

    public string? SeasonCode { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? ColumnUpdated { get; set; }

    public string? Awss { get; set; }

    public byte? Environment { get; set; }

    public virtual ICollection<AtCatSeasonDesc> AtCatSeasonDescs { get; set; } = new List<AtCatSeasonDesc>();
}
