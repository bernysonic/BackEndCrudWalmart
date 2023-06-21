using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtOrderProdProcessTestResult
{
    public short ProcessNumber { get; set; }

    public short RowNumber { get; set; }

    public int OrderNumber { get; set; }

    public byte? TestResultFlag { get; set; }

    public short Resultsequencenumber { get; set; }

    public DateTime? TestDate { get; set; }

    public string? RemarksAck { get; set; }
}
