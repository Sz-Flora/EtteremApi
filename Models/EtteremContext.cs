using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EtteremApi.Models;

public partial class EtteremContext : DbContext
{
    public EtteremContext()
    {
    }

    public EtteremContext(DbContextOptions<EtteremContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kapcsolo> Kapcsolos { get; set; }

    public virtual DbSet<Rendele> Rendeles { get; set; }

    public virtual DbSet<Termekek> Termekeks { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
