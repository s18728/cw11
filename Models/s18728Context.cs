using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e=>e.IdPatient).HasName("Patient_PK");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.BirthDate).IsRequired();
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.HasKey(e => e.IdMedicament).HasName("Medicament_PK");
                entity.Property(e => e.Name).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Description).HasMaxLength(100).IsRequired();
                entity.Property(e => e.Type).HasMaxLength(100).IsRequired();
            });

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
            });

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
            });



        }
    }
}
