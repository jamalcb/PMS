using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class ProjectDeveloper
{
    public int Id { get; set; }

    public int DeveloperId { get; set; }

    public int ProjectId { get; set; }

    public int PhaseId { get; set; }

    public decimal? AmountPaid { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public string? PaidBy { get; set; }

    public virtual ProjectPhase Phase { get; set; } = null!;
}
