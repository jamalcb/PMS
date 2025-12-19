using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class Expence
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }
}
