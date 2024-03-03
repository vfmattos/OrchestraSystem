﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrchestraSystem.Data;

#nullable disable

namespace OrchestraSystem.Migrations
{
    [DbContext(typeof(OrchestraContext))]
    [Migration("20240303120730_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InstrumentModelMusicoModel", b =>
                {
                    b.Property<int>("InstrumentsId")
                        .HasColumnType("int");

                    b.Property<int>("MusiciansId")
                        .HasColumnType("int");

                    b.HasKey("InstrumentsId", "MusiciansId");

                    b.HasIndex("MusiciansId");

                    b.ToTable("InstrumentModelMusicoModel");
                });

            modelBuilder.Entity("InstrumentModelSymphonyModel", b =>
                {
                    b.Property<int>("RequiredInstrumentsId")
                        .HasColumnType("int");

                    b.Property<int>("SymphoniesId")
                        .HasColumnType("int");

                    b.HasKey("RequiredInstrumentsId", "SymphoniesId");

                    b.HasIndex("SymphoniesId");

                    b.ToTable("InstrumentModelSymphonyModel");
                });

            modelBuilder.Entity("OrchestraSystem.Models.InstrumentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("OrchestraSystem.Models.MusicoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Idade")
                        .HasColumnType("longtext");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("OrchestraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrchestraId");

                    b.ToTable("Musico");
                });

            modelBuilder.Entity("OrchestraSystem.Models.OrchestraModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Orchestra");
                });

            modelBuilder.Entity("OrchestraSystem.Models.OrchestraSymphonyModel", b =>
                {
                    b.Property<int>("OrchestraId")
                        .HasColumnType("int");

                    b.Property<int>("SymphonyId")
                        .HasColumnType("int");

                    b.HasKey("OrchestraId", "SymphonyId");

                    b.HasIndex("SymphonyId");

                    b.ToTable("OrchestraSymphony");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Composer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Symphony");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyMusicianModel", b =>
                {
                    b.Property<int>("MusicianId")
                        .HasColumnType("int");

                    b.Property<int>("SymphonyId")
                        .HasColumnType("int");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("int");

                    b.HasKey("MusicianId", "SymphonyId");

                    b.HasIndex("InstrumentId");

                    b.HasIndex("SymphonyId");

                    b.ToTable("SymphonyMusician");
                });

            modelBuilder.Entity("InstrumentModelMusicoModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.InstrumentModel", null)
                        .WithMany()
                        .HasForeignKey("InstrumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrchestraSystem.Models.MusicoModel", null)
                        .WithMany()
                        .HasForeignKey("MusiciansId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentModelSymphonyModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.InstrumentModel", null)
                        .WithMany()
                        .HasForeignKey("RequiredInstrumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrchestraSystem.Models.SymphonyModel", null)
                        .WithMany()
                        .HasForeignKey("SymphoniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrchestraSystem.Models.MusicoModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.OrchestraModel", "Orchestra")
                        .WithMany("Musicians")
                        .HasForeignKey("OrchestraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orchestra");
                });

            modelBuilder.Entity("OrchestraSystem.Models.OrchestraSymphonyModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.OrchestraModel", "Orchestra")
                        .WithMany("OrchestraSymphonies")
                        .HasForeignKey("OrchestraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrchestraSystem.Models.SymphonyModel", "Symphony")
                        .WithMany("OrchestraSymphonies")
                        .HasForeignKey("SymphonyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orchestra");

                    b.Navigation("Symphony");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyMusicianModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.InstrumentModel", "Instrument")
                        .WithMany()
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrchestraSystem.Models.MusicoModel", "Musician")
                        .WithMany("SymphonyMusicians")
                        .HasForeignKey("MusicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrchestraSystem.Models.SymphonyModel", "Symphony")
                        .WithMany("SymphonyMusicians")
                        .HasForeignKey("SymphonyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrument");

                    b.Navigation("Musician");

                    b.Navigation("Symphony");
                });

            modelBuilder.Entity("OrchestraSystem.Models.MusicoModel", b =>
                {
                    b.Navigation("SymphonyMusicians");
                });

            modelBuilder.Entity("OrchestraSystem.Models.OrchestraModel", b =>
                {
                    b.Navigation("Musicians");

                    b.Navigation("OrchestraSymphonies");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyModel", b =>
                {
                    b.Navigation("OrchestraSymphonies");

                    b.Navigation("SymphonyMusicians");
                });
#pragma warning restore 612, 618
        }
    }
}
