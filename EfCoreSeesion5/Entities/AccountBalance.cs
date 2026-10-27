using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class AccountBalance
{
    public int AccountId { get; set; }

    public string? AccountName { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastUpdated { get; set; }
}
