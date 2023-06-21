using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtCatDepartmentUser
{
    public int Department { get; set; }

    public string RelationType { get; set; } = null!;

    public int? ResponsibleCompanyCdsnumber { get; set; }

    public int ResponsiblePersonCdsnumber { get; set; }
}
