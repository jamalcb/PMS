using System;
using System.Collections.Generic;

namespace PMS.Models;

public partial class Project
{
    public int Id { get; set; }

    public string ProjName { get; set; } = null!;

    public string ClientName { get; set; } = null!;

    public DateOnly CreatedOn { get; set; }

    public virtual ICollection<ProjectPhase> ProjectPhases { get; set; } = new List<ProjectPhase>();
}
