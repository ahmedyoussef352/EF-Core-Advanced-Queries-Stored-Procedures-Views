using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class AuditLog
{
    public int AuditId { get; set; }

    public string? TableName { get; set; }

    public string? OperationType { get; set; }

    public int? UserId { get; set; }

    public DateTime? ChangeDate { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public string? Details { get; set; }
}
