using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class User
{
    public int Id { get; set; }

    public string IdentityId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? Contact { get; set; }
}
