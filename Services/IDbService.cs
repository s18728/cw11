using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;

namespace cw11.Services
{
    public interface IDbService
    {
        public List<string> getDoctors();

        public bool addDoctor(Doctor newDoctor);

        public bool modifyDoctor(Doctor modifiedDoctor);

        public bool removeDoctor(int IdDoctor);
    }
}
