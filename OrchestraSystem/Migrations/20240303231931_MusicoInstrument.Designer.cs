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
    [Migration("20240303231931_MusicoInstrument")]
    partial class MusicoInstrument
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

                    b.ToTable("MusicoInstrument", (string)null);
                });

            modelBuilder.Entity("OrchestraSystem.Models.InstrumentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("SymphonyModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SymphonyModelId");

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

                    b.HasKey("Id");

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

                    b.Property<int?>("OrchestraModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrchestraModelId");

                    b.ToTable("Symphony");
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

            modelBuilder.Entity("OrchestraSystem.Models.InstrumentModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.SymphonyModel", null)
                        .WithMany("RequiredInstruments")
                        .HasForeignKey("SymphonyModelId");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyModel", b =>
                {
                    b.HasOne("OrchestraSystem.Models.OrchestraModel", null)
                        .WithMany("Sinfonies")
                        .HasForeignKey("OrchestraModelId");
                });

            modelBuilder.Entity("OrchestraSystem.Models.OrchestraModel", b =>
                {
                    b.Navigation("Sinfonies");
                });

            modelBuilder.Entity("OrchestraSystem.Models.SymphonyModel", b =>
                {
                    b.Navigation("RequiredInstruments");
                });
#pragma warning restore 612, 618
        }
    }
}
