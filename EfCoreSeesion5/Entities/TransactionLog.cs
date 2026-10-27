using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class TransactionLog
{
    public int LogId { get; set; }

    public int? AccountId { get; set; }

    public string? TransactionType { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Status { get; set; }
}
