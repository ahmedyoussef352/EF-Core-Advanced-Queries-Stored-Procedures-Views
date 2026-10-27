using System;
using System.Collections.Generic;

namespace EfCoreSeesion5.Entities;

public partial class DeletedPost
{
    public int Id { get; set; }

    public int? DeletedPostId { get; set; }

    public int? OwnerUserId { get; set; }

    public string? Title { get; set; }

    public int? Score { get; set; }

    public DateOnly? CreationDate { get; set; }
}
