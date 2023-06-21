using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdCpd
{
    public int OrderNumber { get; set; }

    public int JobNumber { get; set; }

    public short ProcessNumber { get; set; }

    public int Cpdnumber { get; set; }

    public byte? Selection { get; set; }

    public short? ProcessType { get; set; }

    public string? Formula { get; set; }

    public DateTime? PlanningDate { get; set; }

    public string? ResponsibleGroup { get; set; }

    public int? ProcessUniqueNumber { get; set; }

    public string? JobDescription { get; set; }

    public byte? ManufacturerDenyFlag { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<AtOrderProdCpdforLot> AtOrderProdCpdforLots { get; set; } = new List<AtOrderProdCpdforLot>();

    public virtual AtOrderProdProcess AtOrderProdProcess { get; set; } = null!;
}
