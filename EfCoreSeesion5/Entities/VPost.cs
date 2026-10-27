using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class VPost
{
    public int PostId { get; set; }

    public long? CommentCount { get; set; }

    public int? TotalCommentScore { get; set; }
}
