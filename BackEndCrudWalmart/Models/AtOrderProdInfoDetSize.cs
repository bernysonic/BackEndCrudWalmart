using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdInfoDetSize
{
    public int OrderNumber { get; set; }

    public short InformationSequenceNumber { get; set; }

    public short DetailSequenceNumber { get; set; }

    public int Size { get; set; }

    public int DropNumber { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? ManufacturerPrice { get; set; }

    public decimal? VendorPrice { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? NoofItems { get; set; }

    public virtual AtOrderProdInfoDet AtOrderProdInfoDet { get; set; } = null!;
}
