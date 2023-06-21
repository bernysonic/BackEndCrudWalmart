using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtBoardSelectionD
{
    public int? Id { get; set; }

    public int IdBoard { get; set; }

    public int? ModelNumber { get; set; }

    public string? Status { get; set; }

    public string? NoteShopping { get; set; }

    public string? NoteAbasto { get; set; }
}
