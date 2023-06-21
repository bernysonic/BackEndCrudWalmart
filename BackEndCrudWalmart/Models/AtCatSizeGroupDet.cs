using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatSizeGroupDet
{
    public int SizeGroupNumber { get; set; }

    public int Size { get; set; }

    public virtual AtCatSizeGroup SizeGroupNumberNavigation { get; set; } = null!;
}
