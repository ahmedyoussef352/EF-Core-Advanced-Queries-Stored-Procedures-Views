using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class PostType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
