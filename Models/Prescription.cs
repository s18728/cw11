using System;
using System.Collections.Generic;

namespace cw11.Models
{
    public class Prescription
    {
        public Prescription()
        {
            PrescriptionMedicaments = new HashSet<Prescription_Medicament>();
        }

        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    }
}
