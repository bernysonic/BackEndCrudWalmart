using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdProcessTest
{
    public int OrderNumber { get; set; }

    public short ProcessNumber { get; set; }

    public short RowNumber { get; set; }

    public int? TestFormNumber { get; set; }

    public byte? Selection { get; set; }

    public byte? TestResultFlag { get; set; }

    public virtual AtOrderProdProcess AtOrderProdProcess { get; set; } = null!;
}
