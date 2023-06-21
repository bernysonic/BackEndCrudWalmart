using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProd
{
    public int OrderNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? Department { get; set; }

    public short? PackageSet { get; set; }

    public int? BuyerCdsnumber { get; set; }

    public string? SetPackageReferenceNumber { get; set; }

    public short? SeasonYear { get; set; }

    public byte? Season { get; set; }

    public int? Range { get; set; }

    public int? StatusNumber { get; set; }

    public byte? Status { get; set; }

    public int? ReasoncodetoupdateOrder { get; set; }

    public int? VendorCdsno { get; set; }

    public int? VendorOfficeCode { get; set; }

    public int? ResponsibleMerchandiserCdsnumber { get; set; }

    public string? CurrencyCode { get; set; }

    public int? DeliveryType { get; set; }

    public short? OrderType { get; set; }

    public int? UniqueNumber { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public DateTime? CancelDate { get; set; }

    public decimal? Commission { get; set; }

    public int? BrandNumber { get; set; }

    public int? Origin { get; set; }

    public int? CountryOrigin { get; set; }

    public virtual ICollection<AtOrderProdFabric> AtOrderProdFabrics { get; set; } = new List<AtOrderProdFabric>();

    public virtual ICollection<AtOrderProdInfo> AtOrderProdInfos { get; set; } = new List<AtOrderProdInfo>();

    public virtual AtOrderProdModel? AtOrderProdModel { get; set; }

    public virtual ICollection<AtOrderProdProcess> AtOrderProdProcesses { get; set; } = new List<AtOrderProdProcess>();

    public virtual ICollection<AtOrderProdSize> AtOrderProdSizes { get; set; } = new List<AtOrderProdSize>();
}
