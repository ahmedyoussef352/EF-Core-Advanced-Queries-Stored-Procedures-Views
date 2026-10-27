using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class VoteType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();
}
