﻿using System.Collections.Generic;

namespace cw11.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Prescriptions = new HashSet<Prescription>();
        }

        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }

        public override string ToString()
        {
            return IdDoctor+" " +FirstName + " " + LastName + " " + Email;
        }
    }
}
