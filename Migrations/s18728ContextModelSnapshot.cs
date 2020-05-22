﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw11.Models;

namespace cw11.Migrations
{
    [DbContext(typeof(s18728Context))]
    partial class s18728ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "gakrzy@dmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Gagagaga"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "korzemil@dmail.com",
                            FirstName = "Milena",
                            LastName = "Korzenna"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "walucjan@dmail.com",
                            FirstName = "Lucjan",
                            LastName = "Walenrod"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "birena@dmail.com",
                            FirstName = "Irena",
                            LastName = "Bogobojna"
                        },
                        new
                        {
                            IdDoctor = 5,
                            Email = "kwama@dmail.com",
                            FirstName = "Marta",
                            LastName = "Kwiatkowska"
                        });
                });

            modelBuilder.Entity("cw11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_PK");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Usmierza swad",
                            Name = "KorzenioLUX",
                            Type = "Suplement diety"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Dziala przeciwzapalnie",
                            Name = "PromIBum",
                            Type = "Lek przeciwzapalny"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "Dziala przeciwbolowo",
                            Name = "Papap",
                            Type = "Lek przeciwbolowy"
                        },
                        new
                        {
                            IdMedicament = 4,
                            Description = "Uzupelnia witamine c",
                            Name = "Cetamin",
                            Type = "Suplement diety"
                        },
                        new
                        {
                            IdMedicament = 5,
                            Description = "Uzupelnia witamine b",
                            Name = "TyraniX",
                            Type = "Suplement diety"
                        });
                });

            modelBuilder.Entity("cw11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient")
                        .HasName("Patient_PK");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2020, 5, 22, 16, 19, 54, 920, DateTimeKind.Local).AddTicks(4594),
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5785),
                            FirstName = "Waclaw",
                            LastName = "Dzban"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5848),
                            FirstName = "Baltazar",
                            LastName = "Gabka"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5855),
                            FirstName = "Krystyna",
                            LastName = "Mazurska"
                        },
                        new
                        {
                            IdPatient = 5,
                            BirthDate = new DateTime(2020, 5, 22, 16, 19, 54, 923, DateTimeKind.Local).AddTicks(5859),
                            FirstName = "Joanna",
                            LastName = "Kasztan"
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescription_PK");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(1585),
                            DueDate = new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(2161),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3550),
                            DueDate = new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3591),
                            IdDoctor = 4,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3618),
                            DueDate = new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3621),
                            IdDoctor = 3,
                            IdPatient = 3
                        },
                        new
                        {
                            IdPrescription = 4,
                            Date = new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3625),
                            DueDate = new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3629),
                            IdDoctor = 5,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 5,
                            Date = new DateTime(2020, 5, 22, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3633),
                            DueDate = new DateTime(2020, 5, 29, 16, 19, 54, 964, DateTimeKind.Local).AddTicks(3636),
                            IdDoctor = 2,
                            IdPatient = 4
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "Stosowac dwa razy dziennie",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 4,
                            IdPrescription = 2,
                            Details = "Stosowac trzy razy dziennie",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 5,
                            IdPrescription = 2,
                            Details = "Stosowac trzy razy dziennie",
                            Dose = 0
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 3,
                            Details = "Stosowac dwa razy dziennie, przez tydzien",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 3,
                            IdPrescription = 4,
                            Details = "Stosowac trzy razy dziennie, az do zakonczenia paczki",
                            Dose = 2
                        },
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 5,
                            Details = "Stosowac dwa razy dziennie",
                            Dose = 1
                        });
                });

            modelBuilder.Entity("cw11.Models.Prescription", b =>
                {
                    b.HasOne("cw11.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .HasConstraintName("Doctor_Prescription")
                        .IsRequired();

                    b.HasOne("cw11.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .HasConstraintName("Patient_Prescription")
                        .IsRequired();
                });

            modelBuilder.Entity("cw11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("cw11.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .HasConstraintName("Medicament_Prescription_Medicament")
                        .IsRequired();

                    b.HasOne("cw11.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .HasConstraintName("Prescription_Prescription_Medicament")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
