﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChuVanHiep250.Migrations
{
    [DbContext(typeof(AppplicationDbContext))]
    partial class AppplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ChuVanHiep250.Models.LapTop", b =>
                {
                    b.Property<string>("TenLapTop")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("TEXT");

                    b.HasKey("TenLapTop");

                    b.ToTable("LapTop");
                });
#pragma warning restore 612, 618
        }
    }
}
