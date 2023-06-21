using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtFichaTecnica
{
    public int? UniqueNumber { get; set; }

    public int ModelNumber { get; set; }

    public string? DesignNumber { get; set; }

    public string? DesignDescription { get; set; }

    public int? ColumnUpdated { get; set; }

    public int? Environment { get; set; }

    public string? StyleNumber { get; set; }

    public int? ProductType { get; set; }

    public int? Department { get; set; }

    public int? BuyerCdsnumber { get; set; }

    public int? StyleOwner { get; set; }

    public int? StyleOwnerCdsnumber { get; set; }

    public short? SeasonYear { get; set; }

    public int? Season { get; set; }

    public int? Range { get; set; }

    public int? BlockNumber { get; set; }

    public int? UserNumber { get; set; }

    public string? Note { get; set; }

    public string? PicturePathonthesystem { get; set; }

    public int? VendorCdsno { get; set; }

    public decimal? PreviousPrice { get; set; }

    public string? CurrencyCode { get; set; }

    public int? BrandNumber { get; set; }

    public string? MeasurementUnitCode { get; set; }

    public decimal? PriceTarget { get; set; }

    public decimal? PriceTotal { get; set; }

    public int? PieceProgam { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? SignatureShopping { get; set; }

    public string? SignatureAbasto { get; set; }

    public string? SignatureDesign { get; set; }

    public virtual ICollection<AtFichaTecnicaAccesorio> AtFichaTecnicaAccesorios { get; set; } = new List<AtFichaTecnicaAccesorio>();

    public virtual ICollection<AtFichaTecnicaMeasurement> AtFichaTecnicaMeasurements { get; set; } = new List<AtFichaTecnicaMeasurement>();

    public virtual ICollection<AtFichaTecnicaPrint> AtFichaTecnicaPrints { get; set; } = new List<AtFichaTecnicaPrint>();
}
