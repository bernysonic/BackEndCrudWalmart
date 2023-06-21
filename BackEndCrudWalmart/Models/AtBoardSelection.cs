using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtBoardSelection
{
    public int IdBoard { get; set; }

    public DateTime? DateSelec { get; set; }

    public string? Season { get; set; }

    public int? Year { get; set; }

    public int? Origin { get; set; }
}
