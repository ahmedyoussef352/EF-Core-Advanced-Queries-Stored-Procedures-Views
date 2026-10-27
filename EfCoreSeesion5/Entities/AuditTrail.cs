using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class AuditTrail
{
    public int AuditId { get; set; }

    public string? TableName { get; set; }

    public string? Operation { get; set; }

    public int? RecordId { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? AuditDate { get; set; }

    public string? UserName { get; set; }
}
