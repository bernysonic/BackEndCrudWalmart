using System;
using System.Collections.Generic;

namespace BackEndCrudWalmart.Models;

public partial class AtDepartment
{
    public int? UniqueNumber { get; set; }

    public int Department { get; set; }

    public byte? DataActiveFlag { get; set; }

    public byte? Level { get; set; }

    public byte? ColumnUpdated { get; set; }

    public byte? Environment { get; set; }

    public byte? AttachedDept { get; set; }

    public string? TransportationType { get; set; }

    public byte? ShippingType { get; set; }

    public byte? Unit { get; set; }

    public byte? TransportationCostDifference { get; set; }

    public string? HangBox { get; set; }

    public byte? OrderType { get; set; }

    public string? UnitCode { get; set; }

    public int? IdDptoSub { get; set; }

    public virtual ICollection<AtDepartmentsDesc> AtDepartmentsDescs { get; set; } = new List<AtDepartmentsDesc>();

    public virtual ICollection<AtDepartmentsDet> AtDepartmentsDets { get; set; } = new List<AtDepartmentsDet>();
}
