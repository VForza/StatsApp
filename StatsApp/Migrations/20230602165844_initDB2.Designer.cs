﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StatsApp.Data;

namespace StatsApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230602165844_initDB2")]
    partial class initDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<long?>("clicks")
                        .HasColumnType("bigint")
                        .HasColumnName("clicks");

                    b.Property<decimal?>("cost")
                        .HasColumnType("numeric(4,2)")
                        .HasColumnName("cost");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<long?>("views")
                        .HasColumnType("bigint")
                        .HasColumnName("views");

                    b.HasKey("Id")
                        .HasName("pk_statistics");

                    b.ToTable("statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
