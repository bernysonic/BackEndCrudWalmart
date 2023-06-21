using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdInfoDet
{
    public short InformationSequenceNumber { get; set; }

    public int Color { get; set; }

    public int OrderNumber { get; set; }

    public short DetailSequenceNumber { get; set; }

    public int ModelNumber { get; set; }

    public decimal? NoofItems { get; set; }

    public byte? PackageNumber { get; set; }

    public int ManufacturerCdscode { get; set; }

    public virtual AtOrderProdInfo AtOrderProdInfo { get; set; } = null!;

    public virtual ICollection<AtOrderProdInfoDetSize> AtOrderProdInfoDetSizes { get; set; } = new List<AtOrderProdInfoDetSize>();
}
