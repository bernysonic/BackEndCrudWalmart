using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtDepartmentsDet
{
    public int Department { get; set; }

    public int AttachedDept { get; set; }

    public byte Level { get; set; }

    public virtual AtDepartment DepartmentNavigation { get; set; } = null!;
}
