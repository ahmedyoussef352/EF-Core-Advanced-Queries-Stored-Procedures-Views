using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class TransferHistory
{
    public int TransferId { get; set; }

    public int? FromAccountId { get; set; }

    public int? ToAccountId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }
}
