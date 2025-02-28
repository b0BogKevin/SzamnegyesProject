﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace szamnegyes3.Models;

public partial class AdatbContext : DbContext
{
    public AdatbContext()
    {
    }

    public AdatbContext(DbContextOptions<AdatbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Szamnegye> Szamnegyes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Database\\adatb.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Szamnegye>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Szamok).HasColumnName("szamok");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
