﻿// <auto-generated />
using System;
using BiuroRzeczyZnalezionych;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BiuroRzeczyZnalezionych.Migrations
{
    [DbContext(typeof(PrzedmiotContext))]
    [Migration("20230121222143_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BiuroRzeczyZnalezionych.Models.PrzedmiotModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataDodania")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataZwrotu")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Przedmioty");
                });
#pragma warning restore 612, 618
        }
    }
}