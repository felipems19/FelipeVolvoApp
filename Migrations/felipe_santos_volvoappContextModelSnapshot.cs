﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using felipe_santos_volvoapp.Data;

namespace felipe_santos_volvoapp.Migrations
{
    [DbContext(typeof(felipe_santos_volvoappContext))]
    partial class felipe_santos_volvoappContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("felipe_santos_volvoapp.Models.Caminhao", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AnoFabricacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AnoModelo")
                        .HasColumnType("datetime2");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Caminhao");
                });
#pragma warning restore 612, 618
        }
    }
}