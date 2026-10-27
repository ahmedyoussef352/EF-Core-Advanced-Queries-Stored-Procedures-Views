using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class VwUserPostMetric
{
    public int? UserId { get; set; }

    public int? TotalPosts { get; set; }

    public int? TotalViews { get; set; }

    public int? AvgScore { get; set; }
}
