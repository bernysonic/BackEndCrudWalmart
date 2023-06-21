using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdFabric
{
    public int OrderNumber { get; set; }

    public short ModelFabricSequenceNumber { get; set; }

    public int? Color { get; set; }

    public int RowNumber { get; set; }

    public int ProcessColorCode { get; set; }

    public int? ModelNumber { get; set; }

    public short? SubTelaPrincipal { get; set; }

    public short? TelasXcolor { get; set; }

    public virtual AtOrderProd OrderNumberNavigation { get; set; } = null!;
}
