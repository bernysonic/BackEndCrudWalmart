using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdInfo
{
    public int OrderNumber { get; set; }

    public short? ReservationNumber { get; set; }

    public int? ManufacturerCdscode { get; set; }

    public short InformationSequenceNumber { get; set; }

    public int? Color { get; set; }

    public DateTime? Reservationdate { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public DateTime? PurchaseOrderDate { get; set; }

    public byte? Cancelled { get; set; }

    public DateTime? CancelDate { get; set; }

    public short? LotDeliveryNumber { get; set; }

    public string? TransportationType { get; set; }

    public DateTime? ShippingDate { get; set; }

    public string? ShippingType { get; set; }

    public decimal? NoofItems { get; set; }

    public decimal? TotalQuantity { get; set; }

    public byte? Unit { get; set; }

    public DateTime? DeliveryAuthorizationDate { get; set; }

    public decimal? Margin { get; set; }

    public DateTime? OrigLoadingDate { get; set; }

    public DateTime? OrigDardate { get; set; }

    public decimal? Origquantity { get; set; }

    public DateTime? ManufacturersLoadingDate { get; set; }

    public byte? TranspAmountC { get; set; }

    public string? HangBox { get; set; }

    public decimal? PackageManufacturerPrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? PackagePrice { get; set; }

    public decimal? PackageInsurancePrice { get; set; }

    public decimal? TransportationPrice { get; set; }

    public decimal? Storeprice { get; set; }

    public string? Notes { get; set; }

    public byte? PackageNumber { get; set; }

    public byte? Repeatorder { get; set; }

    public int? StatusNumber { get; set; }

    public string? StorageareaBookingNumber { get; set; }

    public string? UnitCode { get; set; }

    public string? Identnumber { get; set; }

    public int? StorageareaCdsnumber { get; set; }

    public string? FactoryId { get; set; }

    public int? IdPort { get; set; }

    public virtual ICollection<AtOrderProdInfoDet> AtOrderProdInfoDets { get; set; } = new List<AtOrderProdInfoDet>();

    public virtual AtOrderProd OrderNumberNavigation { get; set; } = null!;
}
