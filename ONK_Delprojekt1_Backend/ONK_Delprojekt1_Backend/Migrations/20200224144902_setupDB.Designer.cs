﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ONK_Delprojekt1_Backend.Data;

namespace ONK_Delprojekt1_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200224144902_setupDB")]
    partial class setupDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ONK_Delprojekt1_Backend.Models.Haandvaerker", b =>
                {
                    b.Property<int>("HaandvaerkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("HVAnsaettelsedato")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HVEfternavn")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HVFagomraade")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HVFornavn")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("HaandvaerkerId");

                    b.ToTable("Haandvaerkerer");
                });

            modelBuilder.Entity("ONK_Delprojekt1_Backend.Models.Vaerktoej", b =>
                {
                    b.Property<long>("VTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int?>("LiggerIvtk")
                        .HasColumnType("int");

                    b.Property<int?>("LiggerIvtkNavigationVTKId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VTAnskaffet")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("VTFabrikat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTModel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTSerienr")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("VTId");

                    b.HasIndex("LiggerIvtkNavigationVTKId");

                    b.ToTable("Vaerktoejer");
                });

            modelBuilder.Entity("ONK_Delprojekt1_Backend.Models.Vaerktoejskasse", b =>
                {
                    b.Property<int>("VTKId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EjesAfNavigationHaandvaerkerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VTKAnskaffet")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("VTKEjesAf")
                        .HasColumnType("int");

                    b.Property<string>("VTKFabrikat")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTKFarve")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTKModel")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VTKSerienummer")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("VTKId");

                    b.HasIndex("EjesAfNavigationHaandvaerkerId");

                    b.ToTable("Vaerktoejskasser");
                });

            modelBuilder.Entity("ONK_Delprojekt1_Backend.Models.Vaerktoej", b =>
                {
                    b.HasOne("ONK_Delprojekt1_Backend.Models.Vaerktoejskasse", "LiggerIvtkNavigation")
                        .WithMany("Vaerktoej")
                        .HasForeignKey("LiggerIvtkNavigationVTKId");
                });

            modelBuilder.Entity("ONK_Delprojekt1_Backend.Models.Vaerktoejskasse", b =>
                {
                    b.HasOne("ONK_Delprojekt1_Backend.Models.Haandvaerker", "EjesAfNavigation")
                        .WithMany("Vaerktoejskasse")
                        .HasForeignKey("EjesAfNavigationHaandvaerkerId");
                });
#pragma warning restore 612, 618
        }
    }
}
