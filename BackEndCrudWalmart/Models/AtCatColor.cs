using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatColor
{
    public int? UniqueNumber { get; set; }

    public int Color { get; set; }

    public byte? DataActiveFlag { get; set; }

    public string? ColorCode { get; set; }

    public byte? ColumnUpdated { get; set; }

    public string? RgbcolorHexcode { get; set; }

    public byte? Environment { get; set; }

    public byte? Red { get; set; }

    public byte? Green { get; set; }

    public byte? Blue { get; set; }

    public string? CodePantone { get; set; }

    public string? NameFile { get; set; }

    public virtual ICollection<AtCatColorDesc> AtCatColorDescs { get; set; } = new List<AtCatColorDesc>();
}
