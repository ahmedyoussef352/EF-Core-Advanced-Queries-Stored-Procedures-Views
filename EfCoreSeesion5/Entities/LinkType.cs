using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class LinkType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<PostLink> PostLinks { get; set; } = new List<PostLink>();
}
