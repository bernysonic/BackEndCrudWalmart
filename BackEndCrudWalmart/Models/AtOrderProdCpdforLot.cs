using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdCpdforLot
{
    public int OrderNumber { get; set; }

    public short ProcessNumber { get; set; }

    public int Cpdnumber { get; set; }

    public short InformationSequenceNumber { get; set; }

    public DateTime? PlanningDate { get; set; }

    public string? Notes { get; set; }

    public int? ProcessUniqueNumber { get; set; }

    public virtual AtOrderProdCpd AtOrderProdCpd { get; set; } = null!;
}
