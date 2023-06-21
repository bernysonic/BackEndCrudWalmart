using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdSize
{
    public int OrderNumber { get; set; }

    public short InformationSequenceNumber { get; set; }

    public int Size { get; set; }

    public int DropNumber { get; set; }

    public string? Sequence { get; set; }

    public string? SubSequence { get; set; }

    public decimal? Percentage { get; set; }

    public decimal? NoofItems { get; set; }

    public decimal? Assorty { get; set; }

    public decimal? ManufacturerPrice { get; set; }

    public decimal? Commission { get; set; }

    public decimal? VendorPrice { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? InsuranceCost { get; set; }

    public decimal? Transportationcost { get; set; }

    public decimal? Storeprice { get; set; }

    public decimal? VendorCloserPack { get; set; }

    public string? Identnumber { get; set; }

    public string? Pomno { get; set; }

    public string? ItemNumber { get; set; }

    public string? Barcode { get; set; }

    public short? LotNumber { get; set; }

    public string? CodTax { get; set; }

    public virtual AtOrderProd OrderNumberNavigation { get; set; } = null!;
}
