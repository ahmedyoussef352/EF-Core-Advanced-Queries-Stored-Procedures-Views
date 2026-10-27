using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class CommentsAuditLog
{
    public int AuditId { get; set; }

    public int? CommentId { get; set; }

    public string OperationType { get; set; } = null!;

    public string? OldText { get; set; }

    public string? NewText { get; set; }

    public int? OldScore { get; set; }

    public int? NewScore { get; set; }

    public string ChangedBy { get; set; } = null!;

    public DateTime? ChangeDate { get; set; }
}
