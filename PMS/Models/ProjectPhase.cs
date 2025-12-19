using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class ProjectPhase
{
    public int Id { get; set; }

    public int ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int ProposedHrs { get; set; }

    public decimal? InitialPayment { get; set; }

    public DateOnly? InitialPayDate { get; set; }

    public decimal? FinalPayment { get; set; }

    public DateOnly? FinalPayDate { get; set; }

    public string? InitialPayBy { get; set; }

    public string? FinalPayBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual ICollection<ProjectDeveloper> ProjectDevelopers { get; set; } = new List<ProjectDeveloper>();
}
