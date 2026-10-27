using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class BankAccount
{
    public int AccountId { get; set; }

    public string? AccountHolder { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastModified { get; set; }
}
