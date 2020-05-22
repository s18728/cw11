using System;
using System.Collections.Generic;
using System.Linq;
using cw11.Models;

namespace cw11.Services
{
    public class ImplementedDbService : IDbService
    {
        private readonly s18728Context _context;

        public ImplementedDbService(s18728Context context)
        {
            _context = context;
        }

        public List<string> getDoctors()
        {
            List<string> docList = new List<string>();

            var tmp = _context.Doctor.ToList();

            foreach (Doctor doctor in tmp)
            {
                docList.Add(doctor.ToString());
            }

            return docList;
        }

        public bool addDoctor(Doctor newDoctor)
        {
            try
            {
                _context.Doctor.Add(newDoctor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool modifyDoctor(Doctor modifiedDoctor)
        {
            try
            {
                var doctor = _context.Doctor.Single(d => d.IdDoctor==modifiedDoctor.IdDoctor);

                
                if (modifiedDoctor.FirstName != null)
                {
                    doctor.FirstName = modifiedDoctor.FirstName;
                }

                if (modifiedDoctor.LastName != null)
                {
                    doctor.LastName = modifiedDoctor.LastName;
                }

                if (modifiedDoctor.Email != null)
                {
                    doctor.Email = modifiedDoctor.Email;
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool removeDoctor(int IdDoctor)
        {
            try
            {
                var doctor = _context.Doctor.Single(d => d.IdDoctor==IdDoctor);
                _context.Doctor.Remove(doctor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
