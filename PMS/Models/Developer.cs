using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class Developer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? CreatedBy { get; set; }
}
