using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtStandardApprovalforLot
{
    public int UniqueNumber { get; set; }

    public int? OrderNumber { get; set; }

    public short? InformationSequenceNumber { get; set; }

    public short? ProcessNumber { get; set; }

    public int? Cpdnumber { get; set; }

    public DateTime? ProcessDate { get; set; }

    public int? Approval { get; set; }

    public string? Note { get; set; }
}
