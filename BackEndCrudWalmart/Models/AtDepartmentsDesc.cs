using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtDepartmentsDesc
{
    public int Department { get; set; }

    public string LanguageCode { get; set; } = null!;

    public string? RemarksAck { get; set; }

    public virtual AtDepartment DepartmentNavigation { get; set; } = null!;
}
