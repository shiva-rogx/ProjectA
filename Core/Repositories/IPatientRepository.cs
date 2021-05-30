using System.Collections.Generic;
using System.Linq;
using ClinicManagement.Core.Models;

namespace ClinicManagement.Core.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        IEnumerable<Patient> GetRecentPatients();
       
        Patient GetPatient(int id);
        
        void Add(Patient patient);
        void Remove(Patient patient);
    }
}
