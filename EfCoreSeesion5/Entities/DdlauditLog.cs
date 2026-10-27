using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class DdlauditLog
{
    public int EventId { get; set; }

    public string? EventType { get; set; }

    public DateTime? EventDate { get; set; }

    public string? LoginName { get; set; }

    public string? Tsqlcommand { get; set; }

    public string? DatabaseName { get; set; }
}
