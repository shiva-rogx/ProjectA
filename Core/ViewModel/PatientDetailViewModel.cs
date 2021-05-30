using System.Collections.Generic;
using ClinicManagement.Core.Models;

namespace ClinicManagement.Core.ViewModel
{
    public class PatientDetailViewModel
    {
        public Patient Patient { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
     
        public int CountAppointments { get; set; }
        public int CountAttendance { get; set; }
    }
}