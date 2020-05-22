using System.Collections.Generic;

namespace cw11.Models
{
    public class Medicament
    {
        public Medicament()
        {
            PrescriptionMedicaments = new HashSet<Prescription_Medicament>();
        }

        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public ICollection<Prescription_Medicament> PrescriptionMedicaments { get; set; }
    }
}
