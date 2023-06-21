using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdProcess
{
    public int OrderNumber { get; set; }

    public short ProcessNumber { get; set; }

    public int? StatusNumber { get; set; }

    public int? Color { get; set; }

    public byte? Status { get; set; }

    public int? ManufacturerCdscode { get; set; }

    public int? ModelNumber { get; set; }

    public DateTime? ManufacturersLoadingDate { get; set; }

    public int? ManufacturersResponsiblepersonCdsnumber { get; set; }

    public byte? ManufacturerOrderConfirmationFlag { get; set; }

    public DateTime? ManufacturersApprovalDate { get; set; }

    public byte? PackageNumber { get; set; }

    public byte? ManufacturerDenyFlag { get; set; }

    public DateTime? OrderDateatCpd { get; set; }

    public DateTime? OrderDateatCpd2 { get; set; }

    public virtual ICollection<AtOrderProdCpd> AtOrderProdCpds { get; set; } = new List<AtOrderProdCpd>();

    public virtual ICollection<AtOrderProdProcessTest> AtOrderProdProcessTests { get; set; } = new List<AtOrderProdProcessTest>();

    public virtual AtOrderProd OrderNumberNavigation { get; set; } = null!;
}
