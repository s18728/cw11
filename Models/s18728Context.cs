using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace cw11.Models
{
    public class s18728Context : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        public s18728Context(DbContextOptions<s18728Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            List<Patient> patients = new List<Patient>();
            patients.Add(
                new Patient {FirstName = "Jan", LastName = "Kowalski", IdPatient = 1, BirthDate = DateTime.Now});
            patients.Add(
                new Patient { FirstName = "Waclaw", LastName = "Dzban", IdPatient = 2, BirthDate = DateTime.Now });
            patients.Add(
                new Patient { FirstName = "Baltazar", LastName = "Gabka", IdPatient = 3, BirthDate = DateTime.Now });
            patients.Add(
                new Patient { FirstName = "Krystyna", LastName = "Mazurska", IdPatient = 4, BirthDate = DateTime.Now });
            patients.Add(
                new Patient { FirstName = "Joanna", LastName = "Kasztan", IdPatient = 5, BirthDate = DateTime.Now });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e=>e.IdPatient).HasName("Patient_PK");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();
                entity.HasData(patients);
            });

            List<Doctor> doctors = new List<Doctor>();

            doctors.Add(new Doctor{IdDoctor = 1, FirstName = "Krzysztof", LastName = "Gagagaga", Email = "gakrzy@dmail.com"});
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Milena", LastName = "Korzenna", Email = "korzemil@dmail.com" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Lucjan", LastName = "Walenrod", Email = "walucjan@dmail.com" });
            doctors.Add(new Doctor { IdDoctor = 4, FirstName = "Irena", LastName = "Bogobojna", Email = "birena@dmail.com" });
            doctors.Add(new Doctor { IdDoctor = 5, FirstName = "Marta", LastName = "Kwiatkowska", Email = "kwama@dmail.com" });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(100).IsRequired();
                entity.HasData(doctors);
            });

            List<Medicament> medicaments = new List<Medicament>();

            medicaments.Add(new Medicament{IdMedicament = 1, Name = "KorzenioLUX", Description = "Usmierza swad", Type = "Suplement diety"});
            medicaments.Add(new Medicament { IdMedicament = 2, Name = "PromIBum", Description = "Dziala przeciwzapalnie", Type = "Lek przeciwzapalny" });
            medicaments.Add(new Medicament { IdMedicament = 3, Name = "Papap", Description = "Dziala przeciwbolowo", Type = "Lek przeciwbolowy" });
            medicaments.Add(new Medicament { IdMedicament = 4, Name = "Cetamin", Description = "Uzupelnia witamine c", Type = "Suplement diety" });
            medicaments.Add(new Medicament { IdMedicament = 5, Name = "TyraniX", Description = "Uzupelnia witamine b", Type = "Suplement diety" });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.HasKey(e => e.IdMedicament).HasName("Medicament_PK");
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Type).HasMaxLength(100).IsRequired();
                entity.HasData(medicaments);
            });

            List<Prescription> prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription{IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), IdPatient = 1, IdDoctor = 1});
            prescriptions.Add(new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), IdPatient = 2, IdDoctor = 4 });
            prescriptions.Add(new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), IdPatient = 3, IdDoctor = 3 });
            prescriptions.Add(new Prescription { IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), IdPatient = 1, IdDoctor = 5 });
            prescriptions.Add(new Prescription { IdPrescription = 5, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(7), IdPatient = 4, IdDoctor = 2 });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.IdPrescription).HasName("Prescription_PK");
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.DueDate).IsRequired();

                entity.HasOne(e => e.Patient)
                    .WithMany(e => e.Prescriptions)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasForeignKey(e=>e.IdPatient)
                    .HasConstraintName("Patient_Prescription");

                entity.HasOne(e => e.Doctor)
                    .WithMany(e => e.Prescriptions)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasForeignKey(e => e.IdDoctor)
                    .HasConstraintName("Doctor_Prescription");

                entity.HasData(prescriptions);
            });

            List<Prescription_Medicament> pre_medList = new List<Prescription_Medicament>();

            pre_medList.Add(new Prescription_Medicament{IdMedicament = 1, IdPrescription = 1, Details = "Stosowac dwa razy dziennie"});
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 4, IdPrescription = 2, Details = "Stosowac trzy razy dziennie" });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 5, IdPrescription = 2, Details = "Stosowac trzy razy dziennie" });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 3, Details = "Stosowac dwa razy dziennie, przez tydzien", Dose = 2 });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 3, IdPrescription = 4, Details = "Stosowac trzy razy dziennie, az do zakonczenia paczki", Dose = 2 });
            pre_medList.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 5, Details = "Stosowac dwa razy dziennie", Dose = 1 });

            modelBuilder.Entity<Prescription_Medicament>(entity =>
            {
                entity.HasKey(e => new {e.IdMedicament, e.IdPrescription});
                entity.Property(e => e.Details).HasMaxLength(100).IsRequired();

                entity.HasOne(e => e.Medicament)
                    .WithMany(e => e.PrescriptionMedicaments)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasForeignKey(e => e.IdMedicament)
                    .HasConstraintName("Medicament_Prescription_Medicament");

                entity.HasOne(e => e.Prescription)
                    .WithMany(e => e.PrescriptionMedicaments)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasForeignKey(e => e.IdPrescription)
                    .HasConstraintName("Prescription_Prescription_Medicament");

                entity.HasData(pre_medList);
            });



        }
    }
}
