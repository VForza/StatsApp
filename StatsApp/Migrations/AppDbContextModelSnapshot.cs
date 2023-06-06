﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StatsApp.Data;

namespace StatsApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("StatsApp.Data.Models.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Clicks")
                        .HasColumnType("integer")
                        .HasColumnName("clicks");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("numeric")
                        .HasColumnName("cost");

                    b.Property<decimal?>("Cpc")
                        .HasColumnType("numeric")
                        .HasColumnName("cpc");

                    b.Property<decimal?>("Cpm")
                        .HasColumnType("numeric")
                        .HasColumnName("cpm");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<int?>("Views")
                        .HasColumnType("integer")
                        .HasColumnName("views");

                    b.HasKey("Id")
                        .HasName("pk_statistics");

                    b.ToTable("statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
