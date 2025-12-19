using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PMS.Models;

public partial class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

   
    public virtual DbSet<Developer> Developers { get; set; }

    public virtual DbSet<Expence> Expences { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectDeveloper> ProjectDevelopers { get; set; }

    public virtual DbSet<ProjectPhase> ProjectPhases { get; set; }

    public virtual DbSet<User> User { get; set; }

   
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
