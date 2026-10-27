using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class ChangeLog
{
    public int ChangeLogId { get; set; }

    public string? ActionType { get; set; }

    public string? TableName { get; set; }

    public int? UserId { get; set; }

    public string? Title { get; set; }

    public int? OldValue { get; set; }

    public int? NewValue { get; set; }
}
