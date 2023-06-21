using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtFabricApproval
{
    public int UniqueNumber { get; set; }

    public int? OrderNumber { get; set; }

    public int? UserNumber { get; set; }

    public short? ProcessNumber { get; set; }

    public byte? Season { get; set; }

    public int? Cpdnumber { get; set; }

    public int? ModelNumber { get; set; }

    public int? ProcessColorCode { get; set; }

    public short? FabricSequenceNumber { get; set; }

    public byte? VendorResult { get; set; }

    public DateTime? ResultDate { get; set; }

    public DateTime? SendDate { get; set; }

    public byte? BuyerResult { get; set; }

    public DateTime? BuyerApprovalDate { get; set; }

    public byte? ColumnUpdated { get; set; }

    public int? ManufacturerCdscode { get; set; }

    public byte? Environment { get; set; }

    public short? SeasonYear { get; set; }

    public string? StyleNumberApp { get; set; }

    public int? NumberSample { get; set; }

    public string? Note { get; set; }
}
